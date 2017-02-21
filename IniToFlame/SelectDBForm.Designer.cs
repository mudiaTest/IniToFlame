namespace Ini2Flame
{
    partial class ChooseForm
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
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnChNone = new System.Windows.Forms.Button();
            this.btnChAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 1;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanel.Size = new System.Drawing.Size(417, 139);
            this.tlPanel.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnChNone);
            this.pnlButtons.Controls.Add(this.btnChAll);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Controls.Add(this.cbAll);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 139);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(417, 71);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnChNone
            // 
            this.btnChNone.Location = new System.Drawing.Point(213, 3);
            this.btnChNone.Name = "btnChNone";
            this.btnChNone.Size = new System.Drawing.Size(115, 23);
            this.btnChNone.TabIndex = 4;
            this.btnChNone.Text = "Odznacz wszystkie";
            this.btnChNone.UseVisualStyleBackColor = true;
            this.btnChNone.Click += new System.EventHandler(this.btnChNone_Click);
            // 
            // btnChAll
            // 
            this.btnChAll.Location = new System.Drawing.Point(93, 3);
            this.btnChAll.Name = "btnChAll";
            this.btnChAll.Size = new System.Drawing.Size(114, 23);
            this.btnChAll.TabIndex = 3;
            this.btnChAll.Text = "Zaznacz wszystkie";
            this.btnChAll.UseVisualStyleBackColor = true;
            this.btnChAll.Click += new System.EventHandler(this.btnChAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(213, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(132, 36);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Zatwierdź";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(6, 6);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(74, 17);
            this.cbAll.TabIndex = 0;
            this.cbAll.Text = "Wszystkie";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 210);
            this.Controls.Add(this.tlPanel);
            this.Controls.Add(this.pnlButtons);
            this.Name = "ChooseForm";
            this.Text = "Wybierz bazy";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnChNone;
        private System.Windows.Forms.Button btnChAll;
    }
}