namespace dev_trung_tâm_dt.UserControls
{
    partial class ucHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHocPhi));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienDong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_hocvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ma_lophoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_monhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hinhthuc_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoc_phi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.da_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdDongHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_hocvien1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ma_lophoc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_monhoc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoc_phi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDongHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnHuyBo,
            this.barButtonItem6,
            this.btnRefresh});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
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
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi dữ liệu";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
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
            this.btnRefresh.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1492, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 814);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1492, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 784);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1492, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 784);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Refresh";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã học viên:";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHV.Location = new System.Drawing.Point(147, 49);
            this.txtMaHV.Multiline = true;
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(260, 28);
            this.txtMaHV.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(954, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiền đóng:";
            // 
            // txtTienDong
            // 
            this.txtTienDong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDong.Location = new System.Drawing.Point(1072, 48);
            this.txtTienDong.Multiline = true;
            this.txtTienDong.Name = "txtTienDong";
            this.txtTienDong.Size = new System.Drawing.Size(260, 82);
            this.txtTienDong.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hình thức:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(413, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(1338, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(885, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Chuyển khoản",
            "Tiền mặt"});
            this.cboHinhThuc.Location = new System.Drawing.Point(619, 48);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(260, 28);
            this.cboHinhThuc.TabIndex = 2;
            this.cboHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cboHinhThuc_SelectedIndexChanged);
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.cboHinhThuc);
            this.groupControl.Controls.Add(this.label9);
            this.groupControl.Controls.Add(this.label4);
            this.groupControl.Controls.Add(this.label7);
            this.groupControl.Controls.Add(this.label5);
            this.groupControl.Controls.Add(this.label10);
            this.groupControl.Controls.Add(this.label8);
            this.groupControl.Controls.Add(this.txtHocPhi);
            this.groupControl.Controls.Add(this.label3);
            this.groupControl.Controls.Add(this.txtMaLH);
            this.groupControl.Controls.Add(this.label6);
            this.groupControl.Controls.Add(this.txtTienDong);
            this.groupControl.Controls.Add(this.label2);
            this.groupControl.Controls.Add(this.txtMaHV);
            this.groupControl.Controls.Add(this.label1);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl.Location = new System.Drawing.Point(0, 30);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(1492, 155);
            this.groupControl.TabIndex = 4;
            this.groupControl.Text = "Thông tin học phí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(885, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(413, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhi.Location = new System.Drawing.Point(619, 102);
            this.txtHocPhi.Multiline = true;
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(260, 28);
            this.txtHocPhi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Học Phí:";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Location = new System.Drawing.Point(147, 102);
            this.txtMaLH.Multiline = true;
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(260, 28);
            this.txtMaLH.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã lớp học:";
            // 
            // grdHocPhi
            // 
            this.grdHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.grdHocPhi.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grdHocPhi.Location = new System.Drawing.Point(2, 28);
            this.grdHocPhi.MainView = this.gridView;
            this.grdHocPhi.MenuManager = this.barManager1;
            this.grdHocPhi.Name = "grdHocPhi";
            this.grdHocPhi.Size = new System.Drawing.Size(748, 593);
            this.grdHocPhi.TabIndex = 2;
            this.grdHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.grdHocPhi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdHocPhi_MouseDown);
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
            this.ma_hocvien,
            this.ma_lophoc,
            this.ten_monhoc,
            this.hinhthuc_dong,
            this.hoc_phi,
            this.da_dong,
            this.ngay_dong,
            this.trang_thai});
            this.gridView.GridControl = this.grdHocPhi;
            this.gridView.Name = "gridView";
            // 
            // ma_hocvien
            // 
            this.ma_hocvien.AppearanceCell.Options.UseTextOptions = true;
            this.ma_hocvien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_hocvien.AppearanceHeader.Options.UseTextOptions = true;
            this.ma_hocvien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_hocvien.Caption = "Mã học viên";
            this.ma_hocvien.FieldName = "ma_hocvien";
            this.ma_hocvien.MinWidth = 25;
            this.ma_hocvien.Name = "ma_hocvien";
            this.ma_hocvien.Visible = true;
            this.ma_hocvien.VisibleIndex = 0;
            this.ma_hocvien.Width = 94;
            // 
            // ma_lophoc
            // 
            this.ma_lophoc.AppearanceCell.Options.UseTextOptions = true;
            this.ma_lophoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_lophoc.AppearanceHeader.Options.UseTextOptions = true;
            this.ma_lophoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_lophoc.Caption = "Mã lớp ";
            this.ma_lophoc.FieldName = "ma_lophoc";
            this.ma_lophoc.MinWidth = 25;
            this.ma_lophoc.Name = "ma_lophoc";
            this.ma_lophoc.Visible = true;
            this.ma_lophoc.VisibleIndex = 1;
            this.ma_lophoc.Width = 94;
            // 
            // ten_monhoc
            // 
            this.ten_monhoc.AppearanceCell.Options.UseTextOptions = true;
            this.ten_monhoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ten_monhoc.AppearanceHeader.Options.UseTextOptions = true;
            this.ten_monhoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ten_monhoc.Caption = "Tên môn học";
            this.ten_monhoc.FieldName = "ten_monhoc";
            this.ten_monhoc.MinWidth = 25;
            this.ten_monhoc.Name = "ten_monhoc";
            this.ten_monhoc.Visible = true;
            this.ten_monhoc.VisibleIndex = 2;
            this.ten_monhoc.Width = 94;
            // 
            // hinhthuc_dong
            // 
            this.hinhthuc_dong.AppearanceCell.Options.UseTextOptions = true;
            this.hinhthuc_dong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hinhthuc_dong.AppearanceHeader.Options.UseTextOptions = true;
            this.hinhthuc_dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hinhthuc_dong.Caption = "Hình thức";
            this.hinhthuc_dong.FieldName = "hinhthuc_dong";
            this.hinhthuc_dong.MinWidth = 25;
            this.hinhthuc_dong.Name = "hinhthuc_dong";
            this.hinhthuc_dong.Visible = true;
            this.hinhthuc_dong.VisibleIndex = 3;
            this.hinhthuc_dong.Width = 94;
            // 
            // hoc_phi
            // 
            this.hoc_phi.AppearanceCell.Options.UseTextOptions = true;
            this.hoc_phi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hoc_phi.AppearanceHeader.Options.UseTextOptions = true;
            this.hoc_phi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hoc_phi.Caption = "Học phí";
            this.hoc_phi.FieldName = "hoc_phi";
            this.hoc_phi.MinWidth = 25;
            this.hoc_phi.Name = "hoc_phi";
            this.hoc_phi.Visible = true;
            this.hoc_phi.VisibleIndex = 4;
            this.hoc_phi.Width = 94;
            // 
            // da_dong
            // 
            this.da_dong.AppearanceCell.Options.UseTextOptions = true;
            this.da_dong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.da_dong.AppearanceHeader.Options.UseTextOptions = true;
            this.da_dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.da_dong.Caption = "Đã đóng";
            this.da_dong.FieldName = "da_dong";
            this.da_dong.MinWidth = 25;
            this.da_dong.Name = "da_dong";
            this.da_dong.Visible = true;
            this.da_dong.VisibleIndex = 5;
            this.da_dong.Width = 94;
            // 
            // ngay_dong
            // 
            this.ngay_dong.AppearanceCell.Options.UseTextOptions = true;
            this.ngay_dong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngay_dong.AppearanceHeader.Options.UseTextOptions = true;
            this.ngay_dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngay_dong.Caption = "Ngày Đóng";
            this.ngay_dong.FieldName = "ngay_dong";
            this.ngay_dong.MinWidth = 25;
            this.ngay_dong.Name = "ngay_dong";
            this.ngay_dong.Visible = true;
            this.ngay_dong.VisibleIndex = 6;
            this.ngay_dong.Width = 94;
            // 
            // trang_thai
            // 
            this.trang_thai.AppearanceCell.Options.UseTextOptions = true;
            this.trang_thai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trang_thai.AppearanceHeader.Options.UseTextOptions = true;
            this.trang_thai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trang_thai.Caption = "Trạng thái";
            this.trang_thai.FieldName = "trang_thai";
            this.trang_thai.MinWidth = 25;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Visible = true;
            this.trang_thai.VisibleIndex = 7;
            this.trang_thai.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.grdHocPhi);
            this.groupControl2.Location = new System.Drawing.Point(740, 191);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(752, 623);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh sách";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.grdDongHoc);
            this.groupControl1.Location = new System.Drawing.Point(0, 191);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(736, 623);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Danh sách đóng tiền";
            // 
            // grdDongHoc
            // 
            this.grdDongHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDongHoc.Location = new System.Drawing.Point(2, 28);
            this.grdDongHoc.MainView = this.gridView1;
            this.grdDongHoc.MenuManager = this.barManager1;
            this.grdDongHoc.Name = "grdDongHoc";
            this.grdDongHoc.Size = new System.Drawing.Size(732, 593);
            this.grdDongHoc.TabIndex = 11;
            this.grdDongHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdDongHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdDongHoc_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ma_hocvien1,
            this.ma_lophoc1,
            this.ten_monhoc1,
            this.hoc_phi1});
            this.gridView1.GridControl = this.grdDongHoc;
            this.gridView1.Name = "gridView1";
            // 
            // ma_hocvien1
            // 
            this.ma_hocvien1.AppearanceCell.Options.UseTextOptions = true;
            this.ma_hocvien1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_hocvien1.AppearanceHeader.Options.UseTextOptions = true;
            this.ma_hocvien1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_hocvien1.Caption = "Mã học viên";
            this.ma_hocvien1.FieldName = "ma_hocvien";
            this.ma_hocvien1.MinWidth = 25;
            this.ma_hocvien1.Name = "ma_hocvien1";
            this.ma_hocvien1.Visible = true;
            this.ma_hocvien1.VisibleIndex = 0;
            this.ma_hocvien1.Width = 94;
            // 
            // ma_lophoc1
            // 
            this.ma_lophoc1.AppearanceCell.Options.UseTextOptions = true;
            this.ma_lophoc1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_lophoc1.AppearanceHeader.Options.UseTextOptions = true;
            this.ma_lophoc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ma_lophoc1.Caption = "Mã lớp";
            this.ma_lophoc1.FieldName = "ma_lophoc";
            this.ma_lophoc1.MinWidth = 25;
            this.ma_lophoc1.Name = "ma_lophoc1";
            this.ma_lophoc1.Visible = true;
            this.ma_lophoc1.VisibleIndex = 1;
            this.ma_lophoc1.Width = 94;
            // 
            // ten_monhoc1
            // 
            this.ten_monhoc1.AppearanceCell.Options.UseTextOptions = true;
            this.ten_monhoc1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ten_monhoc1.AppearanceHeader.Options.UseTextOptions = true;
            this.ten_monhoc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ten_monhoc1.Caption = "Tên môn học";
            this.ten_monhoc1.FieldName = "ten_monhoc";
            this.ten_monhoc1.MinWidth = 25;
            this.ten_monhoc1.Name = "ten_monhoc1";
            this.ten_monhoc1.Visible = true;
            this.ten_monhoc1.VisibleIndex = 2;
            this.ten_monhoc1.Width = 94;
            // 
            // hoc_phi1
            // 
            this.hoc_phi1.AppearanceCell.Options.UseTextOptions = true;
            this.hoc_phi1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hoc_phi1.AppearanceHeader.Options.UseTextOptions = true;
            this.hoc_phi1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hoc_phi1.Caption = "Số tiền phải đóng";
            this.hoc_phi1.FieldName = "hoc_phi";
            this.hoc_phi1.MinWidth = 25;
            this.hoc_phi1.Name = "hoc_phi1";
            this.hoc_phi1.Visible = true;
            this.hoc_phi1.VisibleIndex = 3;
            this.hoc_phi1.Width = 94;
            // 
            // ucHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucHocPhi";
            this.Size = new System.Drawing.Size(1492, 814);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDongHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn ma_hocvien;
        private DevExpress.XtraGrid.Columns.GridColumn ma_lophoc;
        private DevExpress.XtraGrid.Columns.GridColumn ten_monhoc;
        private DevExpress.XtraGrid.Columns.GridColumn da_dong;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_dong;
        private DevExpress.XtraGrid.Columns.GridColumn trang_thai;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTienDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grdDongHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ma_hocvien1;
        private DevExpress.XtraGrid.Columns.GridColumn ma_lophoc1;
        private DevExpress.XtraGrid.Columns.GridColumn ten_monhoc1;
        private DevExpress.XtraGrid.Columns.GridColumn hoc_phi1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn hinhthuc_dong;
        private DevExpress.XtraGrid.Columns.GridColumn hoc_phi;
    }
}
