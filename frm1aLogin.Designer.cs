
namespace IOOP
{
    partial class frm1aLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.cbxLoginRole = new System.Windows.Forms.ComboBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginRole = new System.Windows.Forms.Label();
            this.lblLoginForm = new System.Windows.Forms.Label();
            this.tmrTimeOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(263, 257);
            this.btnLoginLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(235, 50);
            this.btnLoginLogin.TabIndex = 34;
            this.btnLoginLogin.Text = "LOGIN";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(263, 197);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(235, 22);
            this.txtLoginPassword.TabIndex = 33;
            this.txtLoginPassword.Text = "Please Enter Your Password";
            this.txtLoginPassword.Click += new System.EventHandler(this.txtLoginPassword_Click);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(263, 171);
            this.txtLoginUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(235, 22);
            this.txtLoginUsername.TabIndex = 32;
            this.txtLoginUsername.Text = "Please Enter Your Name";
            this.txtLoginUsername.Click += new System.EventHandler(this.txtLoginUsername_Click);
            // 
            // cbxLoginRole
            // 
            this.cbxLoginRole.FormattingEnabled = true;
            this.cbxLoginRole.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Receptionist",
            "Technician"});
            this.cbxLoginRole.Location = new System.Drawing.Point(263, 144);
            this.cbxLoginRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLoginRole.Name = "cbxLoginRole";
            this.cbxLoginRole.Size = new System.Drawing.Size(235, 24);
            this.cbxLoginRole.TabIndex = 31;
            this.cbxLoginRole.Text = "Please Select Your Role";
            this.cbxLoginRole.Click += new System.EventHandler(this.cbxLoginRole_Click);
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(160, 202);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(88, 17);
            this.lblLoginPassword.TabIndex = 30;
            this.lblLoginPassword.Text = "PASSWORD";
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(160, 176);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(85, 17);
            this.lblLoginUsername.TabIndex = 29;
            this.lblLoginUsername.Text = "USERNAME";
            // 
            // lblLoginRole
            // 
            this.lblLoginRole.AutoSize = true;
            this.lblLoginRole.Location = new System.Drawing.Point(160, 150);
            this.lblLoginRole.Name = "lblLoginRole";
            this.lblLoginRole.Size = new System.Drawing.Size(46, 17);
            this.lblLoginRole.TabIndex = 28;
            this.lblLoginRole.Text = "ROLE";
            // 
            // lblLoginForm
            // 
            this.lblLoginForm.AutoSize = true;
            this.lblLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginForm.Location = new System.Drawing.Point(11, 7);
            this.lblLoginForm.Name = "lblLoginForm";
            this.lblLoginForm.Size = new System.Drawing.Size(227, 39);
            this.lblLoginForm.TabIndex = 27;
            this.lblLoginForm.Text = "LOGIN PAGE";
            // 
            // tmrTimeOut
            // 
            this.tmrTimeOut.Interval = 1000;
            this.tmrTimeOut.Tick += new System.EventHandler(this.tmrTimeOut_Tick);
            // 
            // frm1aLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.cbxLoginRole);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.lblLoginRole);
            this.Controls.Add(this.lblLoginForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm1aLogin";
            this.Text = "frm1aLogin";
            this.Load += new System.EventHandler(this.frm1aLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.ComboBox cbxLoginRole;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginRole;
        private System.Windows.Forms.Label lblLoginForm;
        private System.Windows.Forms.Timer tmrTimeOut;
    }
}