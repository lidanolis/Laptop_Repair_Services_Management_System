
namespace IOOP
{
    partial class frm3aCusHP
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCusProfile = new System.Windows.Forms.Button();
            this.btnLogCus = new System.Windows.Forms.Button();
            this.lblCus1 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblCus2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(67, 174);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(189, 53);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change Service";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCusProfile
            // 
            this.btnCusProfile.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusProfile.Location = new System.Drawing.Point(67, 255);
            this.btnCusProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCusProfile.Name = "btnCusProfile";
            this.btnCusProfile.Size = new System.Drawing.Size(189, 52);
            this.btnCusProfile.TabIndex = 1;
            this.btnCusProfile.Text = "Profile";
            this.btnCusProfile.UseVisualStyleBackColor = true;
            this.btnCusProfile.Click += new System.EventHandler(this.btnCusProfile_Click);
            // 
            // btnLogCus
            // 
            this.btnLogCus.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogCus.ForeColor = System.Drawing.Color.Red;
            this.btnLogCus.Location = new System.Drawing.Point(276, 255);
            this.btnLogCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogCus.Name = "btnLogCus";
            this.btnLogCus.Size = new System.Drawing.Size(184, 52);
            this.btnLogCus.TabIndex = 2;
            this.btnLogCus.Text = "Log Out";
            this.btnLogCus.UseVisualStyleBackColor = true;
            this.btnLogCus.Click += new System.EventHandler(this.btnLogCus_Click);
            // 
            // lblCus1
            // 
            this.lblCus1.AutoSize = true;
            this.lblCus1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCus1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCus1.Location = new System.Drawing.Point(100, 42);
            this.lblCus1.Name = "lblCus1";
            this.lblCus1.Size = new System.Drawing.Size(339, 37);
            this.lblCus1.TabIndex = 3;
            this.lblCus1.Text = "Customer Home Page";
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(276, 174);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(184, 52);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblCus2
            // 
            this.lblCus2.AutoSize = true;
            this.lblCus2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCus2.Location = new System.Drawing.Point(175, 108);
            this.lblCus2.Name = "lblCus2";
            this.lblCus2.Size = new System.Drawing.Size(0, 25);
            this.lblCus2.TabIndex = 6;
            // 
            // frm3aCusHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 409);
            this.Controls.Add(this.lblCus2);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lblCus1);
            this.Controls.Add(this.btnLogCus);
            this.Controls.Add(this.btnCusProfile);
            this.Controls.Add(this.btnChange);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm3aCusHP";
            this.Text = "Customer home page";
            this.Load += new System.EventHandler(this.frm3aCusHP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCusProfile;
        private System.Windows.Forms.Button btnLogCus;
        private System.Windows.Forms.Label lblCus1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblCus2;
    }
}