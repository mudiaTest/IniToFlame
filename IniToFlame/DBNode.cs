using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Ini2Flame
{
    public class DBNode
    {
        public string id;
        public string name;
        public string path;
        public string charset;
        public string username;
        public string password;
        public string role;
        public string strNamespace;
        public string server;

        public DBNode(string aid,
                      string aname,
                      string apath,
                      string acharset,
                      string ausername,
                      string apassword,
                      string arole,
                      string astrNamespace,
                      string aserver)
        {
            id = aid;
            name = aname;
            path = apath;
            charset = acharset;
            username = ausername;
            password = apassword;
            role = arole;
            strNamespace = astrNamespace;
            server = aserver;
        }

        public void AddDB(XmlNode aroot)
        {
            XmlWriter writer = aroot.CreateNavigator().AppendChild();
            writer.WriteStartElement("database", strNamespace);
            writer.WriteElementString("id", strNamespace, id);
            writer.WriteElementString("name", strNamespace, name);
            writer.WriteElementString("path", strNamespace, path);
            writer.WriteElementString("charset", strNamespace, charset);
            writer.WriteElementString("username", strNamespace, username);
            writer.WriteElementString("password", strNamespace, password);
            writer.WriteElementString("role", strNamespace, role);
            writer.WriteElementString("authentication", strNamespace, "pwd");
            writer.WriteStartElement("database", strNamespace);
            writer.Close();
        }
    }
}
