namespace Mock_Syskey
{
    partial class StartupKey
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
            this.gbPS = new System.Windows.Forms.GroupBox();
            this.gbSGP = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbPS = new System.Windows.Forms.RadioButton();
            this.rbSGP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.rbSSKFD = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbPS.SuspendLayout();
            this.gbSGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPS
            // 
            this.gbPS.Controls.Add(this.txtPasswordConfirm);
            this.gbPS.Controls.Add(this.txtbPassword);
            this.gbPS.Controls.Add(this.label1);
            this.gbPS.Enabled = false;
            this.gbPS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPS.Location = new System.Drawing.Point(12, 12);
            this.gbPS.Name = "gbPS";
            this.gbPS.Size = new System.Drawing.Size(280, 121);
            this.gbPS.TabIndex = 0;
            this.gbPS.TabStop = false;
            this.gbPS.Text = "     Password Startup";
            // 
            // gbSGP
            // 
            this.gbSGP.Controls.Add(this.radioButton1);
            this.gbSGP.Controls.Add(this.rbSSKFD);
            this.gbSGP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbSGP.Location = new System.Drawing.Point(12, 139);
            this.gbSGP.Name = "gbSGP";
            this.gbSGP.Size = new System.Drawing.Size(280, 149);
            this.gbSGP.TabIndex = 1;
            this.gbSGP.TabStop = false;
            this.gbSGP.Text = "     System Generated Password";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(76, 294);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(154, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbPS
            // 
            this.rbPS.AutoSize = true;
            this.rbPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPS.Location = new System.Drawing.Point(20, 13);
            this.rbPS.Name = "rbPS";
            this.rbPS.Size = new System.Drawing.Size(13, 12);
            this.rbPS.TabIndex = 4;
            this.rbPS.TabStop = true;
            this.rbPS.UseVisualStyleBackColor = true;
            // 
            // rbSGP
            // 
            this.rbSGP.AutoSize = true;
            this.rbSGP.Checked = true;
            this.rbSGP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSGP.Location = new System.Drawing.Point(20, 140);
            this.rbSGP.Name = "rbSGP";
            this.rbSGP.Size = new System.Drawing.Size(13, 12);
            this.rbSGP.TabIndex = 5;
            this.rbSGP.TabStop = true;
            this.rbSGP.UseVisualStyleBackColor = true;
            this.rbSGP.CheckedChanged += new System.EventHandler(this.rbSGP_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requires a password to be entered during system\r\nstart.\r\n\r\nPassword:\r\n\r\nConfirm:\r" +
    "\n";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(99, 55);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(169, 20);
            this.txtbPassword.TabIndex = 1;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(99, 80);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(169, 20);
            this.txtPasswordConfirm.TabIndex = 2;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // rbSSKFD
            // 
            this.rbSSKFD.AutoSize = true;
            this.rbSSKFD.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbSSKFD.Location = new System.Drawing.Point(24, 23);
            this.rbSSKFD.Name = "rbSSKFD";
            this.rbSSKFD.Size = new System.Drawing.Size(228, 43);
            this.rbSSKFD.TabIndex = 0;
            this.rbSSKFD.Text = "Store Startup Key on Floppy Disk\r\nRequires a floppy disk to be inserted during\r\ns" +
    "ystem start.";
            this.rbSSKFD.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbSSKFD.UseMnemonic = false;
            this.rbSSKFD.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(234, 56);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Store Startup Key Locally\r\nStores a key as part of the operating system,\r\nand no " +
    "interaction is required during system\r\nstart.";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.UseMnemonic = false;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // StartupKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 322);
            this.Controls.Add(this.rbPS);
            this.Controls.Add(this.rbSGP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbSGP);
            this.Controls.Add(this.gbPS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupKey";
            this.ShowInTaskbar = false;
            this.Text = "Startup Key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartupKey_FormClosing);
            this.Load += new System.EventHandler(this.StartupKey_Load);
            this.gbPS.ResumeLayout(false);
            this.gbPS.PerformLayout();
            this.gbSGP.ResumeLayout(false);
            this.gbSGP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPS;
        private System.Windows.Forms.RadioButton rbPS;
        private System.Windows.Forms.GroupBox gbSGP;
        private System.Windows.Forms.RadioButton rbSGP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbSSKFD;
    }
}