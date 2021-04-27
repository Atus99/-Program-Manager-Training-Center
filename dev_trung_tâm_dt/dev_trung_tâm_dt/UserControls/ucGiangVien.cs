using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;

namespace dev_trung_tâm_dt.UserControls
{
    public partial class ucGiangVien : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public static string strError = "";
        public static string Status = "";
        DataSet ds;
        public ucGiangVien()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from giang_vien";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdGiangVien.DataSource = ds.Tables[0];

                lblName.Text = ds.Tables[0].Rows[0]["ho_ten"].ToString();
                lblGioiTinh.Text = ds.Tables[0].Rows[0]["gioi_tinh"].ToString();
                lblNgaySinh.Text = ds.Tables[0].Rows[0]["ngay_sinh"].ToString();
                lblCMTND.Text = ds.Tables[0].Rows[0]["cmtnd"].ToString();
                lblQueQuan.Text = ds.Tables[0].Rows[0]["que_quan"].ToString();
                lblNgayLV.Text = ds.Tables[0].Rows[0]["ngay_bat_dau_lv"].ToString();
                lblSDT.Text = ds.Tables[0].Rows[0]["so_dien_thoai"].ToString();
                lblEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                lblTrangThai.Text = ds.Tables[0].Rows[0]["trang_thai"].ToString();
                picAnh.Image = Image.FromFile(ds.Tables[0].Rows[0]["anh"].ToString());
            }
            else
            {
                grdGiangVien.DataSource = null;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemGiangVien ThemGiangVien = new frmThemGiangVien();
            ThemGiangVien.Show();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void grdGiangVien_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                lblName.Text = gridView.GetRowCellValue(row, "ho_ten").ToString();
                lblNgaySinh.Text = gridView.GetRowCellValue(row, "ngay_sinh").ToString();
                lblGioiTinh.Text = gridView.GetRowCellValue(row, "gioi_tinh").ToString();
                lblCMTND.Text = gridView.GetRowCellValue(row, "cmtnd").ToString();
                lblQueQuan.Text = gridView.GetRowCellValue(row, "que_quan").ToString();
                lblNgayLV.Text = gridView.GetRowCellValue(row, "ngay_bat_dau_lv").ToString();
                lblSDT.Text = gridView.GetRowCellValue(row, "so_dien_thoai").ToString();
                lblEmail.Text = gridView.GetRowCellValue(row, "email").ToString();
                lblTrangThai.Text = gridView.GetRowCellValue(row, "trang_thai").ToString();
                picAnh.Image = Image.FromFile(gridView.GetRowCellValue(row, "anh").ToString());
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
