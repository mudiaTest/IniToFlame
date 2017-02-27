namespace Ini2Flame
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.edtOpen = new System.Windows.Forms.TextBox();
            this.gbOpen = new System.Windows.Forms.GroupBox();
            this.edtGroupName = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbDodGrupe = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbShell = new System.Windows.Forms.GroupBox();
            this.btnShellAdd = new System.Windows.Forms.Button();
            this.btnShellDel = new System.Windows.Forms.Button();
            this.gbOpen.SuspendLayout();
            this.gbShell.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtOpen
            // 
            this.edtOpen.Location = new System.Drawing.Point(8, 19);
            this.edtOpen.Name = "edtOpen";
            this.edtOpen.Size = new System.Drawing.Size(343, 20);
            this.edtOpen.TabIndex = 0;
            this.edtOpen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbOpen
            // 
            this.gbOpen.Controls.Add(this.edtGroupName);
            this.gbOpen.Controls.Add(this.btnDodaj);
            this.gbOpen.Controls.Add(this.cbDodGrupe);
            this.gbOpen.Controls.Add(this.btnOpen);
            this.gbOpen.Controls.Add(this.edtOpen);
            this.gbOpen.Location = new System.Drawing.Point(5, 12);
            this.gbOpen.Name = "gbOpen";
            this.gbOpen.Size = new System.Drawing.Size(390, 103);
            this.gbOpen.TabIndex = 1;
            this.gbOpen.TabStop = false;
            this.gbOpen.Text = "Dodaj istniejącą bazę";
            // 
            // edtGroupName
            // 
            this.edtGroupName.Location = new System.Drawing.Point(127, 43);
            this.edtGroupName.Name = "edtGroupName";
            this.edtGroupName.Size = new System.Drawing.Size(224, 20);
            this.edtGroupName.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(8, 68);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj Ini";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbDodGrupe
            // 
            this.cbDodGrupe.AutoSize = true;
            this.cbDodGrupe.Checked = true;
            this.cbDodGrupe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDodGrupe.Location = new System.Drawing.Point(8, 45);
            this.cbDodGrupe.Name = "cbDodGrupe";
            this.cbDodGrupe.Size = new System.Drawing.Size(113, 17);
            this.cbDodGrupe.TabIndex = 4;
            this.cbDodGrupe.Text = "Dodaj nową grupę";
            this.cbDodGrupe.UseVisualStyleBackColor = true;
            this.cbDodGrupe.Click += new System.EventHandler(this.cbDodGrupe_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(357, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(26, 20);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 140);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Organizuj serwery i bazy";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbShell
            // 
            this.gbShell.Controls.Add(this.btnShellDel);
            this.gbShell.Controls.Add(this.btnShellAdd);
            this.gbShell.Location = new System.Drawing.Point(192, 121);
            this.gbShell.Name = "gbShell";
            this.gbShell.Size = new System.Drawing.Size(196, 53);
            this.gbShell.TabIndex = 7;
            this.gbShell.TabStop = false;
            this.gbShell.Text = "Shell";
            // 
            // btnShellAdd
            // 
            this.btnShellAdd.Location = new System.Drawing.Point(20, 19);
            this.btnShellAdd.Name = "btnShellAdd";
            this.btnShellAdd.Size = new System.Drawing.Size(75, 23);
            this.btnShellAdd.TabIndex = 0;
            this.btnShellAdd.Text = "Dodaj";
            this.btnShellAdd.UseVisualStyleBackColor = true;
            this.btnShellAdd.Click += new System.EventHandler(this.btnShellAdd_Click);
            // 
            // btnShellDel
            // 
            this.btnShellDel.Location = new System.Drawing.Point(101, 19);
            this.btnShellDel.Name = "btnShellDel";
            this.btnShellDel.Size = new System.Drawing.Size(75, 23);
            this.btnShellDel.TabIndex = 1;
            this.btnShellDel.Text = "Usun";
            this.btnShellDel.UseVisualStyleBackColor = true;
            this.btnShellDel.Click += new System.EventHandler(this.btnShellDel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 319);
            this.Controls.Add(this.gbShell);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbOpen);
            this.Name = "MainForm";
            this.Text = "DBIni";
            this.gbOpen.ResumeLayout(false);
            this.gbOpen.PerformLayout();
            this.gbShell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox edtOpen;
        private System.Windows.Forms.GroupBox gbOpen;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox cbDodGrupe;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox edtGroupName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbShell;
        private System.Windows.Forms.Button btnShellDel;
        private System.Windows.Forms.Button btnShellAdd;
    }
}

