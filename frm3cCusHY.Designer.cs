
namespace IOOP
{
    partial class frm3cCusHY
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
            this.lblCus6 = new System.Windows.Forms.Label();
            this.dgvCusRS = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusRS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCus6
            // 
            this.lblCus6.AutoSize = true;
            this.lblCus6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCus6.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCus6.Location = new System.Drawing.Point(12, 22);
            this.lblCus6.Name = "lblCus6";
            this.lblCus6.Size = new System.Drawing.Size(200, 31);
            this.lblCus6.TabIndex = 1;
            this.lblCus6.Text = "Service History";
            // 
            // dgvCusRS
            // 
            this.dgvCusRS.AllowUserToAddRows = false;
            this.dgvCusRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusRS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customerName,
            this.serviceType,
            this.serviceDemand,
            this.fee,
            this.requestDate,
            this.completionDate,
            this.remark,
            this.collectionDate});
            this.dgvCusRS.Location = new System.Drawing.Point(21, 78);
            this.dgvCusRS.Name = "dgvCusRS";
            this.dgvCusRS.RowHeadersWidth = 51;
            this.dgvCusRS.RowTemplate.Height = 24;
            this.dgvCusRS.Size = new System.Drawing.Size(1366, 410);
            this.dgvCusRS.TabIndex = 2;
            this.dgvCusRS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCusRS_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Service Id";
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
            // completionDate
            // 
            this.completionDate.DataPropertyName = "completionDate";
            this.completionDate.HeaderText = "Completion Date";
            this.completionDate.MinimumWidth = 6;
            this.completionDate.Name = "completionDate";
            this.completionDate.Width = 140;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "Remark";
            this.remark.MinimumWidth = 6;
            this.remark.Name = "remark";
            this.remark.Width = 300;
            // 
            // collectionDate
            // 
            this.collectionDate.DataPropertyName = "collectionDate";
            this.collectionDate.HeaderText = "Collection Date";
            this.collectionDate.MinimumWidth = 6;
            this.collectionDate.Name = "collectionDate";
            this.collectionDate.Width = 140;
            // 
            // frm3cCusHY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 554);
            this.Controls.Add(this.dgvCusRS);
            this.Controls.Add(this.lblCus6);
            this.Name = "frm3cCusHY";
            this.Text = "frm3bCusHY";
            this.Load += new System.EventHandler(this.frm3bCusHY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusRS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCus6;
        private System.Windows.Forms.DataGridView dgvCusRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionDate;
    }
}