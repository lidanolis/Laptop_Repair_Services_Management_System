
namespace IOOP
{
    partial class frm1dRcpServ
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
            this.lblCustomerWelcome = new System.Windows.Forms.Label();
            this.btnCustomerConfirm = new System.Windows.Forms.Button();
            this.btnCustomerCalculate = new System.Windows.Forms.Button();
            this.cbxCustomerUsername = new System.Windows.Forms.ComboBox();
            this.lblCustomerDate = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceptionForm = new System.Windows.Forms.Label();
            this.txtCustomerFee = new System.Windows.Forms.TextBox();
            this.lblCustomerFee = new System.Windows.Forms.Label();
            this.lblCustomerUsername = new System.Windows.Forms.Label();
            this.gbxCustomerService = new System.Windows.Forms.GroupBox();
            this.rbxCustomerNormal = new System.Windows.Forms.RadioButton();
            this.rbxCustomerUrgent = new System.Windows.Forms.RadioButton();
            this.cbxCustomerService = new System.Windows.Forms.ComboBox();
            this.lblCustomerService = new System.Windows.Forms.Label();
            this.gbxCustomerService.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerWelcome
            // 
            this.lblCustomerWelcome.AutoSize = true;
            this.lblCustomerWelcome.Location = new System.Drawing.Point(119, 108);
            this.lblCustomerWelcome.Name = "lblCustomerWelcome";
            this.lblCustomerWelcome.Size = new System.Drawing.Size(29, 20);
            this.lblCustomerWelcome.TabIndex = 91;
            this.lblCustomerWelcome.Text = "----";
            // 
            // btnCustomerConfirm
            // 
            this.btnCustomerConfirm.Location = new System.Drawing.Point(399, 342);
            this.btnCustomerConfirm.Name = "btnCustomerConfirm";
            this.btnCustomerConfirm.Size = new System.Drawing.Size(272, 49);
            this.btnCustomerConfirm.TabIndex = 90;
            this.btnCustomerConfirm.Text = "CONFIRM";
            this.btnCustomerConfirm.UseVisualStyleBackColor = true;
            this.btnCustomerConfirm.Visible = false;
            this.btnCustomerConfirm.Click += new System.EventHandler(this.btnCustomerConfirm_Click);
            // 
            // btnCustomerCalculate
            // 
            this.btnCustomerCalculate.Location = new System.Drawing.Point(123, 342);
            this.btnCustomerCalculate.Name = "btnCustomerCalculate";
            this.btnCustomerCalculate.Size = new System.Drawing.Size(270, 49);
            this.btnCustomerCalculate.TabIndex = 89;
            this.btnCustomerCalculate.Text = "CHECK FEE";
            this.btnCustomerCalculate.UseVisualStyleBackColor = true;
            this.btnCustomerCalculate.Click += new System.EventHandler(this.btnCustomerCalculate_Click);
            // 
            // cbxCustomerUsername
            // 
            this.cbxCustomerUsername.FormattingEnabled = true;
            this.cbxCustomerUsername.Location = new System.Drawing.Point(271, 135);
            this.cbxCustomerUsername.Name = "cbxCustomerUsername";
            this.cbxCustomerUsername.Size = new System.Drawing.Size(400, 28);
            this.cbxCustomerUsername.TabIndex = 88;
            this.cbxCustomerUsername.Text = "Please Select......";
            this.cbxCustomerUsername.Click += new System.EventHandler(this.cbxCustomerUsername_Click);
            // 
            // lblCustomerDate
            // 
            this.lblCustomerDate.AutoSize = true;
            this.lblCustomerDate.Location = new System.Drawing.Point(119, 272);
            this.lblCustomerDate.Name = "lblCustomerDate";
            this.lblCustomerDate.Size = new System.Drawing.Size(146, 20);
            this.lblCustomerDate.TabIndex = 87;
            this.lblCustomerDate.Text = "DATE of SERVICE";
            this.lblCustomerDate.Visible = false;
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.CustomFormat = "yyyy-MM-dd";
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceDate.Location = new System.Drawing.Point(271, 267);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(400, 26);
            this.dtpServiceDate.TabIndex = 86;
            this.dtpServiceDate.Value = new System.DateTime(2021, 11, 6, 0, 0, 0, 0);
            // 
            // lblReceptionForm
            // 
            this.lblReceptionForm.AutoSize = true;
            this.lblReceptionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionForm.Location = new System.Drawing.Point(12, 9);
            this.lblReceptionForm.Name = "lblReceptionForm";
            this.lblReceptionForm.Size = new System.Drawing.Size(394, 58);
            this.lblReceptionForm.TabIndex = 85;
            this.lblReceptionForm.Text = "RECEPTIONIST";
            // 
            // txtCustomerFee
            // 
            this.txtCustomerFee.Location = new System.Drawing.Point(271, 299);
            this.txtCustomerFee.Name = "txtCustomerFee";
            this.txtCustomerFee.ReadOnly = true;
            this.txtCustomerFee.Size = new System.Drawing.Size(400, 26);
            this.txtCustomerFee.TabIndex = 84;
            // 
            // lblCustomerFee
            // 
            this.lblCustomerFee.AutoSize = true;
            this.lblCustomerFee.Location = new System.Drawing.Point(119, 302);
            this.lblCustomerFee.Name = "lblCustomerFee";
            this.lblCustomerFee.Size = new System.Drawing.Size(117, 20);
            this.lblCustomerFee.TabIndex = 83;
            this.lblCustomerFee.Text = "SERVICE FEE";
            // 
            // lblCustomerUsername
            // 
            this.lblCustomerUsername.AutoSize = true;
            this.lblCustomerUsername.Location = new System.Drawing.Point(119, 138);
            this.lblCustomerUsername.Name = "lblCustomerUsername";
            this.lblCustomerUsername.Size = new System.Drawing.Size(101, 20);
            this.lblCustomerUsername.TabIndex = 82;
            this.lblCustomerUsername.Text = "USERNAME";
            // 
            // gbxCustomerService
            // 
            this.gbxCustomerService.Controls.Add(this.rbxCustomerNormal);
            this.gbxCustomerService.Controls.Add(this.rbxCustomerUrgent);
            this.gbxCustomerService.Location = new System.Drawing.Point(123, 203);
            this.gbxCustomerService.Name = "gbxCustomerService";
            this.gbxCustomerService.Size = new System.Drawing.Size(548, 58);
            this.gbxCustomerService.TabIndex = 81;
            this.gbxCustomerService.TabStop = false;
            this.gbxCustomerService.Text = "Service Fee Type";
            // 
            // rbxCustomerNormal
            // 
            this.rbxCustomerNormal.AutoSize = true;
            this.rbxCustomerNormal.Location = new System.Drawing.Point(186, 25);
            this.rbxCustomerNormal.Name = "rbxCustomerNormal";
            this.rbxCustomerNormal.Size = new System.Drawing.Size(84, 24);
            this.rbxCustomerNormal.TabIndex = 19;
            this.rbxCustomerNormal.TabStop = true;
            this.rbxCustomerNormal.Text = "Normal";
            this.rbxCustomerNormal.UseVisualStyleBackColor = true;
            // 
            // rbxCustomerUrgent
            // 
            this.rbxCustomerUrgent.AutoSize = true;
            this.rbxCustomerUrgent.Location = new System.Drawing.Point(362, 25);
            this.rbxCustomerUrgent.Name = "rbxCustomerUrgent";
            this.rbxCustomerUrgent.Size = new System.Drawing.Size(83, 24);
            this.rbxCustomerUrgent.TabIndex = 20;
            this.rbxCustomerUrgent.TabStop = true;
            this.rbxCustomerUrgent.Text = "Urgent";
            this.rbxCustomerUrgent.UseVisualStyleBackColor = true;
            // 
            // cbxCustomerService
            // 
            this.cbxCustomerService.FormattingEnabled = true;
            this.cbxCustomerService.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow ",
            "Laptop screen replacement ",
            "Laptop keyboard replacement",
            "Laptop battery replacement ",
            "Operating System Format and Installation ",
            "Data backup and recovery ",
            "Internet connectivity issues "});
            this.cbxCustomerService.Location = new System.Drawing.Point(271, 169);
            this.cbxCustomerService.Name = "cbxCustomerService";
            this.cbxCustomerService.Size = new System.Drawing.Size(400, 28);
            this.cbxCustomerService.TabIndex = 80;
            this.cbxCustomerService.Text = "Please Select......";
            this.cbxCustomerService.Click += new System.EventHandler(this.cbxCustomerService_Click);
            // 
            // lblCustomerService
            // 
            this.lblCustomerService.AutoSize = true;
            this.lblCustomerService.Location = new System.Drawing.Point(119, 172);
            this.lblCustomerService.Name = "lblCustomerService";
            this.lblCustomerService.Size = new System.Drawing.Size(81, 20);
            this.lblCustomerService.TabIndex = 79;
            this.lblCustomerService.Text = "SERVICE";
            // 
            // frm1dRcpServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustomerWelcome);
            this.Controls.Add(this.btnCustomerConfirm);
            this.Controls.Add(this.btnCustomerCalculate);
            this.Controls.Add(this.cbxCustomerUsername);
            this.Controls.Add(this.lblCustomerDate);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.lblReceptionForm);
            this.Controls.Add(this.txtCustomerFee);
            this.Controls.Add(this.lblCustomerFee);
            this.Controls.Add(this.lblCustomerUsername);
            this.Controls.Add(this.gbxCustomerService);
            this.Controls.Add(this.cbxCustomerService);
            this.Controls.Add(this.lblCustomerService);
            this.Name = "frm1dRcpServ";
            this.Text = "frm1dRcpServ";
            this.Load += new System.EventHandler(this.frm1dRcpServ_Load);
            this.gbxCustomerService.ResumeLayout(false);
            this.gbxCustomerService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerWelcome;
        private System.Windows.Forms.Button btnCustomerConfirm;
        private System.Windows.Forms.Button btnCustomerCalculate;
        private System.Windows.Forms.ComboBox cbxCustomerUsername;
        private System.Windows.Forms.Label lblCustomerDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label lblReceptionForm;
        private System.Windows.Forms.TextBox txtCustomerFee;
        private System.Windows.Forms.Label lblCustomerFee;
        private System.Windows.Forms.Label lblCustomerUsername;
        private System.Windows.Forms.GroupBox gbxCustomerService;
        private System.Windows.Forms.RadioButton rbxCustomerNormal;
        private System.Windows.Forms.RadioButton rbxCustomerUrgent;
        private System.Windows.Forms.ComboBox cbxCustomerService;
        private System.Windows.Forms.Label lblCustomerService;
    }
}