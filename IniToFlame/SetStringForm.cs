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
    public partial class SetStringForm : Form
    {
        public string text;
        public SetStringForm(string atext)
        {
            InitializeComponent();
            textBox1.Text = atext;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }
    }
}
