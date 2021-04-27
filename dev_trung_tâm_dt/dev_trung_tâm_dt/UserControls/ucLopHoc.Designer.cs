namespace dev_trung_tâm_dt.UserControls
{
    partial class ucLopHoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLopHoc));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiDL = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoHV = new System.Windows.Forms.TextBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdLopHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_lophoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_lophoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ma_khoahoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ma_monhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thoi_gian_bd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thoi_gian_kt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.so_hocvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghi_chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBanGhi = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhiDL,
            this.btnHuyBo,
            this.btnRefresh});
            this.barManager1.MaxItemId = 6;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiDL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhiDL
            // 
            this.btnGhiDL.Caption = "Ghi dữ liệu";
            this.btnGhiDL.Id = 3;
            this.btnGhiDL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiDL.ImageOptions.Image")));
            this.btnGhiDL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiDL.ImageOptions.LargeImage")));
            this.btnGhiDL.Name = "btnGhiDL";
            this.btnGhiDL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiDL_ItemClick);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Caption = "Hủy bỏ";
            this.btnHuyBo.Id = 4;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.LargeImage")));
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyBo_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1324, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 742);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1324, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 712);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1324, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 712);
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.cboTrangThai);
            this.groupControl.Controls.Add(this.label8);
            this.groupControl.Controls.Add(this.txtSoHV);
            this.groupControl.Controls.Add(this.dtpNgayKT);
            this.groupControl.Controls.Add(this.label5);
            this.groupControl.Controls.Add(this.cboMaMH);
            this.groupControl.Controls.Add(this.dtpNgayBD);
            this.groupControl.Controls.Add(this.label4);
            this.groupControl.Controls.Add(this.cboMaKH);
            this.groupControl.Controls.Add(this.label7);
            this.groupControl.Controls.Add(this.label3);
            this.groupControl.Controls.Add(this.label2);
            this.groupControl.Controls.Add(this.label6);
            this.groupControl.Controls.Add(this.label9);
            this.groupControl.Controls.Add(this.label14);
            this.groupControl.Controls.Add(this.label13);
            this.groupControl.Controls.Add(this.label16);
            this.groupControl.Controls.Add(this.label15);
            this.groupControl.Controls.Add(this.label12);
            this.groupControl.Controls.Add(this.label11);
            this.groupControl.Controls.Add(this.label10);
            this.groupControl.Controls.Add(this.label1);
            this.groupControl.Controls.Add(this.txtTenLH);
            this.groupControl.Controls.Add(this.txtGhiChu);
            this.groupControl.Controls.Add(this.txtMaLH);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl.Location = new System.Drawing.Point(0, 30);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(1324, 267);
            this.groupControl.TabIndex = 4;
            this.groupControl.Text = "Thông tin chi tiết";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboTrangThai.Location = new System.Drawing.Point(1158, 133);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(58, 28);
            this.cboTrangThai.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1057, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trạng thái:";
            // 
            // txtSoHV
            // 
            this.txtSoHV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHV.Location = new System.Drawing.Point(962, 133);
            this.txtSoHV.Multiline = true;
            this.txtSoHV.Name = "txtSoHV";
            this.txtSoHV.Size = new System.Drawing.Size(58, 28);
            this.txtSoHV.TabIndex = 7;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(557, 133);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(260, 28);
            this.dtpNgayKT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(847, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số học viên:";
            // 
            // cboMaMH
            // 
            this.cboMaMH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(557, 89);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(260, 28);
            this.cboMaMH.TabIndex = 4;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(137, 134);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(260, 28);
            this.dtpNgayBD.TabIndex = 5;
            this.dtpNgayBD.Value = new System.DateTime(2016, 8, 22, 16, 12, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã môn học:";
            // 
            // cboMaKH
            // 
            this.cboMaKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(137, 88);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(260, 28);
            this.cboMaKH.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã khóa học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày bắt đầu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ghi chú:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(1023, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "*";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(400, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(1219, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 22);
            this.label16.TabIndex = 1;
            this.label16.Text = "*";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(820, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(820, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(820, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(400, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lớp học:";
            // 
            // txtTenLH
            // 
            this.txtTenLH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLH.Location = new System.Drawing.Point(557, 44);
            this.txtTenLH.Multiline = true;
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(260, 28);
            this.txtTenLH.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(137, 180);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1182, 76);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Location = new System.Drawing.Point(137, 42);
            this.txtMaLH.Multiline = true;
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(260, 28);
            this.txtMaLH.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdLopHoc);
            this.groupControl2.Controls.Add(this.lblBanGhi);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 297);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1324, 445);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh sách lớp học";
            // 
            // grdLopHoc
            // 
            this.grdLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLopHoc.Location = new System.Drawing.Point(5, 56);
            this.grdLopHoc.MainView = this.gridView1;
            this.grdLopHoc.MenuManager = this.barManager1;
            this.grdLopHoc.Name = "grdLopHoc";
            this.grdLopHoc.Size = new System.Drawing.Size(1314, 384);
            this.grdLopHoc.TabIndex = 2;
            this.grdLopHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdLopHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdLopHoc_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ma_lophoc,
            this.ten_lophoc,
            this.ma_khoahoc,
            this.ma_monhoc,
            this.thoi_gian_bd,
            this.thoi_gian_kt,
            this.so_hocvien,
            this.trang_thai,
            this.ghi_chu});
            this.gridView1.GridControl = this.grdLopHoc;
            this.gridView1.Name = "gridView1";
            // 
            // ma_lophoc
            // 
            this.ma_lophoc.Caption = "Mã lớp học";
            this.ma_lophoc.FieldName = "ma_lophoc";
            this.ma_lophoc.MinWidth = 25;
            this.ma_lophoc.Name = "ma_lophoc";
            this.ma_lophoc.Visible = true;
            this.ma_lophoc.VisibleIndex = 0;
            this.ma_lophoc.Width = 94;
            // 
            // ten_lophoc
            // 
            this.ten_lophoc.Caption = "Tên lớp học";
            this.ten_lophoc.FieldName = "ten_lophoc";
            this.ten_lophoc.MinWidth = 25;
            this.ten_lophoc.Name = "ten_lophoc";
            this.ten_lophoc.Visible = true;
            this.ten_lophoc.VisibleIndex = 1;
            this.ten_lophoc.Width = 94;
            // 
            // ma_khoahoc
            // 
            this.ma_khoahoc.Caption = "Mã khóa học";
            this.ma_khoahoc.FieldName = "ma_khoahoc";
            this.ma_khoahoc.MinWidth = 25;
            this.ma_khoahoc.Name = "ma_khoahoc";
            this.ma_khoahoc.Visible = true;
            this.ma_khoahoc.VisibleIndex = 2;
            this.ma_khoahoc.Width = 94;
            // 
            // ma_monhoc
            // 
            this.ma_monhoc.Caption = "Mã môn học";
            this.ma_monhoc.FieldName = "ma_monhoc";
            this.ma_monhoc.MinWidth = 25;
            this.ma_monhoc.Name = "ma_monhoc";
            this.ma_monhoc.Visible = true;
            this.ma_monhoc.VisibleIndex = 3;
            this.ma_monhoc.Width = 94;
            // 
            // thoi_gian_bd
            // 
            this.thoi_gian_bd.Caption = "Thời gian bắt đầu";
            this.thoi_gian_bd.FieldName = "thoi_gian_bd";
            this.thoi_gian_bd.MinWidth = 25;
            this.thoi_gian_bd.Name = "thoi_gian_bd";
            this.thoi_gian_bd.Visible = true;
            this.thoi_gian_bd.VisibleIndex = 4;
            this.thoi_gian_bd.Width = 94;
            // 
            // thoi_gian_kt
            // 
            this.thoi_gian_kt.Caption = "Thời gian kết thúc";
            this.thoi_gian_kt.FieldName = "thoi_gian_kt";
            this.thoi_gian_kt.MinWidth = 25;
            this.thoi_gian_kt.Name = "thoi_gian_kt";
            this.thoi_gian_kt.Visible = true;
            this.thoi_gian_kt.VisibleIndex = 5;
            this.thoi_gian_kt.Width = 94;
            // 
            // so_hocvien
            // 
            this.so_hocvien.Caption = "Số học viên";
            this.so_hocvien.FieldName = "so_hocvien";
            this.so_hocvien.MinWidth = 25;
            this.so_hocvien.Name = "so_hocvien";
            this.so_hocvien.Visible = true;
            this.so_hocvien.VisibleIndex = 6;
            this.so_hocvien.Width = 94;
            // 
            // trang_thai
            // 
            this.trang_thai.Caption = "Trạng thái";
            this.trang_thai.FieldName = "trang_thai";
            this.trang_thai.MinWidth = 25;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Visible = true;
            this.trang_thai.VisibleIndex = 7;
            this.trang_thai.Width = 94;
            // 
            // ghi_chu
            // 
            this.ghi_chu.Caption = "Ghi chú";
            this.ghi_chu.FieldName = "ghi_chu";
            this.ghi_chu.MinWidth = 25;
            this.ghi_chu.Name = "ghi_chu";
            this.ghi_chu.Visible = true;
            this.ghi_chu.VisibleIndex = 8;
            this.ghi_chu.Width = 94;
            // 
            // lblBanGhi
            // 
            this.lblBanGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBanGhi.AutoSize = true;
            this.lblBanGhi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanGhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBanGhi.Location = new System.Drawing.Point(1126, 30);
            this.lblBanGhi.Name = "lblBanGhi";
            this.lblBanGhi.Size = new System.Drawing.Size(167, 23);
            this.lblBanGhi.TabIndex = 1;
            this.lblBanGhi.Text = "Tổng số : 7 bản ghi";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // ucLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucLopHoc";
            this.Size = new System.Drawing.Size(1324, 742);
            this.Load += new System.EventHandler(this.ucLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhiDL;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtSoHV;
        private System.Windows.Forms.TextBox txtMaLH;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblBanGhi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.GridControl grdLopHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ma_lophoc;
        private DevExpress.XtraGrid.Columns.GridColumn ten_lophoc;
        private DevExpress.XtraGrid.Columns.GridColumn ma_khoahoc;
        private DevExpress.XtraGrid.Columns.GridColumn ma_monhoc;
        private DevExpress.XtraGrid.Columns.GridColumn thoi_gian_bd;
        private DevExpress.XtraGrid.Columns.GridColumn thoi_gian_kt;
        private DevExpress.XtraGrid.Columns.GridColumn so_hocvien;
        private DevExpress.XtraGrid.Columns.GridColumn trang_thai;
        private DevExpress.XtraGrid.Columns.GridColumn ghi_chu;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
    }
}
