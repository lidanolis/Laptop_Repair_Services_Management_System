
namespace IOOP
{
    partial class frm2dModServRec
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grpServRec = new System.Windows.Forms.GroupBox();
            this.txtRmk = new System.Windows.Forms.TextBox();
            this.dtpickColDt = new System.Windows.Forms.DateTimePicker();
            this.lblCusColDt = new System.Windows.Forms.Label();
            this.lblServCpDt = new System.Windows.Forms.Label();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRmk = new System.Windows.Forms.Label();
            this.rdbCp = new System.Windows.Forms.RadioButton();
            this.dtpickCpDt = new System.Windows.Forms.DateTimePicker();
            this.cmbServID = new System.Windows.Forms.ComboBox();
            this.lblServID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblModServRec = new System.Windows.Forms.Label();
            this.grpServRec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Location = new System.Drawing.Point(54, 453);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpServRec
            // 
            this.grpServRec.Controls.Add(this.txtRmk);
            this.grpServRec.Controls.Add(this.dtpickColDt);
            this.grpServRec.Controls.Add(this.lblCusColDt);
            this.grpServRec.Controls.Add(this.lblServCpDt);
            this.grpServRec.Controls.Add(this.rdbPending);
            this.grpServRec.Controls.Add(this.lblStatus);
            this.grpServRec.Controls.Add(this.lblRmk);
            this.grpServRec.Controls.Add(this.rdbCp);
            this.grpServRec.Controls.Add(this.dtpickCpDt);
            this.grpServRec.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServRec.Location = new System.Drawing.Point(640, 23);
            this.grpServRec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpServRec.Name = "grpServRec";
            this.grpServRec.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpServRec.Size = new System.Drawing.Size(436, 514);
            this.grpServRec.TabIndex = 3;
            this.grpServRec.TabStop = false;
            this.grpServRec.Text = "Service Record";
            // 
            // txtRmk
            // 
            this.txtRmk.BackColor = System.Drawing.Color.MistyRose;
            this.txtRmk.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmk.Location = new System.Drawing.Point(32, 286);
            this.txtRmk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRmk.Multiline = true;
            this.txtRmk.Name = "txtRmk";
            this.txtRmk.Size = new System.Drawing.Size(382, 78);
            this.txtRmk.TabIndex = 22;
            // 
            // dtpickColDt
            // 
            this.dtpickColDt.CustomFormat = "yyyy-MM-dd";
            this.dtpickColDt.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickColDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickColDt.Location = new System.Drawing.Point(32, 432);
            this.dtpickColDt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpickColDt.Name = "dtpickColDt";
            this.dtpickColDt.Size = new System.Drawing.Size(196, 32);
            this.dtpickColDt.TabIndex = 21;
            this.dtpickColDt.Value = new System.DateTime(2021, 11, 15, 0, 0, 0, 0);
            // 
            // lblCusColDt
            // 
            this.lblCusColDt.AutoSize = true;
            this.lblCusColDt.Location = new System.Drawing.Point(21, 392);
            this.lblCusColDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusColDt.Name = "lblCusColDt";
            this.lblCusColDt.Size = new System.Drawing.Size(242, 22);
            this.lblCusColDt.TabIndex = 20;
            this.lblCusColDt.Text = "Customer Collection Date:";
            // 
            // lblServCpDt
            // 
            this.lblServCpDt.AutoSize = true;
            this.lblServCpDt.Location = new System.Drawing.Point(21, 48);
            this.lblServCpDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServCpDt.Name = "lblServCpDt";
            this.lblServCpDt.Size = new System.Drawing.Size(236, 22);
            this.lblServCpDt.TabIndex = 9;
            this.lblServCpDt.Text = "Service Completion Date:";
            // 
            // rdbPending
            // 
            this.rdbPending.AutoSize = true;
            this.rdbPending.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPending.Location = new System.Drawing.Point(207, 184);
            this.rdbPending.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPending.Name = "rdbPending";
            this.rdbPending.Size = new System.Drawing.Size(103, 26);
            this.rdbPending.TabIndex = 16;
            this.rdbPending.TabStop = true;
            this.rdbPending.Text = "Pending";
            this.rdbPending.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(21, 144);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 22);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // lblRmk
            // 
            this.lblRmk.AutoSize = true;
            this.lblRmk.Location = new System.Drawing.Point(21, 243);
            this.lblRmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRmk.Name = "lblRmk";
            this.lblRmk.Size = new System.Drawing.Size(95, 22);
            this.lblRmk.TabIndex = 10;
            this.lblRmk.Text = "Remarks:";
            // 
            // rdbCp
            // 
            this.rdbCp.AutoSize = true;
            this.rdbCp.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCp.Location = new System.Drawing.Point(32, 184);
            this.rdbCp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbCp.Name = "rdbCp";
            this.rdbCp.Size = new System.Drawing.Size(118, 26);
            this.rdbCp.TabIndex = 14;
            this.rdbCp.TabStop = true;
            this.rdbCp.Text = "Completed";
            this.rdbCp.UseVisualStyleBackColor = true;
            // 
            // dtpickCpDt
            // 
            this.dtpickCpDt.CustomFormat = "yyyy-MM-dd";
            this.dtpickCpDt.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickCpDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickCpDt.Location = new System.Drawing.Point(32, 86);
            this.dtpickCpDt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpickCpDt.Name = "dtpickCpDt";
            this.dtpickCpDt.Size = new System.Drawing.Size(190, 32);
            this.dtpickCpDt.TabIndex = 15;
            // 
            // cmbServID
            // 
            this.cmbServID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbServID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServID.BackColor = System.Drawing.Color.MistyRose;
            this.cmbServID.DropDownHeight = 80;
            this.cmbServID.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServID.FormattingEnabled = true;
            this.cmbServID.IntegralHeight = false;
            this.cmbServID.Location = new System.Drawing.Point(76, 162);
            this.cmbServID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbServID.Name = "cmbServID";
            this.cmbServID.Size = new System.Drawing.Size(147, 34);
            this.cmbServID.TabIndex = 0;
            // 
            // lblServID
            // 
            this.lblServID.AutoSize = true;
            this.lblServID.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServID.Location = new System.Drawing.Point(49, 119);
            this.lblServID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServID.Name = "lblServID";
            this.lblServID.Size = new System.Drawing.Size(254, 22);
            this.lblServID.TabIndex = 1;
            this.lblServID.Text = "Enter or Select Service ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Location = new System.Drawing.Point(479, 453);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnView.Location = new System.Drawing.Point(379, 157);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(127, 42);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Location = new System.Drawing.Point(262, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 42);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblModServRec
            // 
            this.lblModServRec.AutoSize = true;
            this.lblModServRec.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModServRec.Location = new System.Drawing.Point(153, 35);
            this.lblModServRec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModServRec.Name = "lblModServRec";
            this.lblModServRec.Size = new System.Drawing.Size(341, 25);
            this.lblModServRec.TabIndex = 8;
            this.lblModServRec.Text = "MODIFY SERVICE RECORD";
            // 
            // frm2dModServRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1167, 565);
            this.Controls.Add(this.lblModServRec);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblServID);
            this.Controls.Add(this.cmbServID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpServRec);
            this.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm2dModServRec";
            this.Text = "Modify Service Record";
            this.Load += new System.EventHandler(this.frm2dModServRec_Load);
            this.grpServRec.ResumeLayout(false);
            this.grpServRec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpServRec;
        private System.Windows.Forms.ComboBox cmbServID;
        private System.Windows.Forms.Label lblServID;
        private System.Windows.Forms.Label lblServCpDt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRmk;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.DateTimePicker dtpickCpDt;
        private System.Windows.Forms.RadioButton rdbCp;
        private System.Windows.Forms.DateTimePicker dtpickColDt;
        private System.Windows.Forms.Label lblCusColDt;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtRmk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblModServRec;
    }
}