using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Org.Mentalis.Files;
using System.Xml;

namespace Ini2Flame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(String afile)
        {
            InitializeComponent();
            edtOpen.Text = afile;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetFileName(String afile)
        {
            edtOpen.Text = afile;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (File.Exists(edtOpen.Text))
                openFileDialog.FileName = edtOpen.Text;
            else
                openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtOpen.Text = openFileDialog.FileName;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Trace.Assert(File.Exists(edtOpen.Text), "Brak wkazanego pliku Ini.");
            Trace.Assert(!edtGroupName.Enabled || edtGroupName.Text != "", "Pusta nazwa grupy.");
            FRParser frp = new FRParser();
            Dictionary<string, DBHeaderObj> dictDBHeaders = frp.GetBiuSectChooseDict(edtOpen.Text);
          
            //Formatka wyboru baz do dodania
            ChooseForm f = new ChooseForm(dictDBHeaders);
            if (f.ShowDialog() != DialogResult.OK)
                return;

            //server + dataBase
            XmlNode srvNode;
            DBNode dbNode;

            foreach (KeyValuePair<string, DBHeaderObj> pair in dictDBHeaders)
                if (pair.Value.blSelect)
                {
                    dbNode = frp.GetDBFromSection(pair.Value.stSection, pair.Value.stFile, frp.NextDBId());
                    if (cbDodGrupe.Checked)
                        srvNode = frp.ServerNode(dbNode.server + "_" + edtGroupName.Text, dbNode.server);
                    else
                        srvNode = frp.ServerNode(dbNode.server, dbNode.server);
                    //jeśli w node serwera jest już baza danych o daneej path, to nie tworzymy duplikatu
                    if (frp.GetDBNodeByName(dbNode.path, srvNode) == null)
                        frp.AddDBNode(srvNode, dbNode);
                }
            frp.doc.Save(FRParser.GetFRConfPathName());
        }

        private void cbDodGrupe_Click(object sender, EventArgs e)
        {
            edtGroupName.Enabled = cbDodGrupe.Checked;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FRParser frp = new FRParser();
            EditDBForm f = new EditDBForm(frp);
            if (f.ShowDialog() == DialogResult.OK)            
                frp.doc.Save(FRParser.GetFRConfPathName());          

        }
    }
}
