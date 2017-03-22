namespace Ini2Flame
{
    partial class EditDBForm
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.tree = new System.Windows.Forms.TreeView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZwin = new System.Windows.Forms.Button();
            this.btnRozwin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowDrop = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(603, 95);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(541, 208);
            this.grid.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.AllowDrop = true;
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tree.Location = new System.Drawing.Point(12, 12);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(541, 480);
            this.tree.TabIndex = 1;
            this.tree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tree_ItemDrag);
            this.tree.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.tree.DragEnter += new System.Windows.Forms.DragEventHandler(this.tree_DragEnter);
            this.tree.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.tree.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.tree_GiveFeedback);
            this.tree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tree_MouseClick);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(177, 526);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Zatwierdź";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(268, 526);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 3;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(603, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 37);
            this.panel1.TabIndex = 4;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.panel1_GiveFeedback);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(774, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 37);
            this.panel2.TabIndex = 5;
            this.panel2.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.panel2_GiveFeedback);
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsun.Location = new System.Drawing.Point(223, 498);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 6;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnZwin
            // 
            this.btnZwin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZwin.Location = new System.Drawing.Point(416, 498);
            this.btnZwin.Name = "btnZwin";
            this.btnZwin.Size = new System.Drawing.Size(99, 23);
            this.btnZwin.TabIndex = 7;
            this.btnZwin.Text = "Zwiń wszystko";
            this.btnZwin.UseVisualStyleBackColor = true;
            this.btnZwin.Click += new System.EventHandler(this.btnZwin_Click);
            // 
            // btnRozwin
            // 
            this.btnRozwin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRozwin.Location = new System.Drawing.Point(416, 526);
            this.btnRozwin.Name = "btnRozwin";
            this.btnRozwin.Size = new System.Drawing.Size(99, 23);
            this.btnRozwin.TabIndex = 8;
            this.btnRozwin.Text = "Rozwiń wszystko";
            this.btnRozwin.UseVisualStyleBackColor = true;
            this.btnRozwin.Click += new System.EventHandler(this.btnRozwin_Click);
            // 
            // EditDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 559);
            this.Controls.Add(this.btnRozwin);
            this.Controls.Add(this.btnZwin);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.grid);
            this.Name = "EditDBForm";
            this.Text = "Zarządzaj bazami";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnZwin;
        private System.Windows.Forms.Button btnRozwin;
    }
}