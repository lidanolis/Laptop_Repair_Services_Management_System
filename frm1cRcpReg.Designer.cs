
namespace IOOP
{
    partial class frm1cRcpReg
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
            this.btnRegisterCreate = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegisterWelcome = new System.Windows.Forms.Label();
            this.lblReceptionForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterCreate
            // 
            this.btnRegisterCreate.Location = new System.Drawing.Point(283, 322);
            this.btnRegisterCreate.Name = "btnRegisterCreate";
            this.btnRegisterCreate.Size = new System.Drawing.Size(264, 62);
            this.btnRegisterCreate.TabIndex = 42;
            this.btnRegisterCreate.Text = "CREATE";
            this.btnRegisterCreate.UseVisualStyleBackColor = true;
            this.btnRegisterCreate.Click += new System.EventHandler(this.btnRegisterCreate_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(283, 247);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(264, 26);
            this.txtRegisterPassword.TabIndex = 41;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(283, 215);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(264, 26);
            this.txtRegisterUsername.TabIndex = 40;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(167, 253);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(103, 20);
            this.lblRegisterPassword.TabIndex = 39;
            this.lblRegisterPassword.Text = "PASSWORD";
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Location = new System.Drawing.Point(167, 221);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(101, 20);
            this.lblRegisterUsername.TabIndex = 38;
            this.lblRegisterUsername.Text = "USERNAME";
            // 
            // lblRegisterWelcome
            // 
            this.lblRegisterWelcome.AutoSize = true;
            this.lblRegisterWelcome.Location = new System.Drawing.Point(167, 189);
            this.lblRegisterWelcome.Name = "lblRegisterWelcome";
            this.lblRegisterWelcome.Size = new System.Drawing.Size(29, 20);
            this.lblRegisterWelcome.TabIndex = 37;
            this.lblRegisterWelcome.Text = "----";
            // 
            // lblReceptionForm
            // 
            this.lblReceptionForm.AutoSize = true;
            this.lblReceptionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionForm.Location = new System.Drawing.Point(12, 9);
            this.lblReceptionForm.Name = "lblReceptionForm";
            this.lblReceptionForm.Size = new System.Drawing.Size(253, 46);
            this.lblReceptionForm.TabIndex = 36;
            this.lblReceptionForm.Text = "RECEPTION";
            // 
            // frm1cRcpReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterCreate);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterUsername);
            this.Controls.Add(this.lblRegisterWelcome);
            this.Controls.Add(this.lblReceptionForm);
            this.Name = "frm1cRcpReg";
            this.Text = "frm1cRcpReg";
            this.Load += new System.EventHandler(this.frm1cRcpReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterCreate;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblRegisterWelcome;
        private System.Windows.Forms.Label lblReceptionForm;
    }
}