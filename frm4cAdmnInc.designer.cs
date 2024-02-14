
namespace IOOP
{
    partial class frm4cAdmnInc
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
            this.btnAdmnBack = new System.Windows.Forms.Button();
            this.tpickDt1 = new System.Windows.Forms.DateTimePicker();
            this.tpickDt2 = new System.Windows.Forms.DateTimePicker();
            this.dgvAdmnInc = new System.Windows.Forms.DataGridView();
            this.btnEntr = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.lblMnth = new System.Windows.Forms.Label();
            this.lblAdmnForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmnInc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmnBack
            // 
            this.btnAdmnBack.Location = new System.Drawing.Point(983, 567);
            this.btnAdmnBack.Name = "btnAdmnBack";
            this.btnAdmnBack.Size = new System.Drawing.Size(127, 51);
            this.btnAdmnBack.TabIndex = 4;
            this.btnAdmnBack.Text = "BACK";
            this.btnAdmnBack.UseVisualStyleBackColor = true;
            this.btnAdmnBack.Click += new System.EventHandler(this.btnAdmnBack_Click);
            // 
            // tpickDt1
            // 
            this.tpickDt1.CustomFormat = "yyyy-MM-dd";
            this.tpickDt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpickDt1.Location = new System.Drawing.Point(158, 111);
            this.tpickDt1.Name = "tpickDt1";
            this.tpickDt1.Size = new System.Drawing.Size(283, 29);
            this.tpickDt1.TabIndex = 5;
            this.tpickDt1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tpickDt2
            // 
            this.tpickDt2.CustomFormat = "yyyy-MM-dd";
            this.tpickDt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpickDt2.Location = new System.Drawing.Point(158, 175);
            this.tpickDt2.Name = "tpickDt2";
            this.tpickDt2.Size = new System.Drawing.Size(283, 29);
            this.tpickDt2.TabIndex = 6;
            // 
            // dgvAdmnInc
            // 
            this.dgvAdmnInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmnInc.Location = new System.Drawing.Point(25, 214);
            this.dgvAdmnInc.Name = "dgvAdmnInc";
            this.dgvAdmnInc.RowHeadersWidth = 72;
            this.dgvAdmnInc.RowTemplate.Height = 31;
            this.dgvAdmnInc.Size = new System.Drawing.Size(1085, 347);
            this.dgvAdmnInc.TabIndex = 7;
            this.dgvAdmnInc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmnInc_CellContentClick);
            // 
            // btnEntr
            // 
            this.btnEntr.Location = new System.Drawing.Point(479, 130);
            this.btnEntr.Name = "btnEntr";
            this.btnEntr.Size = new System.Drawing.Size(116, 40);
            this.btnEntr.TabIndex = 8;
            this.btnEntr.Text = "Enter";
            this.btnEntr.UseVisualStyleBackColor = true;
            this.btnEntr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(709, 126);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(165, 48);
            this.btnIncome.TabIndex = 9;
            this.btnIncome.Text = "Total Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblMnth
            // 
            this.lblMnth.AutoSize = true;
            this.lblMnth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnth.Location = new System.Drawing.Point(10, 130);
            this.lblMnth.Name = "lblMnth";
            this.lblMnth.Size = new System.Drawing.Size(122, 42);
            this.lblMnth.TabIndex = 1;
            this.lblMnth.Text = "Month";
            this.lblMnth.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAdmnForm
            // 
            this.lblAdmnForm.AutoSize = true;
            this.lblAdmnForm.Font = new System.Drawing.Font("Rockwell", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmnForm.Location = new System.Drawing.Point(12, 9);
            this.lblAdmnForm.Name = "lblAdmnForm";
            this.lblAdmnForm.Size = new System.Drawing.Size(813, 73);
            this.lblAdmnForm.TabIndex = 1;
            this.lblAdmnForm.Text = "Total Services and Income";
            this.lblAdmnForm.Click += new System.EventHandler(this.lblAdmnForm_Click);
            // 
            // frm4cAdmnInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 630);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnEntr);
            this.Controls.Add(this.dgvAdmnInc);
            this.Controls.Add(this.tpickDt2);
            this.Controls.Add(this.tpickDt1);
            this.Controls.Add(this.btnAdmnBack);
            this.Controls.Add(this.lblMnth);
            this.Controls.Add(this.lblAdmnForm);
            this.Name = "frm4cAdmnInc";
            this.Text = "AdminTotalIncome";
            this.Load += new System.EventHandler(this.AdminMonthlyIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmnInc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdmnBack;
        private System.Windows.Forms.DateTimePicker tpickDt1;
        private System.Windows.Forms.DateTimePicker tpickDt2;
        private System.Windows.Forms.DataGridView dgvAdmnInc;
        private System.Windows.Forms.Button btnEntr;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Label lblMnth;
        private System.Windows.Forms.Label lblAdmnForm;
    }
}