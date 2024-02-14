
namespace IOOP
{
    partial class frm1bRcpHP
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
            this.lblReceptionWelcome = new System.Windows.Forms.Label();
            this.btnReceptionConfirm = new System.Windows.Forms.Button();
            this.cbxReceptionAction = new System.Windows.Forms.ComboBox();
            this.lblReceptionAction = new System.Windows.Forms.Label();
            this.lblReceptionForm = new System.Windows.Forms.Label();
            this.btnReceptionProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceptionWelcome
            // 
            this.lblReceptionWelcome.AutoSize = true;
            this.lblReceptionWelcome.Location = new System.Drawing.Point(209, 188);
            this.lblReceptionWelcome.Name = "lblReceptionWelcome";
            this.lblReceptionWelcome.Size = new System.Drawing.Size(34, 20);
            this.lblReceptionWelcome.TabIndex = 42;
            this.lblReceptionWelcome.Text = "-----";
            // 
            // btnReceptionConfirm
            // 
            this.btnReceptionConfirm.Location = new System.Drawing.Point(269, 321);
            this.btnReceptionConfirm.Name = "btnReceptionConfirm";
            this.btnReceptionConfirm.Size = new System.Drawing.Size(264, 62);
            this.btnReceptionConfirm.TabIndex = 41;
            this.btnReceptionConfirm.Text = "CONFIRM";
            this.btnReceptionConfirm.UseVisualStyleBackColor = true;
            this.btnReceptionConfirm.Click += new System.EventHandler(this.btnReceptionConfirm_Click);
            // 
            // cbxReceptionAction
            // 
            this.cbxReceptionAction.FormattingEnabled = true;
            this.cbxReceptionAction.Items.AddRange(new object[] {
            "Register New Customer",
            "Customer Selection",
            "Customer Service Payment"});
            this.cbxReceptionAction.Location = new System.Drawing.Point(269, 222);
            this.cbxReceptionAction.Name = "cbxReceptionAction";
            this.cbxReceptionAction.Size = new System.Drawing.Size(264, 28);
            this.cbxReceptionAction.TabIndex = 40;
            this.cbxReceptionAction.Text = "Please Pick Your Action";
            this.cbxReceptionAction.Click += new System.EventHandler(this.cbxReceptionAction_Click);
            // 
            // lblReceptionAction
            // 
            this.lblReceptionAction.AutoSize = true;
            this.lblReceptionAction.Location = new System.Drawing.Point(209, 225);
            this.lblReceptionAction.Name = "lblReceptionAction";
            this.lblReceptionAction.Size = new System.Drawing.Size(54, 20);
            this.lblReceptionAction.TabIndex = 39;
            this.lblReceptionAction.Text = "Action";
            // 
            // lblReceptionForm
            // 
            this.lblReceptionForm.AutoSize = true;
            this.lblReceptionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionForm.Location = new System.Drawing.Point(12, 9);
            this.lblReceptionForm.Name = "lblReceptionForm";
            this.lblReceptionForm.Size = new System.Drawing.Size(253, 46);
            this.lblReceptionForm.TabIndex = 38;
            this.lblReceptionForm.Text = "RECEPTION\r\n";
            // 
            // btnReceptionProfile
            // 
            this.btnReceptionProfile.Location = new System.Drawing.Point(645, 12);
            this.btnReceptionProfile.Name = "btnReceptionProfile";
            this.btnReceptionProfile.Size = new System.Drawing.Size(143, 43);
            this.btnReceptionProfile.TabIndex = 43;
            this.btnReceptionProfile.Text = "PROFILE";
            this.btnReceptionProfile.UseVisualStyleBackColor = true;
            this.btnReceptionProfile.Click += new System.EventHandler(this.btnReceptionProfile_Click);
            // 
            // frm1bRcpHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReceptionProfile);
            this.Controls.Add(this.lblReceptionWelcome);
            this.Controls.Add(this.btnReceptionConfirm);
            this.Controls.Add(this.cbxReceptionAction);
            this.Controls.Add(this.lblReceptionAction);
            this.Controls.Add(this.lblReceptionForm);
            this.Name = "frm1bRcpHP";
            this.Text = "frm1bRcpHP";
            this.Load += new System.EventHandler(this.frm1bRcpHP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceptionWelcome;
        private System.Windows.Forms.Button btnReceptionConfirm;
        private System.Windows.Forms.ComboBox cbxReceptionAction;
        private System.Windows.Forms.Label lblReceptionAction;
        private System.Windows.Forms.Label lblReceptionForm;
        private System.Windows.Forms.Button btnReceptionProfile;
    }
}