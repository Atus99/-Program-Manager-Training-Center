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
using System.Net.Mail;

namespace dev_trung_tâm_dt
{
    public partial class frmHocVien : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        string State;

        public frmHocVien()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from hoc_vien";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdHocVien.DataSource = ds.Tables[0];
                lblBanGhi.Text = ds.Tables[0].Rows.Count.ToString() + " bản ghi";

                lblName.Text = ds.Tables[0].Rows[0]["ho_ten"].ToString();
                lblMaHV.Text = ds.Tables[0].Rows[0]["ma_hocvien"].ToString();
                lblGioiTinh.Text = ds.Tables[0].Rows[0]["gioi_tinh"].ToString();
                lblNgaySinh.Text = ds.Tables[0].Rows[0]["ngay_sinh"].ToString();
                lblCMTND.Text = ds.Tables[0].Rows[0]["cmtnd"].ToString();
                lblQuocTich.Text = ds.Tables[0].Rows[0]["quoc_tich"].ToString();
                lblQueQuan.Text = ds.Tables[0].Rows[0]["que_quan"].ToString();
                lblNgayNH.Text = ds.Tables[0].Rows[0]["ngay_nhap_hoc"].ToString();
                lblSDT.Text = ds.Tables[0].Rows[0]["so_dien_thoai"].ToString();
                lblEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                if (ds.Tables[0].Rows[0]["trang_thai"].ToString() == "1")
                {
                    lblTrangThai.Text = "Hoạt động";
                }
                else
                {
                    lblTrangThai.Text = "Ngừng hoạt động";
                }
                picAnh.Image = Image.FromFile(ds.Tables[0].Rows[0]["anh"].ToString());
            }
            else
            {
                grdHocVien.DataSource = null;
            }
            conn.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            State = "them";
            frmThemHocVien themHV = new frmThemHocVien(State);
            themHV.Show();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            State = "sua";
            frmThemHocVien themHV = new frmThemHocVien(State);
            themHV.txtMaHV.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ma_hocvien").ToString();
            themHV.txtHoTen.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ho_ten").ToString();
            themHV.dtpNgaySinh.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ngay_sinh").ToString();
            if (this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "gioi_tinh").ToString() == "Nam")
            {
                themHV.rdoNam.Checked = true;
                themHV.rdoNu.Checked = false;
            }
            else if (this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "gioi_tinh").ToString() == "Nữ")
            {
                themHV.rdoNu.Checked = true;
                themHV.rdoNam.Checked = false;
            }
            themHV.txtCMTND.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "cmtnd").ToString();
            themHV.txtQuocTich.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "quoc_tich").ToString();
            themHV.txtQueQuan.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "que_quan").ToString();
            themHV.txtSDT.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "so_dien_thoai").ToString();
            themHV.txtEmail.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "email").ToString();
            themHV.dtpNgayNhapHoc.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ngay_nhap_hoc").ToString();
            themHV.cboTrangThai.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "trang_thai").ToString();
            themHV.txtGhiChu.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ghi_chu").ToString();
            themHV.txtDuongDan.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "anh").ToString();
            themHV.picAnh.Image = Image.FromFile(this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "anh").ToString());

            themHV.Show();
            themHV.txtMaHV.Enabled = false;
            themHV.txtDuongDan.Enabled = false;
            themHV.cboTrangThai.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa '"+ gridView.GetRowCellValue(gridView.FocusedRowHandle, "ho_ten") + "' không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from hoc_vien where ma_hocvien = '" + gridView.GetRowCellValue(gridView.FocusedRowHandle, "ma_hocvien") + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
            }    
            else
            {
                MessageBox.Show("Lỗi trong quá trình xóa dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void grdHocVien_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                lblMaHV.Text = gridView.GetRowCellValue(row, "ma_hocvien").ToString();
                lblName.Text = gridView.GetRowCellValue(row, "ho_ten").ToString();
                lblNgaySinh.Text = gridView.GetRowCellValue(row, "ngay_sinh").ToString();
                lblGioiTinh.Text = gridView.GetRowCellValue(row, "gioi_tinh").ToString();
                lblCMTND.Text = gridView.GetRowCellValue(row, "cmtnd").ToString();
                lblQuocTich.Text = gridView.GetRowCellValue(row, "quoc_tich").ToString();
                lblQueQuan.Text = gridView.GetRowCellValue(row, "que_quan").ToString();
                lblNgayNH.Text = gridView.GetRowCellValue(row, "ngay_nhap_hoc").ToString();
                lblSDT.Text = gridView.GetRowCellValue(row, "so_dien_thoai").ToString();
                lblEmail.Text = gridView.GetRowCellValue(row, "email").ToString();
                if (gridView.GetRowCellValue(row, "trang_thai").ToString() == "1")
                {
                    lblTrangThai.Text = "Hoạt động";
                }
                else
                {
                    lblTrangThai.Text = "Ngừng hoạt động";
                }
                picAnh.Image = Image.FromFile(gridView.GetRowCellValue(row, "anh").ToString());
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string email;
            email = lblEmail.Text;
            SendToMail mail = new SendToMail(email);
            mail.Show();
        }
    }
}
