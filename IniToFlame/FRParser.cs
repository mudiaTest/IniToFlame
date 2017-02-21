using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.Mentalis.Files;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Xml;

namespace Ini2Flame
{
    public class FRParser
    {
        const string cst_role = "GDS32DLL";
        const string cst_charset = "WIN1250";
        const string cst_user = "SYSTEM";
        string dbNamespace = "";
        string fmaxDBId = "";
        XmlDocument fdoc;

        static string[] dbSectArray = { "SystemDB", "CentralaDB", "MainDB", "ReasDB", "ReasDBUT-Del", 
                                        "FK*DB", "BlobDB", "EwidDB", "WymiennikDB", "NadzorcaDB", 
                                        "PodajnikDB", "PodajnikDBWzor", "AgentDB", "ZgloszDB" };
        static string[] defaultDBSectArray = { "SystemDB", "NadzorcaDB" };

        public static String GetFRConfPathName()
        {
            return (Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\AppData\Local\flamerobin\fr_databases.conf"));
        }

        //Czy sekcja jest bazą podstawową
        public static bool SystemDB(String asect)
        {
            string[] stringArray = { "SystemDB" };
            return (Array.IndexOf(stringArray, asect.Substring(0, asect.IndexOf(':'))) >= 0);
        }

        //Czy sekcja ma być wybrana domyślnie
        public static bool DefaultDBSect(String asect)
        {
            return (Array.IndexOf(defaultDBSectArray, asect.Substring(0, asect.IndexOf(':'))) >= 0);
        }

        //Czy sekcja jest bazą, która ma mieć możliwość dodania do FR
        public static bool DBSect(String asect)
        {
            return (Array.IndexOf(dbSectArray, asect) >= 0);
        }

        public Dictionary<string, DBHeaderObj> GetBiuSectChooseDict(String apath)
        {
            Dictionary<string, DBHeaderObj> result = new Dictionary<string, DBHeaderObj>();
            Trace.Assert(File.Exists(apath), "Brak wkazanego pliku Ini.");
            String dictPath = Path.GetDirectoryName(apath);
            foreach (string fileName in Directory.GetFiles(dictPath, "*.ini") /*EnumerateFiles(dictPath, "*.ini")*/)
            {
                FillSections(result, Path.Combine(dictPath, fileName));
            }            
            return (result);
        }
        private void FillSections(Dictionary<string, DBHeaderObj> adict, string apath)
            {
                IniReader ini = new IniReader(apath);
                IEnumerator e = ini.GetSectionNames().GetEnumerator();
                String key;
                while (e.MoveNext())
                {
                    key = e.Current.ToString()+':'+Path.GetFileName(ini.ReadString(e.Current.ToString(), "databaseName"));
                    if (DBSect(e.Current.ToString()) && !adict.ContainsKey(key))
                        adict.Add(key, new DBHeaderObj(apath, e.Current.ToString(), DefaultDBSect(key)));
                }
            }

        public DBNode GetDBFromSection(string asection, string apath, string aid)
        {
            IniReader ini = new IniReader(apath);
            DBNode newDBNode = new DBNode(aid,
                                          ini.ReadString(asection, "databaseName"),
                                          ini.ReadString(asection, "databaseName"),
                                          cst_charset,
                                          cst_user,
                                          ini.ReadString(asection, "password"),
                                          cst_role,
                                          dbNamespace,
                                          ini.ReadString(asection, "serverName")
                                    );
            return (newDBNode);
        }

        public XmlDocument doc
        {
            get
            {
                if (fdoc == null)
                {
                    fdoc = new XmlDocument();
                    fdoc.Load(GetFRConfPathName());
                }
                return fdoc;
            }
            set { fdoc = value; }
        }

        public XmlNode root
        {
            get
            {
                return doc.DocumentElement;
            }
        }

        public XmlNode GetSrvByName(string aname)
        {
            XmlNode result = null;
            foreach (XmlNode child in root.ChildNodes)
            {
                if (child.Name == "server")
                {
                    Trace.Assert(child.FirstChild.Name == "name", "Pierwsze dziecko węzła 'server' to '" + child.FirstChild.Name + "'");
                    if (child.FirstChild.InnerText == aname)
                        return child;
                }
            }
            return result;
        }

        public XmlNode GetDBNodeByName(string apath, XmlNode asrvNode)
        {
            XmlNode result = null;
            foreach (XmlNode child in asrvNode.ChildNodes)
            {
                if (child.Name == "database")
                {
                    foreach (XmlNode child2 in child.ChildNodes)
                    {
                        if (child2.Name == "path")
                        {
                            if (child2.FirstChild.InnerText == apath)
                                return child;
                        }
                    } 
                }
            }
            return result;
        }

        public string NextDBId()
        {
            if (fmaxDBId == "")
            {                
                Trace.Assert(root.FirstChild.Name == "nextId", "Pierwsze dziecko węzła 'root' to '" + root.FirstChild.Name + "'");
                fmaxDBId =root.FirstChild.InnerText;
            }
            fmaxDBId = (int.Parse(fmaxDBId) + 1).ToString();
            return fmaxDBId;
        }

        public XmlNode ServerNode(string aname, string ahost)
        {

            XmlNode srvNode = GetSrvByName(aname);

            if (srvNode == null)
            {
                srvNode = doc.CreateNode(System.Xml.XmlNodeType.Element, "server", dbNamespace);

                XmlNode nameNode = doc.CreateNode(System.Xml.XmlNodeType.Element, "name", dbNamespace);
                nameNode.InnerText = aname;
                srvNode.AppendChild(nameNode);

                XmlNode hostNode = doc.CreateNode(System.Xml.XmlNodeType.Element, "host", dbNamespace);
                hostNode.InnerText = ahost;
                srvNode.AppendChild(hostNode);

                root.AppendChild(srvNode);
            }
            return srvNode;
        }

        public void AddDBNode(XmlNode aserverNode, DBNode aDBNode)
        {
           aDBNode.AddDB(aserverNode);
        }
    }
}
