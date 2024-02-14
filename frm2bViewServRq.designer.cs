
namespace IOOP
{
    partial class frm2bViewServRq
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
            this.grpUrgSD = new System.Windows.Forms.GroupBox();
            this.cmbUrgServID = new System.Windows.Forms.ComboBox();
            this.grpNormSD = new System.Windows.Forms.GroupBox();
            this.cmbNormServID = new System.Windows.Forms.ComboBox();
            this.lblServTyp = new System.Windows.Forms.Label();
            this.lblServRqDt = new System.Windows.Forms.Label();
            this.grpServInfo = new System.Windows.Forms.GroupBox();
            this.lblDispServRqDt = new System.Windows.Forms.Label();
            this.lblDispServTyp = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPenServRq = new System.Windows.Forms.Label();
            this.grpUrgSD.SuspendLayout();
            this.grpNormSD.SuspendLayout();
            this.grpServInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUrgSD
            // 
            this.grpUrgSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpUrgSD.Controls.Add(this.cmbUrgServID);
            this.grpUrgSD.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUrgSD.Location = new System.Drawing.Point(66, 180);
            this.grpUrgSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUrgSD.Name = "grpUrgSD";
            this.grpUrgSD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUrgSD.Size = new System.Drawing.Size(244, 185);
            this.grpUrgSD.TabIndex = 0;
            this.grpUrgSD.TabStop = false;
            this.grpUrgSD.Text = "Urgent Service Demand";
            // 
            // cmbUrgServID
            // 
            this.cmbUrgServID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUrgServID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUrgServID.BackColor = System.Drawing.Color.MistyRose;
            this.cmbUrgServID.DropDownHeight = 80;
            this.cmbUrgServID.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUrgServID.FormattingEnabled = true;
            this.cmbUrgServID.IntegralHeight = false;
            this.cmbUrgServID.Location = new System.Drawing.Point(23, 73);
            this.cmbUrgServID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUrgServID.Name = "cmbUrgServID";
            this.cmbUrgServID.Size = new System.Drawing.Size(147, 36);
            this.cmbUrgServID.TabIndex = 0;
            this.cmbUrgServID.SelectedIndexChanged += new System.EventHandler(this.cmbUrgServID_SelectedIndexChanged);
            // 
            // grpNormSD
            // 
            this.grpNormSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpNormSD.Controls.Add(this.cmbNormServID);
            this.grpNormSD.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNormSD.Location = new System.Drawing.Point(66, 412);
            this.grpNormSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNormSD.Name = "grpNormSD";
            this.grpNormSD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNormSD.Size = new System.Drawing.Size(244, 185);
            this.grpNormSD.TabIndex = 1;
            this.grpNormSD.TabStop = false;
            this.grpNormSD.Text = "Normal Service Demand";
            // 
            // cmbNormServID
            // 
            this.cmbNormServID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNormServID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNormServID.BackColor = System.Drawing.Color.MistyRose;
            this.cmbNormServID.DropDownHeight = 80;
            this.cmbNormServID.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNormServID.FormattingEnabled = true;
            this.cmbNormServID.IntegralHeight = false;
            this.cmbNormServID.Location = new System.Drawing.Point(23, 74);
            this.cmbNormServID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNormServID.Name = "cmbNormServID";
            this.cmbNormServID.Size = new System.Drawing.Size(147, 36);
            this.cmbNormServID.TabIndex = 0;
            this.cmbNormServID.SelectedIndexChanged += new System.EventHandler(this.cmbNormServID_SelectedIndexChanged);
            // 
            // lblServTyp
            // 
            this.lblServTyp.AutoSize = true;
            this.lblServTyp.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServTyp.Location = new System.Drawing.Point(35, 53);
            this.lblServTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServTyp.Name = "lblServTyp";
            this.lblServTyp.Size = new System.Drawing.Size(137, 25);
            this.lblServTyp.TabIndex = 2;
            this.lblServTyp.Text = "Service Type";
            // 
            // lblServRqDt
            // 
            this.lblServRqDt.AutoSize = true;
            this.lblServRqDt.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServRqDt.Location = new System.Drawing.Point(35, 148);
            this.lblServRqDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServRqDt.Name = "lblServRqDt";
            this.lblServRqDt.Size = new System.Drawing.Size(217, 25);
            this.lblServRqDt.TabIndex = 4;
            this.lblServRqDt.Text = "Service Request Date";
            // 
            // grpServInfo
            // 
            this.grpServInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpServInfo.Controls.Add(this.lblDispServRqDt);
            this.grpServInfo.Controls.Add(this.lblDispServTyp);
            this.grpServInfo.Controls.Add(this.lblServTyp);
            this.grpServInfo.Controls.Add(this.lblServRqDt);
            this.grpServInfo.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServInfo.Location = new System.Drawing.Point(381, 180);
            this.grpServInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpServInfo.Name = "grpServInfo";
            this.grpServInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpServInfo.Size = new System.Drawing.Size(758, 271);
            this.grpServInfo.TabIndex = 1;
            this.grpServInfo.TabStop = false;
            this.grpServInfo.Text = "Service Information";
            this.grpServInfo.Enter += new System.EventHandler(this.grpServInfo_Enter);
            // 
            // lblDispServRqDt
            // 
            this.lblDispServRqDt.AutoSize = true;
            this.lblDispServRqDt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDispServRqDt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDispServRqDt.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispServRqDt.Location = new System.Drawing.Point(57, 188);
            this.lblDispServRqDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDispServRqDt.Name = "lblDispServRqDt";
            this.lblDispServRqDt.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblDispServRqDt.Size = new System.Drawing.Size(26, 31);
            this.lblDispServRqDt.TabIndex = 6;
            // 
            // lblDispServTyp
            // 
            this.lblDispServTyp.AutoSize = true;
            this.lblDispServTyp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDispServTyp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDispServTyp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispServTyp.Location = new System.Drawing.Point(57, 100);
            this.lblDispServTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDispServTyp.Name = "lblDispServTyp";
            this.lblDispServTyp.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblDispServTyp.Size = new System.Drawing.Size(26, 31);
            this.lblDispServTyp.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(491, 563);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPenServRq
            // 
            this.lblPenServRq.AutoSize = true;
            this.lblPenServRq.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenServRq.Location = new System.Drawing.Point(321, 59);
            this.lblPenServRq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPenServRq.Name = "lblPenServRq";
            this.lblPenServRq.Size = new System.Drawing.Size(421, 30);
            this.lblPenServRq.TabIndex = 9;
            this.lblPenServRq.Text = "PENDING SERVICE REQUEST";
            // 
            // frm2bViewServRq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1154, 664);
            this.Controls.Add(this.lblPenServRq);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpServInfo);
            this.Controls.Add(this.grpNormSD);
            this.Controls.Add(this.grpUrgSD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm2bViewServRq";
            this.Text = "View Service Request";
            this.Load += new System.EventHandler(this.frm2bViewServRq_Load);
            this.grpUrgSD.ResumeLayout(false);
            this.grpNormSD.ResumeLayout(false);
            this.grpServInfo.ResumeLayout(false);
            this.grpServInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUrgSD;
        private System.Windows.Forms.ComboBox cmbUrgServID;
        private System.Windows.Forms.GroupBox grpNormSD;
        private System.Windows.Forms.ComboBox cmbNormServID;
        private System.Windows.Forms.Label lblServTyp;
        private System.Windows.Forms.Label lblServRqDt;
        private System.Windows.Forms.GroupBox grpServInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDispServRqDt;
        private System.Windows.Forms.Label lblDispServTyp;
        private System.Windows.Forms.Label lblPenServRq;
    }
}