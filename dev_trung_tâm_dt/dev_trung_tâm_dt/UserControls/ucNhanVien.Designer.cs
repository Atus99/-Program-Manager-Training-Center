namespace dev_trung_tâm_dt.UserControls
{
    partial class ucNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhanVien));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_nhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ho_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gioi_tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmtnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.que_quan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.so_dien_thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_bd_lv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghi_chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.anh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnEmail = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBanGhi = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCMTND = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.lblNgayLV = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnHuyBo,
            this.btnReset});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnReset
            // 
            this.btnReset.Caption = "Refresh";
            this.btnReset.Id = 5;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.LargeImage")));
            this.btnReset.Name = "btnReset";
            this.btnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReset_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1207, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 707);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1207, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 683);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1207, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 683);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi dữ liệu";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Caption = "Hủy bỏ";
            this.btnHuyBo.Id = 4;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.LargeImage")));
            this.btnHuyBo.Name = "btnHuyBo";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.grdNhanVien);
            this.groupControl1.Location = new System.Drawing.Point(278, 29);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(926, 678);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Danh sách nhân viên";
            // 
            // grdNhanVien
            // 
            this.grdNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdNhanVien.Location = new System.Drawing.Point(2, 23);
            this.grdNhanVien.MainView = this.gridView;
            this.grdNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdNhanVien.MenuManager = this.barManager1;
            this.grdNhanVien.Name = "grdNhanVien";
            this.grdNhanVien.Size = new System.Drawing.Size(922, 653);
            this.grdNhanVien.TabIndex = 0;
            this.grdNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.grdNhanVien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdNhanVien_MouseDown);
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
            this.ma_nhanvien,
            this.ho_ten,
            this.ngay_sinh,
            this.gioi_tinh,
            this.cmtnd,
            this.que_quan,
            this.so_dien_thoai,
            this.email,
            this.ngay_bd_lv,
            this.trang_thai,
            this.ghi_chu,
            this.anh});
            this.gridView.DetailHeight = 284;
            this.gridView.GridControl = this.grdNhanVien;
            this.gridView.Name = "gridView";
            // 
            // ma_nhanvien
            // 
            this.ma_nhanvien.Caption = "Mã Nhân Viên";
            this.ma_nhanvien.FieldName = "ma_nhanvien";
            this.ma_nhanvien.MinWidth = 19;
            this.ma_nhanvien.Name = "ma_nhanvien";
            this.ma_nhanvien.Visible = true;
            this.ma_nhanvien.VisibleIndex = 0;
            this.ma_nhanvien.Width = 70;
            // 
            // ho_ten
            // 
            this.ho_ten.Caption = "Họ Tên";
            this.ho_ten.FieldName = "ho_ten";
            this.ho_ten.MinWidth = 19;
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.Visible = true;
            this.ho_ten.VisibleIndex = 1;
            this.ho_ten.Width = 70;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.Caption = "Ngày Sinh";
            this.ngay_sinh.FieldName = "ngay_sinh";
            this.ngay_sinh.MinWidth = 19;
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.Visible = true;
            this.ngay_sinh.VisibleIndex = 2;
            this.ngay_sinh.Width = 70;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.Caption = "Giới Tính";
            this.gioi_tinh.FieldName = "gioi_tinh";
            this.gioi_tinh.MinWidth = 19;
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.Visible = true;
            this.gioi_tinh.VisibleIndex = 3;
            this.gioi_tinh.Width = 70;
            // 
            // cmtnd
            // 
            this.cmtnd.Caption = "Thẻ Căn Cước";
            this.cmtnd.FieldName = "cmtnd";
            this.cmtnd.MinWidth = 19;
            this.cmtnd.Name = "cmtnd";
            this.cmtnd.Visible = true;
            this.cmtnd.VisibleIndex = 4;
            this.cmtnd.Width = 70;
            // 
            // que_quan
            // 
            this.que_quan.Caption = "Quê Quán";
            this.que_quan.FieldName = "que_quan";
            this.que_quan.MinWidth = 19;
            this.que_quan.Name = "que_quan";
            this.que_quan.Visible = true;
            this.que_quan.VisibleIndex = 5;
            this.que_quan.Width = 70;
            // 
            // so_dien_thoai
            // 
            this.so_dien_thoai.Caption = "Số Điện Thoại";
            this.so_dien_thoai.FieldName = "so_dien_thoai";
            this.so_dien_thoai.MinWidth = 19;
            this.so_dien_thoai.Name = "so_dien_thoai";
            this.so_dien_thoai.Visible = true;
            this.so_dien_thoai.VisibleIndex = 6;
            this.so_dien_thoai.Width = 70;
            // 
            // email
            // 
            this.email.Caption = "Email";
            this.email.FieldName = "email";
            this.email.MinWidth = 19;
            this.email.Name = "email";
            this.email.Visible = true;
            this.email.VisibleIndex = 7;
            this.email.Width = 70;
            // 
            // ngay_bd_lv
            // 
            this.ngay_bd_lv.Caption = "Ngày Làm Việc";
            this.ngay_bd_lv.FieldName = "ngay_bd_lv";
            this.ngay_bd_lv.MinWidth = 19;
            this.ngay_bd_lv.Name = "ngay_bd_lv";
            this.ngay_bd_lv.Visible = true;
            this.ngay_bd_lv.VisibleIndex = 8;
            this.ngay_bd_lv.Width = 70;
            // 
            // trang_thai
            // 
            this.trang_thai.Caption = "Trạng Thái";
            this.trang_thai.FieldName = "trang_thai";
            this.trang_thai.MinWidth = 19;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Visible = true;
            this.trang_thai.VisibleIndex = 9;
            this.trang_thai.Width = 70;
            // 
            // ghi_chu
            // 
            this.ghi_chu.Caption = "Ghi Chú";
            this.ghi_chu.FieldName = "ghi_chu";
            this.ghi_chu.MinWidth = 19;
            this.ghi_chu.Name = "ghi_chu";
            this.ghi_chu.Visible = true;
            this.ghi_chu.VisibleIndex = 10;
            this.ghi_chu.Width = 70;
            // 
            // anh
            // 
            this.anh.Caption = "Ảnh";
            this.anh.FieldName = "anh";
            this.anh.MinWidth = 19;
            this.anh.Name = "anh";
            this.anh.Visible = true;
            this.anh.VisibleIndex = 11;
            this.anh.Width = 70;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.btnEmail);
            this.groupControl2.Controls.Add(this.bunifuImageButton3);
            this.groupControl2.Controls.Add(this.bunifuImageButton2);
            this.groupControl2.Controls.Add(this.bunifuImageButton1);
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.lblCMTND);
            this.groupControl2.Controls.Add(this.lblQueQuan);
            this.groupControl2.Controls.Add(this.lblQuocTich);
            this.groupControl2.Controls.Add(this.lblNgayLV);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.lblGioiTinh);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.lblNgaySinh);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.lblMaNV);
            this.groupControl2.Controls.Add(this.lbMa);
            this.groupControl2.Controls.Add(this.lblName);
            this.groupControl2.Controls.Add(this.picAnh);
            this.groupControl2.Location = new System.Drawing.Point(2, 29);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(272, 675);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Thông tin chi tiết";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageActive = null;
            this.btnEmail.Location = new System.Drawing.Point(236, 157);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(25, 27);
            this.btnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmail.TabIndex = 19;
            this.btnEmail.TabStop = false;
            this.btnEmail.Zoom = 10;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(202, 157);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(25, 27);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 19;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(167, 157);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 19;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(132, 157);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblBanGhi);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 483);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(272, 194);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liên hệ";
            // 
            // lblBanGhi
            // 
            this.lblBanGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBanGhi.AutoSize = true;
            this.lblBanGhi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanGhi.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblBanGhi.Location = new System.Drawing.Point(146, 167);
            this.lblBanGhi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBanGhi.Name = "lblBanGhi";
            this.lblBanGhi.Size = new System.Drawing.Size(73, 19);
            this.lblBanGhi.TabIndex = 11;
            this.lblBanGhi.Text = "7 bản ghi";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(16, 167);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 19);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Tổng số:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTrangThai.Location = new System.Drawing.Point(146, 123);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(72, 17);
            this.lblTrangThai.TabIndex = 1;
            this.lblTrangThai.Text = "Hoạt động";
            // 
            // lblSDT
            // 
            this.lblSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSDT.Location = new System.Drawing.Point(146, 40);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 17);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "0947417910";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trạng Thái:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblEmail.Location = new System.Drawing.Point(92, 80);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(179, 24);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "nguyenanh@gmail.com";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(16, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Điện thoại:";
            // 
            // lblCMTND
            // 
            this.lblCMTND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCMTND.AutoSize = true;
            this.lblCMTND.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMTND.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblCMTND.Location = new System.Drawing.Point(148, 302);
            this.lblCMTND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMTND.Name = "lblCMTND";
            this.lblCMTND.Size = new System.Drawing.Size(104, 17);
            this.lblCMTND.TabIndex = 3;
            this.lblCMTND.Text = "036099009515";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueQuan.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblQueQuan.Location = new System.Drawing.Point(148, 348);
            this.lblQueQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(70, 17);
            this.lblQueQuan.TabIndex = 4;
            this.lblQueQuan.Text = "Nam Định";
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuocTich.AutoSize = true;
            this.lblQuocTich.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuocTich.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblQuocTich.Location = new System.Drawing.Point(148, 393);
            this.lblQuocTich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(65, 17);
            this.lblQuocTich.TabIndex = 5;
            this.lblQuocTich.Text = "Việt Nam";
            // 
            // lblNgayLV
            // 
            this.lblNgayLV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayLV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLV.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNgayLV.Location = new System.Drawing.Point(148, 439);
            this.lblNgayLV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLV.Name = "lblNgayLV";
            this.lblNgayLV.Size = new System.Drawing.Size(70, 18);
            this.lblNgayLV.TabIndex = 6;
            this.lblNgayLV.Text = "7/7/2016";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 437);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Ngày làm việc:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblGioiTinh.Location = new System.Drawing.Point(149, 257);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(27, 17);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Nữ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quê Quán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quốc Tịch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "CMTND:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giới Tính:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgaySinh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNgaySinh.Location = new System.Drawing.Point(149, 211);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(87, 18);
            this.lblNgaySinh.TabIndex = 13;
            this.lblNgaySinh.Text = "07/07/1999";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày Sinh:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(128, 126);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(77, 17);
            this.lblMaNV.TabIndex = 15;
            this.lblMaNV.Text = "68DCHT23";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMa.Location = new System.Drawing.Point(128, 102);
            this.lbMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(93, 19);
            this.lbMa.TabIndex = 16;
            this.lbMa.Text = "Mã nhân viên:";
            this.lbMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(126, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 56);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Nguyễn Thị \r\nÁnh";
            // 
            // picAnh
            // 
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.Location = new System.Drawing.Point(8, 32);
            this.picAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(113, 159);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 2;
            this.picAnh.TabStop = false;
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(1207, 707);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraGrid.GridControl grdNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn ma_nhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn ho_ten;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_sinh;
        private DevExpress.XtraGrid.Columns.GridColumn gioi_tinh;
        private DevExpress.XtraGrid.Columns.GridColumn cmtnd;
        private DevExpress.XtraGrid.Columns.GridColumn que_quan;
        private DevExpress.XtraGrid.Columns.GridColumn so_dien_thoai;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_bd_lv;
        private DevExpress.XtraGrid.Columns.GridColumn trang_thai;
        private DevExpress.XtraGrid.Columns.GridColumn ghi_chu;
        private DevExpress.XtraGrid.Columns.GridColumn anh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Bunifu.Framework.UI.BunifuImageButton btnEmail;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCMTND;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.Label lblNgayLV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label lblBanGhi;
        private System.Windows.Forms.Label lbl1;
    }
}
