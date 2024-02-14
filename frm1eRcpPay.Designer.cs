
namespace IOOP
{
    partial class frm1eRcpPay
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
            this.lblPaymentWelcome = new System.Windows.Forms.Label();
            this.cbxPaymentUsername = new System.Windows.Forms.ComboBox();
            this.lblReceptionForm = new System.Windows.Forms.Label();
            this.txtPaymentChange = new System.Windows.Forms.TextBox();
            this.lblPaymentChange = new System.Windows.Forms.Label();
            this.btnPaymentReceipt = new System.Windows.Forms.Button();
            this.btnPaymentCalculate = new System.Windows.Forms.Button();
            this.btnPaymentConfirm = new System.Windows.Forms.Button();
            this.txtPaymentServiceFee = new System.Windows.Forms.TextBox();
            this.lblPaymentServiceFee = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPaymentUsername = new System.Windows.Forms.Label();
            this.cbxPaymentService = new System.Windows.Forms.ComboBox();
            this.lblPaymentService = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaymentWelcome
            // 
            this.lblPaymentWelcome.AutoSize = true;
            this.lblPaymentWelcome.Location = new System.Drawing.Point(75, 121);
            this.lblPaymentWelcome.Name = "lblPaymentWelcome";
            this.lblPaymentWelcome.Size = new System.Drawing.Size(29, 20);
            this.lblPaymentWelcome.TabIndex = 110;
            this.lblPaymentWelcome.Text = "----";
            // 
            // cbxPaymentUsername
            // 
            this.cbxPaymentUsername.FormattingEnabled = true;
            this.cbxPaymentUsername.Location = new System.Drawing.Point(205, 148);
            this.cbxPaymentUsername.Name = "cbxPaymentUsername";
            this.cbxPaymentUsername.Size = new System.Drawing.Size(530, 28);
            this.cbxPaymentUsername.TabIndex = 109;
            this.cbxPaymentUsername.Click += new System.EventHandler(this.cbxPaymentUsername_Click);
            // 
            // lblReceptionForm
            // 
            this.lblReceptionForm.AutoSize = true;
            this.lblReceptionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionForm.Location = new System.Drawing.Point(12, 9);
            this.lblReceptionForm.Name = "lblReceptionForm";
            this.lblReceptionForm.Size = new System.Drawing.Size(394, 58);
            this.lblReceptionForm.TabIndex = 108;
            this.lblReceptionForm.Text = "RECEPTIONIST";
            // 
            // txtPaymentChange
            // 
            this.txtPaymentChange.Location = new System.Drawing.Point(205, 313);
            this.txtPaymentChange.Name = "txtPaymentChange";
            this.txtPaymentChange.ReadOnly = true;
            this.txtPaymentChange.Size = new System.Drawing.Size(530, 26);
            this.txtPaymentChange.TabIndex = 107;
            this.txtPaymentChange.Text = "RM:";
            // 
            // lblPaymentChange
            // 
            this.lblPaymentChange.AutoSize = true;
            this.lblPaymentChange.Location = new System.Drawing.Point(75, 316);
            this.lblPaymentChange.Name = "lblPaymentChange";
            this.lblPaymentChange.Size = new System.Drawing.Size(65, 20);
            this.lblPaymentChange.TabIndex = 106;
            this.lblPaymentChange.Text = "Change";
            // 
            // btnPaymentReceipt
            // 
            this.btnPaymentReceipt.Location = new System.Drawing.Point(79, 357);
            this.btnPaymentReceipt.Name = "btnPaymentReceipt";
            this.btnPaymentReceipt.Size = new System.Drawing.Size(145, 49);
            this.btnPaymentReceipt.TabIndex = 105;
            this.btnPaymentReceipt.Text = "PRINT RECEIPT";
            this.btnPaymentReceipt.UseVisualStyleBackColor = true;
            this.btnPaymentReceipt.Visible = false;
            this.btnPaymentReceipt.Click += new System.EventHandler(this.btnPaymentReceipt_Click);
            // 
            // btnPaymentCalculate
            // 
            this.btnPaymentCalculate.Location = new System.Drawing.Point(230, 357);
            this.btnPaymentCalculate.Name = "btnPaymentCalculate";
            this.btnPaymentCalculate.Size = new System.Drawing.Size(169, 49);
            this.btnPaymentCalculate.TabIndex = 104;
            this.btnPaymentCalculate.Text = "CALCULATE";
            this.btnPaymentCalculate.UseVisualStyleBackColor = true;
            this.btnPaymentCalculate.Click += new System.EventHandler(this.btnPaymentCalculate_Click);
            // 
            // btnPaymentConfirm
            // 
            this.btnPaymentConfirm.Location = new System.Drawing.Point(405, 357);
            this.btnPaymentConfirm.Name = "btnPaymentConfirm";
            this.btnPaymentConfirm.Size = new System.Drawing.Size(330, 49);
            this.btnPaymentConfirm.TabIndex = 103;
            this.btnPaymentConfirm.Text = "CONFIRM";
            this.btnPaymentConfirm.UseVisualStyleBackColor = true;
            this.btnPaymentConfirm.Visible = false;
            this.btnPaymentConfirm.Click += new System.EventHandler(this.btnPaymentConfirm_Click);
            // 
            // txtPaymentServiceFee
            // 
            this.txtPaymentServiceFee.Location = new System.Drawing.Point(205, 216);
            this.txtPaymentServiceFee.Name = "txtPaymentServiceFee";
            this.txtPaymentServiceFee.ReadOnly = true;
            this.txtPaymentServiceFee.Size = new System.Drawing.Size(530, 26);
            this.txtPaymentServiceFee.TabIndex = 102;
            this.txtPaymentServiceFee.Text = "The Service Fee is :";
            // 
            // lblPaymentServiceFee
            // 
            this.lblPaymentServiceFee.AutoSize = true;
            this.lblPaymentServiceFee.Location = new System.Drawing.Point(75, 219);
            this.lblPaymentServiceFee.Name = "lblPaymentServiceFee";
            this.lblPaymentServiceFee.Size = new System.Drawing.Size(93, 20);
            this.lblPaymentServiceFee.TabIndex = 101;
            this.lblPaymentServiceFee.Text = "Service Fee";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(205, 281);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(530, 26);
            this.txtPayment.TabIndex = 100;
            this.txtPayment.Text = "RM:";
            this.txtPayment.Click += new System.EventHandler(this.txtPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(75, 284);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(71, 20);
            this.lblPayment.TabIndex = 99;
            this.lblPayment.Text = "Payment";
            // 
            // lblPaymentUsername
            // 
            this.lblPaymentUsername.AutoSize = true;
            this.lblPaymentUsername.Location = new System.Drawing.Point(75, 153);
            this.lblPaymentUsername.Name = "lblPaymentUsername";
            this.lblPaymentUsername.Size = new System.Drawing.Size(101, 20);
            this.lblPaymentUsername.TabIndex = 98;
            this.lblPaymentUsername.Text = "USERNAME";
            // 
            // cbxPaymentService
            // 
            this.cbxPaymentService.FormattingEnabled = true;
            this.cbxPaymentService.Location = new System.Drawing.Point(205, 182);
            this.cbxPaymentService.Name = "cbxPaymentService";
            this.cbxPaymentService.Size = new System.Drawing.Size(530, 28);
            this.cbxPaymentService.TabIndex = 97;
            this.cbxPaymentService.Text = "Please Select......";
            this.cbxPaymentService.SelectedIndexChanged += new System.EventHandler(this.cbxPaymentService_SelectedIndexChanged);
            this.cbxPaymentService.Click += new System.EventHandler(this.cbxPaymentService_Click);
            // 
            // lblPaymentService
            // 
            this.lblPaymentService.AutoSize = true;
            this.lblPaymentService.Location = new System.Drawing.Point(75, 185);
            this.lblPaymentService.Name = "lblPaymentService";
            this.lblPaymentService.Size = new System.Drawing.Size(81, 20);
            this.lblPaymentService.TabIndex = 96;
            this.lblPaymentService.Text = "SERVICE";
            // 
            // frm1eRcpPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPaymentWelcome);
            this.Controls.Add(this.cbxPaymentUsername);
            this.Controls.Add(this.lblReceptionForm);
            this.Controls.Add(this.txtPaymentChange);
            this.Controls.Add(this.lblPaymentChange);
            this.Controls.Add(this.btnPaymentReceipt);
            this.Controls.Add(this.btnPaymentCalculate);
            this.Controls.Add(this.btnPaymentConfirm);
            this.Controls.Add(this.txtPaymentServiceFee);
            this.Controls.Add(this.lblPaymentServiceFee);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblPaymentUsername);
            this.Controls.Add(this.cbxPaymentService);
            this.Controls.Add(this.lblPaymentService);
            this.Name = "frm1eRcpPay";
            this.Text = "frm1eRcpPay";
            this.Load += new System.EventHandler(this.frm1eRcpPay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaymentWelcome;
        private System.Windows.Forms.ComboBox cbxPaymentUsername;
        private System.Windows.Forms.Label lblReceptionForm;
        private System.Windows.Forms.TextBox txtPaymentChange;
        private System.Windows.Forms.Label lblPaymentChange;
        private System.Windows.Forms.Button btnPaymentReceipt;
        private System.Windows.Forms.Button btnPaymentCalculate;
        private System.Windows.Forms.Button btnPaymentConfirm;
        private System.Windows.Forms.TextBox txtPaymentServiceFee;
        private System.Windows.Forms.Label lblPaymentServiceFee;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPaymentUsername;
        private System.Windows.Forms.ComboBox cbxPaymentService;
        private System.Windows.Forms.Label lblPaymentService;
    }
}