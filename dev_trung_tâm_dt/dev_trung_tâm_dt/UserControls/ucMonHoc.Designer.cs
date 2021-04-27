namespace dev_trung_tâm_dt.UserControls
{
    partial class ucMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtYeuCau = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.txtSoBuoi = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_monhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_monhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.so_buoihoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thoi_gian_buoihoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoc_phi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mo_ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yeu_cau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghi_chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBanGhi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonHoc)).BeginInit();
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
            this.btnHuyBo});
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1316, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 772);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1316, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 742);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1316, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 742);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cboTrangThai);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtMoTa);
            this.groupControl1.Controls.Add(this.txtYeuCau);
            this.groupControl1.Controls.Add(this.txtHocPhi);
            this.groupControl1.Controls.Add(this.txtThoiGian);
            this.groupControl1.Controls.Add(this.txtSoBuoi);
            this.groupControl1.Controls.Add(this.txtTenMH);
            this.groupControl1.Controls.Add(this.txtMaMH);
            this.groupControl1.Location = new System.Drawing.Point(4, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1309, 348);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboTrangThai.Location = new System.Drawing.Point(1021, 104);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(83, 28);
            this.cboTrangThai.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(920, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Trạng thái:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(163, 257);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1127, 85);
            this.txtGhiChu.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(869, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(426, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(1110, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(869, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(426, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mô tả:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 3;
            this.label14.Text = "Yêu cầu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Học phí:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thời gian (phút):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(920, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số buổi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã môn học:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(163, 158);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(941, 28);
            this.txtMoTa.TabIndex = 7;
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCau.Location = new System.Drawing.Point(163, 208);
            this.txtYeuCau.Multiline = true;
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(1127, 28);
            this.txtYeuCau.TabIndex = 8;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhi.Location = new System.Drawing.Point(606, 105);
            this.txtHocPhi.Multiline = true;
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(260, 28);
            this.txtHocPhi.TabIndex = 5;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(163, 104);
            this.txtThoiGian.Multiline = true;
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(260, 28);
            this.txtThoiGian.TabIndex = 4;
            // 
            // txtSoBuoi
            // 
            this.txtSoBuoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBuoi.Location = new System.Drawing.Point(1021, 47);
            this.txtSoBuoi.Multiline = true;
            this.txtSoBuoi.Name = "txtSoBuoi";
            this.txtSoBuoi.Size = new System.Drawing.Size(83, 28);
            this.txtSoBuoi.TabIndex = 3;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Location = new System.Drawing.Point(606, 49);
            this.txtTenMH.Multiline = true;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(260, 28);
            this.txtTenMH.TabIndex = 2;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(163, 47);
            this.txtMaMH.Multiline = true;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(260, 28);
            this.txtMaMH.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.grdMonHoc);
            this.groupControl2.Controls.Add(this.lblBanGhi);
            this.groupControl2.Location = new System.Drawing.Point(4, 391);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1309, 378);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh sách môn học";
            // 
            // grdMonHoc
            // 
            this.grdMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMonHoc.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdMonHoc.Location = new System.Drawing.Point(5, 56);
            this.grdMonHoc.MainView = this.gridView1;
            this.grdMonHoc.MenuManager = this.barManager1;
            this.grdMonHoc.Name = "grdMonHoc";
            this.grdMonHoc.Size = new System.Drawing.Size(1299, 317);
            this.grdMonHoc.TabIndex = 9;
            this.grdMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdMonHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdMonHoc_MouseDown);
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
            this.ma_monhoc,
            this.ten_monhoc,
            this.so_buoihoc,
            this.thoi_gian_buoihoc,
            this.hoc_phi,
            this.mo_ta,
            this.yeu_cau,
            this.ghi_chu,
            this.trang_thai});
            this.gridView1.GridControl = this.grdMonHoc;
            this.gridView1.Name = "gridView1";
            // 
            // ma_monhoc
            // 
            this.ma_monhoc.Caption = "Mã môn học";
            this.ma_monhoc.FieldName = "ma_monhoc";
            this.ma_monhoc.MinWidth = 25;
            this.ma_monhoc.Name = "ma_monhoc";
            this.ma_monhoc.Visible = true;
            this.ma_monhoc.VisibleIndex = 0;
            this.ma_monhoc.Width = 94;
            // 
            // ten_monhoc
            // 
            this.ten_monhoc.Caption = "Tên môn học";
            this.ten_monhoc.FieldName = "ten_monhoc";
            this.ten_monhoc.MinWidth = 25;
            this.ten_monhoc.Name = "ten_monhoc";
            this.ten_monhoc.Visible = true;
            this.ten_monhoc.VisibleIndex = 1;
            this.ten_monhoc.Width = 94;
            // 
            // so_buoihoc
            // 
            this.so_buoihoc.Caption = "Số buổi học";
            this.so_buoihoc.FieldName = "so_buoihoc";
            this.so_buoihoc.MinWidth = 25;
            this.so_buoihoc.Name = "so_buoihoc";
            this.so_buoihoc.Visible = true;
            this.so_buoihoc.VisibleIndex = 2;
            this.so_buoihoc.Width = 94;
            // 
            // thoi_gian_buoihoc
            // 
            this.thoi_gian_buoihoc.Caption = "Thời gian buổi học";
            this.thoi_gian_buoihoc.FieldName = "thoi_gian_buoihoc";
            this.thoi_gian_buoihoc.MinWidth = 25;
            this.thoi_gian_buoihoc.Name = "thoi_gian_buoihoc";
            this.thoi_gian_buoihoc.Visible = true;
            this.thoi_gian_buoihoc.VisibleIndex = 3;
            this.thoi_gian_buoihoc.Width = 94;
            // 
            // hoc_phi
            // 
            this.hoc_phi.Caption = "Học phí";
            this.hoc_phi.FieldName = "hoc_phi";
            this.hoc_phi.MinWidth = 25;
            this.hoc_phi.Name = "hoc_phi";
            this.hoc_phi.Visible = true;
            this.hoc_phi.VisibleIndex = 4;
            this.hoc_phi.Width = 94;
            // 
            // mo_ta
            // 
            this.mo_ta.Caption = "Mô tả";
            this.mo_ta.FieldName = "mo_ta";
            this.mo_ta.MinWidth = 25;
            this.mo_ta.Name = "mo_ta";
            this.mo_ta.Visible = true;
            this.mo_ta.VisibleIndex = 5;
            this.mo_ta.Width = 94;
            // 
            // yeu_cau
            // 
            this.yeu_cau.Caption = "Yêu cầu";
            this.yeu_cau.FieldName = "yeu_cau";
            this.yeu_cau.MinWidth = 25;
            this.yeu_cau.Name = "yeu_cau";
            this.yeu_cau.Visible = true;
            this.yeu_cau.VisibleIndex = 6;
            this.yeu_cau.Width = 94;
            // 
            // ghi_chu
            // 
            this.ghi_chu.Caption = "Ghi chú";
            this.ghi_chu.FieldName = "ghi_chu";
            this.ghi_chu.MinWidth = 25;
            this.ghi_chu.Name = "ghi_chu";
            this.ghi_chu.Visible = true;
            this.ghi_chu.VisibleIndex = 7;
            this.ghi_chu.Width = 94;
            // 
            // trang_thai
            // 
            this.trang_thai.Caption = "Trạng thái";
            this.trang_thai.FieldName = "trang_thai";
            this.trang_thai.MinWidth = 25;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Visible = true;
            this.trang_thai.VisibleIndex = 8;
            this.trang_thai.Width = 94;
            // 
            // lblBanGhi
            // 
            this.lblBanGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBanGhi.AutoSize = true;
            this.lblBanGhi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanGhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBanGhi.Location = new System.Drawing.Point(1112, 30);
            this.lblBanGhi.Name = "lblBanGhi";
            this.lblBanGhi.Size = new System.Drawing.Size(167, 23);
            this.lblBanGhi.TabIndex = 2;
            this.lblBanGhi.Text = "Tổng số : 7 bản ghi";
            // 
            // ucMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucMonHoc";
            this.Size = new System.Drawing.Size(1316, 772);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonHoc)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.TextBox txtSoBuoi;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtYeuCau;
        private DevExpress.XtraGrid.GridControl grdMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ma_monhoc;
        private DevExpress.XtraGrid.Columns.GridColumn ten_monhoc;
        private DevExpress.XtraGrid.Columns.GridColumn so_buoihoc;
        private DevExpress.XtraGrid.Columns.GridColumn thoi_gian_buoihoc;
        private DevExpress.XtraGrid.Columns.GridColumn hoc_phi;
        private DevExpress.XtraGrid.Columns.GridColumn mo_ta;
        private DevExpress.XtraGrid.Columns.GridColumn yeu_cau;
        private DevExpress.XtraGrid.Columns.GridColumn ghi_chu;
        private DevExpress.XtraGrid.Columns.GridColumn trang_thai;
        private System.Windows.Forms.Label lblBanGhi;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
    }
}
