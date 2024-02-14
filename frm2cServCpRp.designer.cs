
namespace IOOP
{
    partial class frm2cServCpRp
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
            this.lblFinServ = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblServCpDt = new System.Windows.Forms.Label();
            this.lblRmk = new System.Windows.Forms.Label();
            this.txtRmk = new System.Windows.Forms.TextBox();
            this.grpEnter = new System.Windows.Forms.GroupBox();
            this.rdbNormServID = new System.Windows.Forms.RadioButton();
            this.rdbUrgServID = new System.Windows.Forms.RadioButton();
            this.chbCp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.cmbServID = new System.Windows.Forms.ComboBox();
            this.lblServID = new System.Windows.Forms.Label();
            this.dtpickColDt = new System.Windows.Forms.DateTimePicker();
            this.lblCusColDt = new System.Windows.Forms.Label();
            this.dtpickCpDt = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNewRp = new System.Windows.Forms.Button();
            this.grpEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFinServ
            // 
            this.lblFinServ.AutoSize = true;
            this.lblFinServ.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinServ.Location = new System.Drawing.Point(309, 21);
            this.lblFinServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinServ.Name = "lblFinServ";
            this.lblFinServ.Size = new System.Drawing.Size(287, 30);
            this.lblFinServ.TabIndex = 0;
            this.lblFinServ.Text = "FINALIZE SERVICE";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFinish.Location = new System.Drawing.Point(407, 574);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(127, 58);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblServCpDt
            // 
            this.lblServCpDt.AutoSize = true;
            this.lblServCpDt.Location = new System.Drawing.Point(114, 229);
            this.lblServCpDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServCpDt.Name = "lblServCpDt";
            this.lblServCpDt.Size = new System.Drawing.Size(281, 25);
            this.lblServCpDt.TabIndex = 2;
            this.lblServCpDt.Text = "Service Completion Date:";
            // 
            // lblRmk
            // 
            this.lblRmk.AutoSize = true;
            this.lblRmk.Location = new System.Drawing.Point(255, 371);
            this.lblRmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRmk.Name = "lblRmk";
            this.lblRmk.Size = new System.Drawing.Size(111, 25);
            this.lblRmk.TabIndex = 3;
            this.lblRmk.Text = "Remarks:";
            // 
            // txtRmk
            // 
            this.txtRmk.BackColor = System.Drawing.Color.MistyRose;
            this.txtRmk.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmk.Location = new System.Drawing.Point(455, 343);
            this.txtRmk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRmk.Multiline = true;
            this.txtRmk.Name = "txtRmk";
            this.txtRmk.Size = new System.Drawing.Size(349, 78);
            this.txtRmk.TabIndex = 4;
            // 
            // grpEnter
            // 
            this.grpEnter.Controls.Add(this.rdbNormServID);
            this.grpEnter.Controls.Add(this.rdbUrgServID);
            this.grpEnter.Controls.Add(this.chbCp);
            this.grpEnter.Controls.Add(this.label1);
            this.grpEnter.Controls.Add(this.lblNote);
            this.grpEnter.Controls.Add(this.cmbServID);
            this.grpEnter.Controls.Add(this.lblServID);
            this.grpEnter.Controls.Add(this.dtpickColDt);
            this.grpEnter.Controls.Add(this.lblCusColDt);
            this.grpEnter.Controls.Add(this.dtpickCpDt);
            this.grpEnter.Controls.Add(this.lblStatus);
            this.grpEnter.Controls.Add(this.txtRmk);
            this.grpEnter.Controls.Add(this.lblServCpDt);
            this.grpEnter.Controls.Add(this.lblRmk);
            this.grpEnter.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnter.Location = new System.Drawing.Point(21, 61);
            this.grpEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEnter.Name = "grpEnter";
            this.grpEnter.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEnter.Size = new System.Drawing.Size(933, 492);
            this.grpEnter.TabIndex = 6;
            this.grpEnter.TabStop = false;
            this.grpEnter.Text = "Enter the following:";
            this.grpEnter.Enter += new System.EventHandler(this.grpEnter_Enter);
            // 
            // rdbNormServID
            // 
            this.rdbNormServID.AutoSize = true;
            this.rdbNormServID.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormServID.Location = new System.Drawing.Point(657, 72);
            this.rdbNormServID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbNormServID.Name = "rdbNormServID";
            this.rdbNormServID.Size = new System.Drawing.Size(222, 29);
            this.rdbNormServID.TabIndex = 25;
            this.rdbNormServID.Text = "Normal Service ID";
            this.rdbNormServID.UseVisualStyleBackColor = true;
            this.rdbNormServID.CheckedChanged += new System.EventHandler(this.rdbNormServID_CheckedChanged);
            // 
            // rdbUrgServID
            // 
            this.rdbUrgServID.AutoSize = true;
            this.rdbUrgServID.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUrgServID.Location = new System.Drawing.Point(455, 72);
            this.rdbUrgServID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbUrgServID.Name = "rdbUrgServID";
            this.rdbUrgServID.Size = new System.Drawing.Size(214, 29);
            this.rdbUrgServID.TabIndex = 24;
            this.rdbUrgServID.Text = "Urgent Service ID";
            this.rdbUrgServID.UseVisualStyleBackColor = true;
            this.rdbUrgServID.CheckedChanged += new System.EventHandler(this.rdbUrgServID_CheckedChanged);
            // 
            // chbCp
            // 
            this.chbCp.AutoSize = true;
            this.chbCp.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCp.Location = new System.Drawing.Point(455, 293);
            this.chbCp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chbCp.Name = "chbCp";
            this.chbCp.Size = new System.Drawing.Size(139, 29);
            this.chbCp.TabIndex = 28;
            this.chbCp.Text = "Completed";
            this.chbCp.UseVisualStyleBackColor = true;
            this.chbCp.CheckedChanged += new System.EventHandler(this.chbCp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Service Demand:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(255, 122);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(546, 24);
            this.lblNote.TabIndex = 23;
            this.lblNote.Text = "NOTE: Select only one service ID per service completion report.";
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
            this.cmbServID.Location = new System.Drawing.Point(455, 156);
            this.cmbServID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbServID.Name = "cmbServID";
            this.cmbServID.Size = new System.Drawing.Size(147, 36);
            this.cmbServID.TabIndex = 20;
            this.cmbServID.SelectedIndexChanged += new System.EventHandler(this.cmbServID_SelectedIndexChanged);
            // 
            // lblServID
            // 
            this.lblServID.AutoSize = true;
            this.lblServID.Location = new System.Drawing.Point(238, 160);
            this.lblServID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServID.Name = "lblServID";
            this.lblServID.Size = new System.Drawing.Size(132, 25);
            this.lblServID.TabIndex = 22;
            this.lblServID.Text = "Service ID:";
            // 
            // dtpickColDt
            // 
            this.dtpickColDt.CustomFormat = "yyyy-MM-dd";
            this.dtpickColDt.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickColDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickColDt.Location = new System.Drawing.Point(455, 450);
            this.dtpickColDt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpickColDt.Name = "dtpickColDt";
            this.dtpickColDt.Size = new System.Drawing.Size(190, 36);
            this.dtpickColDt.TabIndex = 19;
            this.dtpickColDt.Value = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            this.dtpickColDt.ValueChanged += new System.EventHandler(this.dtpickColDt_ValueChanged);
            // 
            // lblCusColDt
            // 
            this.lblCusColDt.AutoSize = true;
            this.lblCusColDt.Location = new System.Drawing.Point(108, 453);
            this.lblCusColDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusColDt.Name = "lblCusColDt";
            this.lblCusColDt.Size = new System.Drawing.Size(289, 25);
            this.lblCusColDt.TabIndex = 18;
            this.lblCusColDt.Text = "Customer Collection Date:";
            // 
            // dtpickCpDt
            // 
            this.dtpickCpDt.CustomFormat = "yyyy-MM-dd";
            this.dtpickCpDt.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickCpDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickCpDt.Location = new System.Drawing.Point(455, 226);
            this.dtpickCpDt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpickCpDt.Name = "dtpickCpDt";
            this.dtpickCpDt.Size = new System.Drawing.Size(190, 36);
            this.dtpickCpDt.TabIndex = 17;
            this.dtpickCpDt.Value = new System.DateTime(2021, 11, 9, 0, 0, 0, 0);
            this.dtpickCpDt.ValueChanged += new System.EventHandler(this.dtpickCpDt_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(279, 295);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Location = new System.Drawing.Point(186, 574);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 58);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNewRp
            // 
            this.btnNewRp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewRp.Location = new System.Drawing.Point(626, 574);
            this.btnNewRp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewRp.Name = "btnNewRp";
            this.btnNewRp.Size = new System.Drawing.Size(127, 58);
            this.btnNewRp.TabIndex = 8;
            this.btnNewRp.Text = "New Report";
            this.btnNewRp.UseVisualStyleBackColor = false;
            this.btnNewRp.Click += new System.EventHandler(this.btnNewRp_Click);
            // 
            // frm2cServCpRp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(985, 669);
            this.Controls.Add(this.btnNewRp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpEnter);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblFinServ);
            this.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm2cServCpRp";
            this.Text = "Service Completion Report";
            this.Load += new System.EventHandler(this.frm2cServCpRp_Load);
            this.grpEnter.ResumeLayout(false);
            this.grpEnter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinServ;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblServCpDt;
        private System.Windows.Forms.Label lblRmk;
        private System.Windows.Forms.TextBox txtRmk;
        private System.Windows.Forms.GroupBox grpEnter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpickCpDt;
        private System.Windows.Forms.DateTimePicker dtpickColDt;
        private System.Windows.Forms.Label lblCusColDt;
        private System.Windows.Forms.ComboBox cmbServID;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblServID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNormServID;
        private System.Windows.Forms.RadioButton rdbUrgServID;
        private System.Windows.Forms.CheckBox chbCp;
        private System.Windows.Forms.Button btnNewRp;
    }
}