namespace dev_trung_tâm_dt.UserControls
{
    partial class ucPhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhanLop));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPhanLop = new System.Windows.Forms.Button();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdHocVien = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_hocvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ho_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ma_monhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_monhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay_dangky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thu_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thu_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thu_4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thu_5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thu_6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thu_7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chu_nhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.btnPhanLop);
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cboLopHoc);
            this.groupControl1.Controls.Add(this.cboMaMH);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 741);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanLop.Location = new System.Drawing.Point(10, 235);
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.Size = new System.Drawing.Size(307, 49);
            this.btnPhanLop.TabIndex = 17;
            this.btnPhanLop.Text = "Phân Lớp";
            this.btnPhanLop.UseVisualStyleBackColor = true;
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageActive = null;
            this.btnTimKiem.Location = new System.Drawing.Point(231, 162);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(30, 31);
            this.btnTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Zoom = 10;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chọn lớp học:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Môn học:";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(10, 160);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(215, 31);
            this.cboLopHoc.TabIndex = 1;
            // 
            // cboMaMH
            // 
            this.cboMaMH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(10, 82);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(307, 31);
            this.cboMaMH.TabIndex = 0;
            this.cboMaMH.SelectedIndexChanged += new System.EventHandler(this.cboMaMH_SelectedIndexChanged);
            this.cboMaMH.SelectionChangeCommitted += new System.EventHandler(this.cboMaMH_SelectionChangeCommitted);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.grdHocVien);
            this.groupControl2.Location = new System.Drawing.Point(336, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1000, 741);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin chi tiết";
            // 
            // grdHocVien
            // 
            this.grdHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHocVien.Location = new System.Drawing.Point(2, 28);
            this.grdHocVien.MainView = this.gridView;
            this.grdHocVien.Name = "grdHocVien";
            this.grdHocVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.grdHocVien.Size = new System.Drawing.Size(996, 711);
            this.grdHocVien.TabIndex = 1;
            this.grdHocVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
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
            this.ho_ten,
            this.ma_monhoc,
            this.ten_monhoc,
            this.ngay_dangky,
            this.thu_2,
            this.thu_3,
            this.thu_4,
            this.thu_5,
            this.thu_6,
            this.thu_7,
            this.chu_nhat});
            this.gridView.GridControl = this.grdHocVien;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // ma_hocvien
            // 
            this.ma_hocvien.Caption = "Mã học viên";
            this.ma_hocvien.FieldName = "ma_hocvien";
            this.ma_hocvien.MinWidth = 25;
            this.ma_hocvien.Name = "ma_hocvien";
            this.ma_hocvien.Visible = true;
            this.ma_hocvien.VisibleIndex = 1;
            this.ma_hocvien.Width = 74;
            // 
            // ho_ten
            // 
            this.ho_ten.Caption = "Họ tên";
            this.ho_ten.FieldName = "ho_ten";
            this.ho_ten.MinWidth = 25;
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.Visible = true;
            this.ho_ten.VisibleIndex = 2;
            this.ho_ten.Width = 74;
            // 
            // ma_monhoc
            // 
            this.ma_monhoc.Caption = "Mã môn học";
            this.ma_monhoc.FieldName = "ma_monhoc";
            this.ma_monhoc.MinWidth = 25;
            this.ma_monhoc.Name = "ma_monhoc";
            this.ma_monhoc.Visible = true;
            this.ma_monhoc.VisibleIndex = 3;
            this.ma_monhoc.Width = 74;
            // 
            // ten_monhoc
            // 
            this.ten_monhoc.Caption = "Tên môn học";
            this.ten_monhoc.FieldName = "ten_monhoc";
            this.ten_monhoc.MinWidth = 25;
            this.ten_monhoc.Name = "ten_monhoc";
            this.ten_monhoc.Visible = true;
            this.ten_monhoc.VisibleIndex = 4;
            this.ten_monhoc.Width = 74;
            // 
            // ngay_dangky
            // 
            this.ngay_dangky.Caption = "Ngày đăng ký";
            this.ngay_dangky.FieldName = "ngay_dangky";
            this.ngay_dangky.MinWidth = 25;
            this.ngay_dangky.Name = "ngay_dangky";
            this.ngay_dangky.Visible = true;
            this.ngay_dangky.VisibleIndex = 5;
            this.ngay_dangky.Width = 74;
            // 
            // thu_2
            // 
            this.thu_2.AppearanceCell.Options.UseTextOptions = true;
            this.thu_2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_2.AppearanceHeader.Options.UseTextOptions = true;
            this.thu_2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_2.Caption = "Thứ 2";
            this.thu_2.FieldName = "thu_2";
            this.thu_2.MinWidth = 25;
            this.thu_2.Name = "thu_2";
            this.thu_2.Visible = true;
            this.thu_2.VisibleIndex = 6;
            this.thu_2.Width = 74;
            // 
            // thu_3
            // 
            this.thu_3.AppearanceCell.Options.UseTextOptions = true;
            this.thu_3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_3.AppearanceHeader.Options.UseTextOptions = true;
            this.thu_3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_3.Caption = "Thứ 3";
            this.thu_3.FieldName = "thu_3";
            this.thu_3.MinWidth = 25;
            this.thu_3.Name = "thu_3";
            this.thu_3.Visible = true;
            this.thu_3.VisibleIndex = 7;
            this.thu_3.Width = 74;
            // 
            // thu_4
            // 
            this.thu_4.AppearanceCell.Options.UseTextOptions = true;
            this.thu_4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_4.AppearanceHeader.Options.UseTextOptions = true;
            this.thu_4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_4.Caption = "Thứ 4";
            this.thu_4.FieldName = "thu_4";
            this.thu_4.MinWidth = 25;
            this.thu_4.Name = "thu_4";
            this.thu_4.Visible = true;
            this.thu_4.VisibleIndex = 8;
            this.thu_4.Width = 74;
            // 
            // thu_5
            // 
            this.thu_5.AppearanceCell.Options.UseTextOptions = true;
            this.thu_5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_5.AppearanceHeader.Options.UseTextOptions = true;
            this.thu_5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_5.Caption = "Thứ 5";
            this.thu_5.FieldName = "thu_5";
            this.thu_5.MinWidth = 25;
            this.thu_5.Name = "thu_5";
            this.thu_5.Visible = true;
            this.thu_5.VisibleIndex = 9;
            this.thu_5.Width = 74;
            // 
            // thu_6
            // 
            this.thu_6.AppearanceCell.Options.UseTextOptions = true;
            this.thu_6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_6.AppearanceHeader.Options.UseTextOptions = true;
            this.thu_6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_6.Caption = "Thứ 6";
            this.thu_6.FieldName = "thu_6";
            this.thu_6.MinWidth = 25;
            this.thu_6.Name = "thu_6";
            this.thu_6.Visible = true;
            this.thu_6.VisibleIndex = 10;
            this.thu_6.Width = 74;
            // 
            // thu_7
            // 
            this.thu_7.AppearanceCell.Options.UseTextOptions = true;
            this.thu_7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_7.AppearanceHeader.Options.UseTextOptions = true;
            this.thu_7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thu_7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thu_7.Caption = "Thứ 7";
            this.thu_7.FieldName = "thu_7";
            this.thu_7.MinWidth = 25;
            this.thu_7.Name = "thu_7";
            this.thu_7.Visible = true;
            this.thu_7.VisibleIndex = 11;
            this.thu_7.Width = 74;
            // 
            // chu_nhat
            // 
            this.chu_nhat.AppearanceCell.Options.UseTextOptions = true;
            this.chu_nhat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chu_nhat.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.chu_nhat.AppearanceHeader.Options.UseTextOptions = true;
            this.chu_nhat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chu_nhat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.chu_nhat.Caption = "Chủ nhật";
            this.chu_nhat.FieldName = "chu_nhat";
            this.chu_nhat.MinWidth = 25;
            this.chu_nhat.Name = "chu_nhat";
            this.chu_nhat.Visible = true;
            this.chu_nhat.VisibleIndex = 12;
            this.chu_nhat.Width = 79;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemHyperLinkEdit1.Image")));
            this.repositoryItemHyperLinkEdit1.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // ucPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucPhanLop";
            this.Size = new System.Drawing.Size(1339, 747);
            this.Load += new System.EventHandler(this.ucPhanLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn ma_hocvien;
        private DevExpress.XtraGrid.Columns.GridColumn ho_ten;
        private DevExpress.XtraGrid.Columns.GridColumn ten_monhoc;
        private DevExpress.XtraGrid.Columns.GridColumn thu_2;
        private DevExpress.XtraGrid.Columns.GridColumn thu_3;
        private DevExpress.XtraGrid.Columns.GridColumn thu_4;
        private DevExpress.XtraGrid.Columns.GridColumn thu_5;
        private DevExpress.XtraGrid.Columns.GridColumn thu_6;
        private DevExpress.XtraGrid.Columns.GridColumn thu_7;
        private DevExpress.XtraGrid.Columns.GridColumn chu_nhat;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ngay_dangky;
        private Bunifu.Framework.UI.BunifuImageButton btnTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn ma_monhoc;
        private System.Windows.Forms.Button btnPhanLop;
        public DevExpress.XtraGrid.GridControl grdHocVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
    }
}
