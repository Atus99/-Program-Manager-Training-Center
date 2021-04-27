namespace dev_trung_tâm_dt.UserControls
{
    partial class ucBaoCao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoQuy = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdoChiPhi = new System.Windows.Forms.RadioButton();
            this.rdoHocPhi = new System.Windows.Forms.RadioButton();
            this.rdoSoLuongHV = new System.Windows.Forms.RadioButton();
            this.rdoKhoahoc = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.txtNam);
            this.groupControl1.Controls.Add(this.btnTaoBaoCao);
            this.groupControl1.Controls.Add(this.cboQuy);
            this.groupControl1.Controls.Add(this.cboThang);
            this.groupControl1.Controls.Add(this.dtpDenNgay);
            this.groupControl1.Controls.Add(this.rdoNam);
            this.groupControl1.Controls.Add(this.dtpTuNgay);
            this.groupControl1.Controls.Add(this.rdoQuy);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.rdoThang);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.rdoNgay);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Location = new System.Drawing.Point(3, 267);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(370, 527);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn thời gian";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(146, 364);
            this.txtNam.Multiline = true;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(211, 28);
            this.txtNam.TabIndex = 20;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.Gray;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(15, 428);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(342, 48);
            this.btnTaoBaoCao.TabIndex = 19;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // cboQuy
            // 
            this.cboQuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuy.Location = new System.Drawing.Point(146, 293);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(211, 28);
            this.cboQuy.TabIndex = 18;
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(146, 230);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(211, 28);
            this.cboThang.TabIndex = 18;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(146, 168);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(212, 28);
            this.dtpDenNgay.TabIndex = 17;
            this.dtpDenNgay.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(15, 367);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(17, 16);
            this.rdoNam.TabIndex = 16;
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(146, 111);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(212, 28);
            this.dtpTuNgay.TabIndex = 17;
            this.dtpTuNgay.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // rdoQuy
            // 
            this.rdoQuy.AutoSize = true;
            this.rdoQuy.Location = new System.Drawing.Point(15, 298);
            this.rdoQuy.Name = "rdoQuy";
            this.rdoQuy.Size = new System.Drawing.Size(17, 16);
            this.rdoQuy.TabIndex = 16;
            this.rdoQuy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đến ngày:";
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(15, 235);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(17, 16);
            this.rdoThang.TabIndex = 16;
            this.rdoThang.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Năm:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quý:";
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Checked = true;
            this.rdoNgay.Location = new System.Drawing.Point(15, 119);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(17, 16);
            this.rdoNgay.TabIndex = 16;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chọn mốc thời gian báo cáo";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rdoChiPhi);
            this.groupControl2.Controls.Add(this.rdoHocPhi);
            this.groupControl2.Controls.Add(this.rdoSoLuongHV);
            this.groupControl2.Controls.Add(this.rdoKhoahoc);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(370, 258);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chọn báo cáo";
            // 
            // rdoChiPhi
            // 
            this.rdoChiPhi.AutoSize = true;
            this.rdoChiPhi.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChiPhi.Location = new System.Drawing.Point(16, 204);
            this.rdoChiPhi.Name = "rdoChiPhi";
            this.rdoChiPhi.Size = new System.Drawing.Size(150, 26);
            this.rdoChiPhi.TabIndex = 0;
            this.rdoChiPhi.Text = "Báo cáo chi phí";
            this.rdoChiPhi.UseVisualStyleBackColor = true;
            // 
            // rdoHocPhi
            // 
            this.rdoHocPhi.AutoSize = true;
            this.rdoHocPhi.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHocPhi.Location = new System.Drawing.Point(16, 148);
            this.rdoHocPhi.Name = "rdoHocPhi";
            this.rdoHocPhi.Size = new System.Drawing.Size(155, 26);
            this.rdoHocPhi.TabIndex = 0;
            this.rdoHocPhi.Text = "Báo cáo học phí";
            this.rdoHocPhi.UseVisualStyleBackColor = true;
            // 
            // rdoSoLuongHV
            // 
            this.rdoSoLuongHV.AutoSize = true;
            this.rdoSoLuongHV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSoLuongHV.Location = new System.Drawing.Point(16, 99);
            this.rdoSoLuongHV.Name = "rdoSoLuongHV";
            this.rdoSoLuongHV.Size = new System.Drawing.Size(238, 26);
            this.rdoSoLuongHV.TabIndex = 0;
            this.rdoSoLuongHV.Text = "Báo cáo số lượng học viên";
            this.rdoSoLuongHV.UseVisualStyleBackColor = true;
            // 
            // rdoKhoahoc
            // 
            this.rdoKhoahoc.AutoSize = true;
            this.rdoKhoahoc.Checked = true;
            this.rdoKhoahoc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhoahoc.Location = new System.Drawing.Point(16, 47);
            this.rdoKhoahoc.Name = "rdoKhoahoc";
            this.rdoKhoahoc.Size = new System.Drawing.Size(241, 26);
            this.rdoKhoahoc.TabIndex = 0;
            this.rdoKhoahoc.TabStop = true;
            this.rdoKhoahoc.Text = "Báo cáo thống kê khóa học";
            this.rdoKhoahoc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.printBaoCao);
            this.panel1.Location = new System.Drawing.Point(379, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 790);
            this.panel1.TabIndex = 3;
            // 
            // printBaoCao
            // 
            this.printBaoCao.ActiveViewIndex = -1;
            this.printBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.printBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printBaoCao.Location = new System.Drawing.Point(0, 0);
            this.printBaoCao.Name = "printBaoCao";
            this.printBaoCao.Size = new System.Drawing.Size(1150, 790);
            this.printBaoCao.TabIndex = 0;
            // 
            // ucBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "ucBaoCao";
            this.Size = new System.Drawing.Size(1532, 797);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoQuy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rdoKhoahoc;
        private System.Windows.Forms.RadioButton rdoChiPhi;
        private System.Windows.Forms.RadioButton rdoHocPhi;
        private System.Windows.Forms.RadioButton rdoSoLuongHV;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer printBaoCao;
        private System.Windows.Forms.TextBox txtNam;
    }
}
