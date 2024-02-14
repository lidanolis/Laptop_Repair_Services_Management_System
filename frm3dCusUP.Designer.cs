
namespace IOOP
{
    partial class frm3dCusUP
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.btnCusUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(170, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(98, 31);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Profile";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(67, 192);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(98, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Contact :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(67, 118);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(95, 25);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Email    :";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(176, 195);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(179, 22);
            this.txtCusPhone.TabIndex = 5;
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(176, 121);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(179, 22);
            this.txtCusEmail.TabIndex = 6;
            // 
            // btnCusUP
            // 
            this.btnCusUP.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusUP.ForeColor = System.Drawing.Color.Red;
            this.btnCusUP.Location = new System.Drawing.Point(152, 275);
            this.btnCusUP.Name = "btnCusUP";
            this.btnCusUP.Size = new System.Drawing.Size(137, 50);
            this.btnCusUP.TabIndex = 7;
            this.btnCusUP.Text = "Update";
            this.btnCusUP.UseVisualStyleBackColor = true;
            this.btnCusUP.Click += new System.EventHandler(this.btnCusUP_Click);
            // 
            // frm3dCusUP
            // 
            this.ClientSize = new System.Drawing.Size(444, 390);
            this.Controls.Add(this.btnCusUP);
            this.Controls.Add(this.txtCusEmail);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Name = "frm3dCusUP";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm3dCusUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCus8;
        private System.Windows.Forms.Label lblCus9;
        private System.Windows.Forms.Label lblCus10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCus7;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.Button btnCusUP;
    }
}