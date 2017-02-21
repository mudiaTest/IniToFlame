using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ini2Flame
{
    public partial class ChooseForm : Form
    {
        private Dictionary<string, DBHeaderObj> choosen;

        private void CBCheckChange(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            choosen[cb.Text].blSelect = cb.Checked;
        }

        public ChooseForm(Dictionary<string, DBHeaderObj> adictChoosen)
        {
            InitializeComponent();
            choosen = adictChoosen;
            CheckBox cb = null;
            tlPanel.RowCount = (int)Math.Ceiling(adictChoosen.Count / 2.0);
            tlPanel.RowStyles.Clear();
            //Wypełniam w 2 przebiegach, aby wpierw sosać bazy podstawowe, a dopiero potem te, które są ukrywane (nadzorca jest wyjątkiem)
            foreach (KeyValuePair<string, DBHeaderObj> pair in adictChoosen)
                if (FRParser.SystemDB(pair.Key))
                {         
                    cb = new CheckBox();
                    cb.Text = pair.Key;
                    cb.Checked = pair.Value.blSelect;
                    cb.Dock = DockStyle.Top;
                    cb.CheckedChanged += CBCheckChange;
                    tlPanel.Controls.Add(cb);
                    tlPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23));
                }

            foreach (KeyValuePair<string, DBHeaderObj> pair in adictChoosen)
                if (!FRParser.SystemDB(pair.Key))
                {
                    cb = new CheckBox();
                    cb.Text = pair.Key;
                    cb.Checked = pair.Value.blSelect;
                    cb.Dock = DockStyle.Top;
                    cb.CheckedChanged += CBCheckChange;
                    tlPanel.Controls.Add(cb);
                    tlPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23));
                }
            Height = pnlButtons.Height + ((25 + 6) * tlPanel.RowCount);
            ShowHide(); 
        }

        private void ShowHide()
        {
            foreach (Control cb in tlPanel.Controls)
                cb.Visible = FRParser.DefaultDBSect(cb.Text) || cbAll.Checked;
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            ShowHide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in tlPanel.Controls)
                cb.Checked = true;
        }

        private void btnChNone_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in tlPanel.Controls)
                cb.Checked = false;
        }
    }
}
