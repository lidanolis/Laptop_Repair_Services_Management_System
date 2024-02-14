
namespace IOOP
{
    partial class frm4bAdmnRgstr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4bAdmnRgstr));
            this.lblUsrnme = new System.Windows.Forms.Label();
            this.lblMble = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnRgstr = new System.Windows.Forms.Button();
            this.btnAdmnBack = new System.Windows.Forms.Button();
            this.lblPsswrd = new System.Windows.Forms.Label();
            this.lblAdmnForm = new System.Windows.Forms.Label();
            this.pcbAdmn = new System.Windows.Forms.PictureBox();
            this.cmbReg = new System.Windows.Forms.ComboBox();
            this.txtUsrnmebox = new System.Windows.Forms.TextBox();
            this.txtPsswrdbox = new System.Windows.Forms.TextBox();
            this.txtEmailbox = new System.Windows.Forms.TextBox();
            this.txtMblebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsrnme
            // 
            this.lblUsrnme.AutoSize = true;
            this.lblUsrnme.Location = new System.Drawing.Point(51, 123);
            this.lblUsrnme.Name = "lblUsrnme";
            this.lblUsrnme.Size = new System.Drawing.Size(108, 25);
            this.lblUsrnme.TabIndex = 0;
            this.lblUsrnme.Text = "Username:";
            // 
            // lblMble
            // 
            this.lblMble.AutoSize = true;
            this.lblMble.Location = new System.Drawing.Point(51, 287);
            this.lblMble.Name = "lblMble";
            this.lblMble.Size = new System.Drawing.Size(139, 25);
            this.lblMble.TabIndex = 7;
            this.lblMble.Text = "Mobile/Phone:";
            this.lblMble.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(60, 348);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 25);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // btnRgstr
            // 
            this.btnRgstr.Location = new System.Drawing.Point(711, 474);
            this.btnRgstr.Name = "btnRgstr";
            this.btnRgstr.Size = new System.Drawing.Size(141, 54);
            this.btnRgstr.TabIndex = 14;
            this.btnRgstr.Text = "REGISTER";
            this.btnRgstr.UseVisualStyleBackColor = true;
            this.btnRgstr.Click += new System.EventHandler(this.btnRgstr_Click);
            // 
            // btnAdmnBack
            // 
            this.btnAdmnBack.Location = new System.Drawing.Point(559, 475);
            this.btnAdmnBack.Name = "btnAdmnBack";
            this.btnAdmnBack.Size = new System.Drawing.Size(125, 53);
            this.btnAdmnBack.TabIndex = 15;
            this.btnAdmnBack.Text = "BACK";
            this.btnAdmnBack.UseVisualStyleBackColor = true;
            this.btnAdmnBack.Click += new System.EventHandler(this.btnAdmnBack_Click);
            // 
            // lblPsswrd
            // 
            this.lblPsswrd.AutoSize = true;
            this.lblPsswrd.Location = new System.Drawing.Point(51, 171);
            this.lblPsswrd.Name = "lblPsswrd";
            this.lblPsswrd.Size = new System.Drawing.Size(104, 25);
            this.lblPsswrd.TabIndex = 17;
            this.lblPsswrd.Text = "Password:";
            this.lblPsswrd.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblAdmnForm
            // 
            this.lblAdmnForm.AutoSize = true;
            this.lblAdmnForm.Font = new System.Drawing.Font("Rockwell", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmnForm.Location = new System.Drawing.Point(12, 9);
            this.lblAdmnForm.Name = "lblAdmnForm";
            this.lblAdmnForm.Size = new System.Drawing.Size(282, 73);
            this.lblAdmnForm.TabIndex = 19;
            this.lblAdmnForm.Text = "Register";
            // 
            // pcbAdmn
            // 
            this.pcbAdmn.Image = ((System.Drawing.Image)(resources.GetObject("pcbAdmn.Image")));
            this.pcbAdmn.Location = new System.Drawing.Point(637, 0);
            this.pcbAdmn.Name = "pcbAdmn";
            this.pcbAdmn.Size = new System.Drawing.Size(229, 212);
            this.pcbAdmn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAdmn.TabIndex = 16;
            this.pcbAdmn.TabStop = false;
            // 
            // cmbReg
            // 
            this.cmbReg.FormattingEnabled = true;
            this.cmbReg.Items.AddRange(new object[] {
            "technician",
            "receptionist"});
            this.cmbReg.Location = new System.Drawing.Point(196, 348);
            this.cmbReg.Name = "cmbReg";
            this.cmbReg.Size = new System.Drawing.Size(142, 32);
            this.cmbReg.TabIndex = 20;
            this.cmbReg.SelectedIndexChanged += new System.EventHandler(this.cmbReg_SelectedIndexChanged);
            // 
            // txtUsrnmebox
            // 
            this.txtUsrnmebox.Location = new System.Drawing.Point(196, 123);
            this.txtUsrnmebox.Name = "txtUsrnmebox";
            this.txtUsrnmebox.Size = new System.Drawing.Size(261, 29);
            this.txtUsrnmebox.TabIndex = 5;
            this.txtUsrnmebox.TextChanged += new System.EventHandler(this.txtUsrnmebox_TextChanged);
            // 
            // txtPsswrdbox
            // 
            this.txtPsswrdbox.Location = new System.Drawing.Point(196, 171);
            this.txtPsswrdbox.Name = "txtPsswrdbox";
            this.txtPsswrdbox.Size = new System.Drawing.Size(261, 29);
            this.txtPsswrdbox.TabIndex = 18;
            this.txtPsswrdbox.TextChanged += new System.EventHandler(this.txtPsswrdbox_TextChanged);
            // 
            // txtEmailbox
            // 
            this.txtEmailbox.Location = new System.Drawing.Point(196, 232);
            this.txtEmailbox.Name = "txtEmailbox";
            this.txtEmailbox.Size = new System.Drawing.Size(261, 29);
            this.txtEmailbox.TabIndex = 12;
            this.txtEmailbox.TextChanged += new System.EventHandler(this.txtEmailbox_TextChanged);
            // 
            // txtMblebox
            // 
            this.txtMblebox.Location = new System.Drawing.Point(196, 287);
            this.txtMblebox.Name = "txtMblebox";
            this.txtMblebox.Size = new System.Drawing.Size(261, 29);
            this.txtMblebox.TabIndex = 6;
            this.txtMblebox.TextChanged += new System.EventHandler(this.txtMblebox_TextChanged);
            // 
            // frm4bAdmnRgstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 549);
            this.Controls.Add(this.cmbReg);
            this.Controls.Add(this.lblAdmnForm);
            this.Controls.Add(this.txtPsswrdbox);
            this.Controls.Add(this.lblPsswrd);
            this.Controls.Add(this.pcbAdmn);
            this.Controls.Add(this.btnAdmnBack);
            this.Controls.Add(this.btnRgstr);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmailbox);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblMble);
            this.Controls.Add(this.txtMblebox);
            this.Controls.Add(this.txtUsrnmebox);
            this.Controls.Add(this.lblUsrnme);
            this.Name = "frm4bAdmnRgstr";
            this.Text = "AdminRegister";
            this.Load += new System.EventHandler(this.frm4bAdmnRgstr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsrnme;
        private System.Windows.Forms.Label lblMble;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnRgstr;
        private System.Windows.Forms.Button btnAdmnBack;
        private System.Windows.Forms.PictureBox pcbAdmn;
        private System.Windows.Forms.Label lblPsswrd;
        private System.Windows.Forms.Label lblAdmnForm;
        private System.Windows.Forms.ComboBox cmbReg;
        private System.Windows.Forms.TextBox txtUsrnmebox;
        private System.Windows.Forms.TextBox txtPsswrdbox;
        private System.Windows.Forms.TextBox txtEmailbox;
        private System.Windows.Forms.TextBox txtMblebox;
    }
}