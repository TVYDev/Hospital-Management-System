namespace Hospital_Management
{
    partial class frmUserSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserSetting));
            this.chkShowRetypePwd = new System.Windows.Forms.CheckBox();
            this.chkShowNewPwd = new System.Windows.Forms.CheckBox();
            this.chkShowCurrentPwd = new System.Windows.Forms.CheckBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRetypePwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtCurrentPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkShowRetypePwd
            // 
            this.chkShowRetypePwd.AutoSize = true;
            this.chkShowRetypePwd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowRetypePwd.Location = new System.Drawing.Point(466, 136);
            this.chkShowRetypePwd.Name = "chkShowRetypePwd";
            this.chkShowRetypePwd.Size = new System.Drawing.Size(65, 24);
            this.chkShowRetypePwd.TabIndex = 11;
            this.chkShowRetypePwd.Text = "Show";
            this.chkShowRetypePwd.UseVisualStyleBackColor = true;
            this.chkShowRetypePwd.Click += new System.EventHandler(this.chkShowRetypePwd_Click);
            // 
            // chkShowNewPwd
            // 
            this.chkShowNewPwd.AutoSize = true;
            this.chkShowNewPwd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowNewPwd.Location = new System.Drawing.Point(466, 95);
            this.chkShowNewPwd.Name = "chkShowNewPwd";
            this.chkShowNewPwd.Size = new System.Drawing.Size(65, 24);
            this.chkShowNewPwd.TabIndex = 10;
            this.chkShowNewPwd.Text = "Show";
            this.chkShowNewPwd.UseVisualStyleBackColor = true;
            this.chkShowNewPwd.Click += new System.EventHandler(this.chkShowNewPwd_Click);
            // 
            // chkShowCurrentPwd
            // 
            this.chkShowCurrentPwd.AutoSize = true;
            this.chkShowCurrentPwd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowCurrentPwd.Location = new System.Drawing.Point(466, 55);
            this.chkShowCurrentPwd.Name = "chkShowCurrentPwd";
            this.chkShowCurrentPwd.Size = new System.Drawing.Size(65, 24);
            this.chkShowCurrentPwd.TabIndex = 9;
            this.chkShowCurrentPwd.Text = "Show";
            this.chkShowCurrentPwd.UseVisualStyleBackColor = true;
            this.chkShowCurrentPwd.Click += new System.EventHandler(this.chkShowCurrentPwd_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(293, 185);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(98, 17);
            this.lblWarning.TabIndex = 8;
            this.lblWarning.Text = "Wrong password";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(351, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelTab2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(231, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveTab2_Click);
            // 
            // txtRetypePwd
            // 
            this.txtRetypePwd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePwd.Location = new System.Drawing.Point(231, 134);
            this.txtRetypePwd.Name = "txtRetypePwd";
            this.txtRetypePwd.Size = new System.Drawing.Size(216, 28);
            this.txtRetypePwd.TabIndex = 5;
            this.txtRetypePwd.UseSystemPasswordChar = true;
            this.txtRetypePwd.Enter += new System.EventHandler(this.txtRetypePwd_Enter);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwd.Location = new System.Drawing.Point(231, 93);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(216, 28);
            this.txtNewPwd.TabIndex = 4;
            this.txtNewPwd.UseSystemPasswordChar = true;
            this.txtNewPwd.Enter += new System.EventHandler(this.txtNewPwd_Enter);
            // 
            // txtCurrentPwd
            // 
            this.txtCurrentPwd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPwd.Location = new System.Drawing.Point(231, 53);
            this.txtCurrentPwd.Name = "txtCurrentPwd";
            this.txtCurrentPwd.Size = new System.Drawing.Size(216, 28);
            this.txtCurrentPwd.TabIndex = 3;
            this.txtCurrentPwd.UseSystemPasswordChar = true;
            this.txtCurrentPwd.Enter += new System.EventHandler(this.txtCurrentPwd_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Re-type new password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkShowRetypePwd);
            this.Controls.Add(this.chkShowNewPwd);
            this.Controls.Add(this.chkShowCurrentPwd);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCurrentPwd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtRetypePwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User account setting";
            this.Load += new System.EventHandler(this.frmUserSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRetypePwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtCurrentPwd;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.CheckBox chkShowRetypePwd;
        private System.Windows.Forms.CheckBox chkShowNewPwd;
        private System.Windows.Forms.CheckBox chkShowCurrentPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}