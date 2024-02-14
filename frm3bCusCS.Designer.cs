
namespace IOOP
{
    partial class frm3bCusCS
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
            this.lblCus3 = new System.Windows.Forms.Label();
            this.dgvCusCs = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCus4 = new System.Windows.Forms.Label();
            this.btnUcs = new System.Windows.Forms.Button();
            this.lstCusSt = new System.Windows.Forms.ListBox();
            this.gbSt = new System.Windows.Forms.GroupBox();
            this.btnCuscm = new System.Windows.Forms.Button();
            this.rbtnN = new System.Windows.Forms.RadioButton();
            this.rbtnU = new System.Windows.Forms.RadioButton();
            this.gbSd = new System.Windows.Forms.GroupBox();
            this.lblCus5 = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusCs)).BeginInit();
            this.gbSt.SuspendLayout();
            this.gbSd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCus3
            // 
            this.lblCus3.AutoSize = true;
            this.lblCus3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCus3.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCus3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCus3.Location = new System.Drawing.Point(12, 21);
            this.lblCus3.Name = "lblCus3";
            this.lblCus3.Size = new System.Drawing.Size(237, 31);
            this.lblCus3.TabIndex = 0;
            this.lblCus3.Text = "Requested Service";
            // 
            // dgvCusCs
            // 
            this.dgvCusCs.AllowUserToAddRows = false;
            this.dgvCusCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusCs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customerName,
            this.serviceType,
            this.serviceDemand,
            this.fee,
            this.requestDate,
            this.stat});
            this.dgvCusCs.Location = new System.Drawing.Point(9, 66);
            this.dgvCusCs.Name = "dgvCusCs";
            this.dgvCusCs.RowHeadersWidth = 51;
            this.dgvCusCs.RowTemplate.Height = 24;
            this.dgvCusCs.Size = new System.Drawing.Size(940, 376);
            this.dgvCusCs.TabIndex = 1;
            this.dgvCusCs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCusCs_CellContentClick_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Service id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.Width = 140;
            // 
            // serviceType
            // 
            this.serviceType.DataPropertyName = "serviceType";
            this.serviceType.HeaderText = "Service Type";
            this.serviceType.MinimumWidth = 6;
            this.serviceType.Name = "serviceType";
            this.serviceType.Width = 250;
            // 
            // serviceDemand
            // 
            this.serviceDemand.DataPropertyName = "serviceDemand";
            this.serviceDemand.HeaderText = "Service Demand";
            this.serviceDemand.MinimumWidth = 6;
            this.serviceDemand.Name = "serviceDemand";
            this.serviceDemand.Width = 140;
            // 
            // fee
            // 
            this.fee.DataPropertyName = "fee";
            this.fee.HeaderText = "Fee";
            this.fee.MinimumWidth = 6;
            this.fee.Name = "fee";
            this.fee.Width = 50;
            // 
            // requestDate
            // 
            this.requestDate.DataPropertyName = "requestDate";
            this.requestDate.HeaderText = "Request Date";
            this.requestDate.MinimumWidth = 6;
            this.requestDate.Name = "requestDate";
            this.requestDate.Width = 125;
            // 
            // stat
            // 
            this.stat.DataPropertyName = "stat";
            this.stat.HeaderText = "Payment";
            this.stat.MinimumWidth = 6;
            this.stat.Name = "stat";
            this.stat.Width = 125;
            // 
            // lblCus4
            // 
            this.lblCus4.AutoSize = true;
            this.lblCus4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCus4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCus4.Location = new System.Drawing.Point(14, 456);
            this.lblCus4.Name = "lblCus4";
            this.lblCus4.Size = new System.Drawing.Size(569, 23);
            this.lblCus4.TabIndex = 2;
            this.lblCus4.Text = "If you want to change the type of requested service, please click it.";
            // 
            // btnUcs
            // 
            this.btnUcs.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcs.ForeColor = System.Drawing.Color.Red;
            this.btnUcs.Location = new System.Drawing.Point(331, 732);
            this.btnUcs.Name = "btnUcs";
            this.btnUcs.Size = new System.Drawing.Size(125, 39);
            this.btnUcs.TabIndex = 10;
            this.btnUcs.Text = "Update";
            this.btnUcs.UseVisualStyleBackColor = true;
            this.btnUcs.Click += new System.EventHandler(this.btnUcs_Click);
            // 
            // lstCusSt
            // 
            this.lstCusSt.FormattingEnabled = true;
            this.lstCusSt.ItemHeight = 16;
            this.lstCusSt.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.lstCusSt.Location = new System.Drawing.Point(16, 35);
            this.lstCusSt.Name = "lstCusSt";
            this.lstCusSt.Size = new System.Drawing.Size(333, 116);
            this.lstCusSt.TabIndex = 11;
            // 
            // gbSt
            // 
            this.gbSt.Controls.Add(this.lstCusSt);
            this.gbSt.Location = new System.Drawing.Point(18, 504);
            this.gbSt.Name = "gbSt";
            this.gbSt.Size = new System.Drawing.Size(360, 174);
            this.gbSt.TabIndex = 15;
            this.gbSt.TabStop = false;
            this.gbSt.Text = "Service Type";
            // 
            // btnCuscm
            // 
            this.btnCuscm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuscm.Location = new System.Drawing.Point(89, 133);
            this.btnCuscm.Name = "btnCuscm";
            this.btnCuscm.Size = new System.Drawing.Size(128, 41);
            this.btnCuscm.TabIndex = 14;
            this.btnCuscm.Text = "Check Fee";
            this.btnCuscm.UseVisualStyleBackColor = true;
            this.btnCuscm.Click += new System.EventHandler(this.btnCuscm_Click);
            // 
            // rbtnN
            // 
            this.rbtnN.AutoSize = true;
            this.rbtnN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnN.Location = new System.Drawing.Point(31, 35);
            this.rbtnN.Name = "rbtnN";
            this.rbtnN.Size = new System.Drawing.Size(98, 26);
            this.rbtnN.TabIndex = 6;
            this.rbtnN.TabStop = true;
            this.rbtnN.Text = "Normal ";
            this.rbtnN.UseVisualStyleBackColor = true;
            // 
            // rbtnU
            // 
            this.rbtnU.AutoSize = true;
            this.rbtnU.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnU.Location = new System.Drawing.Point(186, 35);
            this.rbtnU.Name = "rbtnU";
            this.rbtnU.Size = new System.Drawing.Size(92, 26);
            this.rbtnU.TabIndex = 7;
            this.rbtnU.TabStop = true;
            this.rbtnU.Text = "Urgent ";
            this.rbtnU.UseVisualStyleBackColor = true;
            // 
            // gbSd
            // 
            this.gbSd.Controls.Add(this.lblCus5);
            this.gbSd.Controls.Add(this.txtCheck);
            this.gbSd.Controls.Add(this.rbtnU);
            this.gbSd.Controls.Add(this.rbtnN);
            this.gbSd.Controls.Add(this.btnCuscm);
            this.gbSd.Location = new System.Drawing.Point(417, 504);
            this.gbSd.Name = "gbSd";
            this.gbSd.Size = new System.Drawing.Size(309, 200);
            this.gbSd.TabIndex = 16;
            this.gbSd.TabStop = false;
            this.gbSd.Text = "Service Demand";
            // 
            // lblCus5
            // 
            this.lblCus5.AutoSize = true;
            this.lblCus5.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCus5.Location = new System.Drawing.Point(83, 100);
            this.lblCus5.Name = "lblCus5";
            this.lblCus5.Size = new System.Drawing.Size(61, 25);
            this.lblCus5.TabIndex = 16;
            this.lblCus5.Text = "RM :";
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(150, 100);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(67, 22);
            this.txtCheck.TabIndex = 15;
            // 
            // frm3bCusCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 853);
            this.Controls.Add(this.gbSd);
            this.Controls.Add(this.gbSt);
            this.Controls.Add(this.btnUcs);
            this.Controls.Add(this.lblCus4);
            this.Controls.Add(this.dgvCusCs);
            this.Controls.Add(this.lblCus3);
            this.Name = "frm3bCusCS";
            this.Text = "frm3bCusCS";
            this.Load += new System.EventHandler(this.frm3bCusCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusCs)).EndInit();
            this.gbSt.ResumeLayout(false);
            this.gbSd.ResumeLayout(false);
            this.gbSd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCus3;
        private System.Windows.Forms.DataGridView dgvCusCs;
        private System.Windows.Forms.Label lblCus4;
        private System.Windows.Forms.Button btnUcs;
        private System.Windows.Forms.ListBox lstCusSt;
        private System.Windows.Forms.GroupBox gbSt;
        private System.Windows.Forms.Button btnCuscm;
        private System.Windows.Forms.RadioButton rbtnN;
        private System.Windows.Forms.RadioButton rbtnU;
        private System.Windows.Forms.GroupBox gbSd;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Label lblCus5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
    }
}