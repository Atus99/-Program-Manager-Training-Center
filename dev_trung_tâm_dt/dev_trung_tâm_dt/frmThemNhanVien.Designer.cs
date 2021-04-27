namespace dev_trung_tâm_dt
{
    partial class frmThemNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhanVien));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExits = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCMTND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dtpNgayLV = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExits)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.pnlHeader.Controls.Add(this.btnExits);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(939, 51);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnExits
            // 
            this.btnExits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExits.BackColor = System.Drawing.Color.Transparent;
            this.btnExits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExits.Image = ((System.Drawing.Image)(resources.GetObject("btnExits.Image")));
            this.btnExits.ImageActive = null;
            this.btnExits.Location = new System.Drawing.Point(898, 11);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(30, 30);
            this.btnExits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExits.TabIndex = 1;
            this.btnExits.TabStop = false;
            this.btnExits.Zoom = 10;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpNgayLV);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpNgaySinh);
            this.panel2.Controls.Add(this.cboTrangThai);
            this.panel2.Controls.Add(this.cboChucVu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnPath);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtQueQuan);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCMTND);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rdoNu);
            this.panel2.Controls.Add(this.rdoNam);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDuongDan);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.picAnh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 532);
            this.panel2.TabIndex = 55;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(345, 235);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 31);
            this.txtEmail.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(341, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 130;
            this.label8.Text = "Email";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(195, 167);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(307, 31);
            this.dtpNgaySinh.TabIndex = 3;
            this.dtpNgaySinh.Value = new System.DateTime(1990, 9, 7, 20, 28, 0, 0);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboTrangThai.Location = new System.Drawing.Point(712, 306);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(93, 31);
            this.cboTrangThai.TabIndex = 11;
            // 
            // cboChucVu
            // 
            this.cboChucVu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Kế toán",
            "Tư vấn",
            "Marketing",
            "Bảo vệ"});
            this.cboChucVu.Location = new System.Drawing.Point(345, 306);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(340, 31);
            this.cboChucVu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(191, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 126;
            this.label4.Text = "Ngày sinh";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btnHuy.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(631, 460);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(296, 45);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(631, 409);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(296, 45);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(875, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(53, 32);
            this.btnPath.TabIndex = 123;
            this.btnPath.Text = "...";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(331, 391);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(280, 130);
            this.txtGhiChu.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(327, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 121;
            this.label12.Text = "Ghi chú";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(13, 391);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(280, 130);
            this.txtQueQuan.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(9, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 119;
            this.label7.Text = "Quê quán";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(13, 306);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(302, 31);
            this.txtSDT.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(707, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 23);
            this.label13.TabIndex = 111;
            this.label13.Text = "Trạng thái";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(9, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 111;
            this.label11.Text = "Số điện thoại";
            // 
            // txtCMTND
            // 
            this.txtCMTND.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMTND.Location = new System.Drawing.Point(13, 235);
            this.txtCMTND.Multiline = true;
            this.txtCMTND.Name = "txtCMTND";
            this.txtCMTND.Size = new System.Drawing.Size(302, 31);
            this.txtCMTND.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(708, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 23);
            this.label10.TabIndex = 111;
            this.label10.Text = "Ngày vào làm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(341, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 112;
            this.label9.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(9, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 114;
            this.label6.Text = "CMTND";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.ForeColor = System.Drawing.Color.DimGray;
            this.rdoNu.Location = new System.Drawing.Point(691, 171);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(57, 27);
            this.rdoNu.TabIndex = 5;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.ForeColor = System.Drawing.Color.DimGray;
            this.rdoNam.Location = new System.Drawing.Point(592, 171);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(72, 27);
            this.rdoNam.TabIndex = 4;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(544, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 108;
            this.label5.Text = "Giới tính";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.Location = new System.Drawing.Point(195, 12);
            this.txtDuongDan.Multiline = true;
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(674, 32);
            this.txtDuongDan.TabIndex = 107;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(548, 91);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(340, 32);
            this.txtHoTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(544, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 106;
            this.label3.Text = "Họ tên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(195, 91);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(307, 32);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(191, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 106;
            this.label2.Text = "Mã nhân viên";
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(13, 12);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(157, 186);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 16;
            this.picAnh.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dtpNgayLV
            // 
            this.dtpNgayLV.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLV.Location = new System.Drawing.Point(712, 235);
            this.dtpNgayLV.Name = "dtpNgayLV";
            this.dtpNgayLV.Size = new System.Drawing.Size(214, 31);
            this.dtpNgayLV.TabIndex = 131;
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNhanVien";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExits)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnExits;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtpNgaySinh;
        public System.Windows.Forms.ComboBox cboTrangThai;
        public System.Windows.Forms.ComboBox cboChucVu;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnPath;
        public System.Windows.Forms.TextBox txtGhiChu;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtQueQuan;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCMTND;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton rdoNu;
        public System.Windows.Forms.RadioButton rdoNam;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDuongDan;
        public System.Windows.Forms.TextBox txtHoTen;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMaNV;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox picAnh;
        public System.Windows.Forms.DateTimePicker dtpNgayLV;
    }
}