
namespace IOOP
{
    partial class frm4aAdmnHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4aAdmnHP));
            this.lblAdmnForm = new System.Windows.Forms.Label();
            this.btnAdmnBack = new System.Windows.Forms.Button();
            this.pcbAdmnPage = new System.Windows.Forms.PictureBox();
            this.btnAdmnViewTotalInc = new System.Windows.Forms.Button();
            this.btnAdmnRgsterTchRcp = new System.Windows.Forms.Button();
            this.btnAdmnUP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmnPage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmnForm
            // 
            this.lblAdmnForm.AutoSize = true;
            this.lblAdmnForm.Font = new System.Drawing.Font("Rockwell", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmnForm.Location = new System.Drawing.Point(32, 24);
            this.lblAdmnForm.Name = "lblAdmnForm";
            this.lblAdmnForm.Size = new System.Drawing.Size(395, 73);
            this.lblAdmnForm.TabIndex = 0;
            this.lblAdmnForm.Text = "Admin Page";
            // 
            // btnAdmnBack
            // 
            this.btnAdmnBack.Location = new System.Drawing.Point(12, 541);
            this.btnAdmnBack.Name = "btnAdmnBack";
            this.btnAdmnBack.Size = new System.Drawing.Size(134, 48);
            this.btnAdmnBack.TabIndex = 4;
            this.btnAdmnBack.Text = "BACK";
            this.btnAdmnBack.UseVisualStyleBackColor = true;
            this.btnAdmnBack.Click += new System.EventHandler(this.btnAdmnBack_Click);
            // 
            // pcbAdmnPage
            // 
            this.pcbAdmnPage.Image = ((System.Drawing.Image)(resources.GetObject("pcbAdmnPage.Image")));
            this.pcbAdmnPage.Location = new System.Drawing.Point(771, 18);
            this.pcbAdmnPage.Name = "pcbAdmnPage";
            this.pcbAdmnPage.Size = new System.Drawing.Size(221, 214);
            this.pcbAdmnPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAdmnPage.TabIndex = 2;
            this.pcbAdmnPage.TabStop = false;
            // 
            // btnAdmnViewTotalInc
            // 
            this.btnAdmnViewTotalInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmnViewTotalInc.Location = new System.Drawing.Point(339, 293);
            this.btnAdmnViewTotalInc.Name = "btnAdmnViewTotalInc";
            this.btnAdmnViewTotalInc.Size = new System.Drawing.Size(303, 72);
            this.btnAdmnViewTotalInc.TabIndex = 6;
            this.btnAdmnViewTotalInc.Text = "View Monthly Total Income and Services";
            this.btnAdmnViewTotalInc.UseVisualStyleBackColor = true;
            this.btnAdmnViewTotalInc.Click += new System.EventHandler(this.btnAdmnViewTotalInc_Click);
            // 
            // btnAdmnRgsterTchRcp
            // 
            this.btnAdmnRgsterTchRcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmnRgsterTchRcp.Location = new System.Drawing.Point(339, 160);
            this.btnAdmnRgsterTchRcp.Name = "btnAdmnRgsterTchRcp";
            this.btnAdmnRgsterTchRcp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdmnRgsterTchRcp.Size = new System.Drawing.Size(303, 72);
            this.btnAdmnRgsterTchRcp.TabIndex = 5;
            this.btnAdmnRgsterTchRcp.Text = "Register (Technician and Receptionist)";
            this.btnAdmnRgsterTchRcp.UseVisualStyleBackColor = true;
            this.btnAdmnRgsterTchRcp.Click += new System.EventHandler(this.btnAdmnRgsterTchRcp_Click);
            // 
            // btnAdmnUP
            // 
            this.btnAdmnUP.Location = new System.Drawing.Point(339, 411);
            this.btnAdmnUP.Name = "btnAdmnUP";
            this.btnAdmnUP.Size = new System.Drawing.Size(303, 70);
            this.btnAdmnUP.TabIndex = 7;
            this.btnAdmnUP.Text = "Update Profile";
            this.btnAdmnUP.UseVisualStyleBackColor = true;
            this.btnAdmnUP.Click += new System.EventHandler(this.btnAdmnUP_Click);
            // 
            // frm4aAdmnHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 601);
            this.Controls.Add(this.btnAdmnUP);
            this.Controls.Add(this.btnAdmnViewTotalInc);
            this.Controls.Add(this.btnAdmnRgsterTchRcp);
            this.Controls.Add(this.btnAdmnBack);
            this.Controls.Add(this.pcbAdmnPage);
            this.Controls.Add(this.lblAdmnForm);
            this.Name = "frm4aAdmnHP";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.frm4aAdmnHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmnPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmnForm;
        private System.Windows.Forms.PictureBox pcbAdmnPage;
        private System.Windows.Forms.Button btnAdmnBack;
        private System.Windows.Forms.Button btnAdmnViewTotalInc;
        private System.Windows.Forms.Button btnAdmnRgsterTchRcp;
        private System.Windows.Forms.Button btnAdmnUP;
    }
}