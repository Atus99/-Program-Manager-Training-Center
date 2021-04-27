namespace dev_trung_tâm_dt.UserControls
{
    partial class ucHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHopDong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiDL = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboMaCV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayCD = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayHL = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMucLuong = new System.Windows.Forms.TextBox();
            this.txtNguoiKy = new System.Windows.Forms.TextBox();
            this.txtSoQD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdHopDong = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ma_nhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ma_chucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.muc_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.so_quyetdinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_ky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_hieuluc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_hethan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_chamdut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoi_ky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghi_chu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiDL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1311, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 790);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1311, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 760);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1311, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 760);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cboMaCV);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.dtpNgayCD);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.dtpNgayHH);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.dtpNgayHL);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.dtpNgayKy);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.txtMucLuong);
            this.groupControl1.Controls.Add(this.txtNguoiKy);
            this.groupControl1.Controls.Add(this.txtSoQD);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Location = new System.Drawing.Point(3, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1305, 291);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // cboMaCV
            // 
            this.cboMaCV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaCV.FormattingEnabled = true;
            this.cboMaCV.Location = new System.Drawing.Point(135, 102);
            this.cboMaCV.Name = "cboMaCV";
            this.cboMaCV.Size = new System.Drawing.Size(260, 28);
            this.cboMaCV.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(898, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Người ký:";
            // 
            // dtpNgayCD
            // 
            this.dtpNgayCD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayCD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCD.Location = new System.Drawing.Point(1040, 103);
            this.dtpNgayCD.Name = "dtpNgayCD";
            this.dtpNgayCD.Size = new System.Drawing.Size(260, 28);
            this.dtpNgayCD.TabIndex = 7;
            this.dtpNgayCD.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(898, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày chấm dứt:";
            // 
            // dtpNgayHH
            // 
            this.dtpNgayHH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHH.Location = new System.Drawing.Point(1040, 50);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(260, 28);
            this.dtpNgayHH.TabIndex = 6;
            this.dtpNgayHH.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(898, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày hết hạn:";
            // 
            // dtpNgayHL
            // 
            this.dtpNgayHL.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHL.Location = new System.Drawing.Point(589, 157);
            this.dtpNgayHL.Name = "dtpNgayHL";
            this.dtpNgayHL.Size = new System.Drawing.Size(260, 28);
            this.dtpNgayHL.TabIndex = 5;
            this.dtpNgayHL.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày hiệu lực:";
            // 
            // dtpNgayKy
            // 
            this.dtpNgayKy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKy.Location = new System.Drawing.Point(589, 103);
            this.dtpNgayKy.Name = "dtpNgayKy";
            this.dtpNgayKy.Size = new System.Drawing.Size(260, 28);
            this.dtpNgayKy.TabIndex = 4;
            this.dtpNgayKy.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày ký:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mức lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số quyết định:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(135, 208);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1165, 78);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucLuong.Location = new System.Drawing.Point(135, 155);
            this.txtMucLuong.Multiline = true;
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(260, 28);
            this.txtMucLuong.TabIndex = 2;
            // 
            // txtNguoiKy
            // 
            this.txtNguoiKy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiKy.Location = new System.Drawing.Point(1040, 156);
            this.txtNguoiKy.Multiline = true;
            this.txtNguoiKy.Name = "txtNguoiKy";
            this.txtNguoiKy.Size = new System.Drawing.Size(260, 28);
            this.txtNguoiKy.TabIndex = 8;
            // 
            // txtSoQD
            // 
            this.txtSoQD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoQD.Location = new System.Drawing.Point(589, 49);
            this.txtSoQD.Multiline = true;
            this.txtSoQD.Name = "txtSoQD";
            this.txtSoQD.Size = new System.Drawing.Size(260, 28);
            this.txtSoQD.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(135, 49);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(260, 28);
            this.txtMaNV.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.grdHopDong);
            this.groupControl2.Location = new System.Drawing.Point(3, 334);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1305, 453);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Thông tin chi tiết";
            // 
            // grdHopDong
            // 
            this.grdHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHopDong.Location = new System.Drawing.Point(2, 28);
            this.grdHopDong.MainView = this.gridView;
            this.grdHopDong.Name = "grdHopDong";
            this.grdHopDong.Size = new System.Drawing.Size(1301, 423);
            this.grdHopDong.TabIndex = 1;
            this.grdHopDong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.grdHopDong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdHopDong_MouseDown);
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Appearance.Row.Options.UseForeColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.ma_nhanvien,
            this.ma_chucvu,
            this.muc_luong,
            this.so_quyetdinh,
            this.ngay_ky,
            this.ngay_hieuluc,
            this.ngay_hethan,
            this.trang_thai,
            this.ngay_chamdut,
            this.nguoi_ky,
            this.ghi_chu});
            this.gridView.GridControl = this.grdHopDong;
            this.gridView.Name = "gridView";
            // 
            // id
            // 
            this.id.Caption = "Stt";
            this.id.FieldName = "id";
            this.id.MinWidth = 25;
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 25;
            // 
            // ma_nhanvien
            // 
            this.ma_nhanvien.Caption = "Mã nhân viên";
            this.ma_nhanvien.FieldName = "ma_nhanvien";
            this.ma_nhanvien.MinWidth = 25;
            this.ma_nhanvien.Name = "ma_nhanvien";
            this.ma_nhanvien.Visible = true;
            this.ma_nhanvien.VisibleIndex = 1;
            this.ma_nhanvien.Width = 113;
            // 
            // ma_chucvu
            // 
            this.ma_chucvu.Caption = "Mã chức vụ";
            this.ma_chucvu.FieldName = "ma_chucvu";
            this.ma_chucvu.MinWidth = 25;
            this.ma_chucvu.Name = "ma_chucvu";
            this.ma_chucvu.Visible = true;
            this.ma_chucvu.VisibleIndex = 2;
            this.ma_chucvu.Width = 113;
            // 
            // muc_luong
            // 
            this.muc_luong.Caption = "Mức lương";
            this.muc_luong.FieldName = "muc_luong";
            this.muc_luong.MinWidth = 25;
            this.muc_luong.Name = "muc_luong";
            this.muc_luong.Visible = true;
            this.muc_luong.VisibleIndex = 3;
            this.muc_luong.Width = 113;
            // 
            // so_quyetdinh
            // 
            this.so_quyetdinh.Caption = "Số quyết định";
            this.so_quyetdinh.FieldName = "so_quyetdinh";
            this.so_quyetdinh.MinWidth = 25;
            this.so_quyetdinh.Name = "so_quyetdinh";
            this.so_quyetdinh.Visible = true;
            this.so_quyetdinh.VisibleIndex = 4;
            this.so_quyetdinh.Width = 113;
            // 
            // ngay_ky
            // 
            this.ngay_ky.Caption = "Ngày ký";
            this.ngay_ky.FieldName = "ngay_ky";
            this.ngay_ky.MinWidth = 25;
            this.ngay_ky.Name = "ngay_ky";
            this.ngay_ky.Visible = true;
            this.ngay_ky.VisibleIndex = 5;
            this.ngay_ky.Width = 113;
            // 
            // ngay_hieuluc
            // 
            this.ngay_hieuluc.Caption = "Ngày hiệu lực";
            this.ngay_hieuluc.FieldName = "ngay_hieuluc";
            this.ngay_hieuluc.MinWidth = 25;
            this.ngay_hieuluc.Name = "ngay_hieuluc";
            this.ngay_hieuluc.Visible = true;
            this.ngay_hieuluc.VisibleIndex = 6;
            this.ngay_hieuluc.Width = 113;
            // 
            // ngay_hethan
            // 
            this.ngay_hethan.Caption = "Ngày hết hạn";
            this.ngay_hethan.FieldName = "ngay_hethan";
            this.ngay_hethan.MinWidth = 25;
            this.ngay_hethan.Name = "ngay_hethan";
            this.ngay_hethan.Visible = true;
            this.ngay_hethan.VisibleIndex = 7;
            this.ngay_hethan.Width = 113;
            // 
            // trang_thai
            // 
            this.trang_thai.Caption = "Trạng thái";
            this.trang_thai.FieldName = "trang_thai";
            this.trang_thai.MinWidth = 25;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Visible = true;
            this.trang_thai.VisibleIndex = 8;
            this.trang_thai.Width = 113;
            // 
            // ngay_chamdut
            // 
            this.ngay_chamdut.Caption = "Ngày chấm dứt";
            this.ngay_chamdut.FieldName = "ngay_chamdut";
            this.ngay_chamdut.MinWidth = 25;
            this.ngay_chamdut.Name = "ngay_chamdut";
            this.ngay_chamdut.Visible = true;
            this.ngay_chamdut.VisibleIndex = 9;
            this.ngay_chamdut.Width = 113;
            // 
            // nguoi_ky
            // 
            this.nguoi_ky.Caption = "Người ký";
            this.nguoi_ky.FieldName = "nguoi_ky";
            this.nguoi_ky.MinWidth = 25;
            this.nguoi_ky.Name = "nguoi_ky";
            this.nguoi_ky.Visible = true;
            this.nguoi_ky.VisibleIndex = 10;
            this.nguoi_ky.Width = 113;
            // 
            // ghi_chu
            // 
            this.ghi_chu.Caption = "Ghi chú";
            this.ghi_chu.FieldName = "ghi_chu";
            this.ghi_chu.MinWidth = 25;
            this.ghi_chu.Name = "ghi_chu";
            this.ghi_chu.Visible = true;
            this.ghi_chu.VisibleIndex = 11;
            this.ghi_chu.Width = 118;
            // 
            // ucHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucHopDong";
            this.Size = new System.Drawing.Size(1311, 790);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhiDL;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpNgayHL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoQD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cboMaCV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayCD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMucLuong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdHopDong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.TextBox txtNguoiKy;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn ma_nhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn ma_chucvu;
        private DevExpress.XtraGrid.Columns.GridColumn muc_luong;
        private DevExpress.XtraGrid.Columns.GridColumn so_quyetdinh;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_ky;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_hieuluc;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_hethan;
        private DevExpress.XtraGrid.Columns.GridColumn trang_thai;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_chamdut;
        private DevExpress.XtraGrid.Columns.GridColumn nguoi_ky;
        private DevExpress.XtraGrid.Columns.GridColumn ghi_chu;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
    }
}
