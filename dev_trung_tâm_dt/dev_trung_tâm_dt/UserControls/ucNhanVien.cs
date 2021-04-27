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
    public partial class ucNhanVien : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public static string strError = "";
        public static string Status = "";
        string State;
        DataSet ds;
        public ucNhanVien()
        {
            InitializeComponent();
            LoadData();
        }               

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }    
            string query = "select * from nhan_vien";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdNhanVien.DataSource = ds.Tables[0];
                lblBanGhi.Text = ds.Tables[0].Rows.Count.ToString() + " Bản ghi";

                lblName.Text = ds.Tables[0].Rows[0]["ho_ten"].ToString();
                lblMaNV.Text = ds.Tables[0].Rows[0]["ma_nhanvien"].ToString();
                lblGioiTinh.Text = ds.Tables[0].Rows[0]["gioi_tinh"].ToString();
                lblNgaySinh.Text = ds.Tables[0].Rows[0]["ngay_sinh"].ToString();
                lblCMTND.Text = ds.Tables[0].Rows[0]["cmtnd"].ToString();
                lblQueQuan.Text = ds.Tables[0].Rows[0]["que_quan"].ToString();
                lblNgayLV.Text = ds.Tables[0].Rows[0]["ngay_bd_lv"].ToString();
                lblSDT.Text = ds.Tables[0].Rows[0]["so_dien_thoai"].ToString();
                lblEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                if(ds.Tables[0].Rows[0]["trang_thai"].ToString() == "1")
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
                grdNhanVien.DataSource = null;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            State = "them";
            frmThemNhanVien ThemNhanVien = new frmThemNhanVien(State);
            ThemNhanVien.Show();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            State = "sua";
            frmThemNhanVien themNV = new frmThemNhanVien(State);
            themNV.txtMaNV.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ma_nhanvien").ToString();
            themNV.cboChucVu.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ma_chucvu").ToString();
            themNV.txtHoTen.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ho_ten").ToString();
            themNV.dtpNgaySinh.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ngay_sinh").ToString();
            if(this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "gioi_tinh").ToString() == "Nam")
            {
                themNV.rdoNam.Checked = true;
                themNV.rdoNu.Checked = false;
            }    
            else if(this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "gioi_tinh").ToString() == "Nữ")
            {
                themNV.rdoNu.Checked = true;
                themNV.rdoNam.Checked = false;
            }    
            themNV.txtCMTND.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "cmtnd").ToString();
            themNV.txtQueQuan.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "que_quan").ToString();
            themNV.txtSDT.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "so_dien_thoai").ToString();
            themNV.txtEmail.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "email").ToString();
            themNV.dtpNgayLV.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ngay_bd_lv").ToString();
            themNV.txtGhiChu.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "ghi_chu").ToString();
            themNV.cboTrangThai.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "trang_thai").ToString();
            themNV.txtDuongDan.Text = this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "anh").ToString();
            themNV.picAnh.Image = Image.FromFile(this.gridView.GetRowCellValue(gridView.FocusedRowHandle, "anh").ToString());

            themNV.Show();
            themNV.txtMaNV.Enabled = false;
            themNV.txtDuongDan.Enabled = false;
            themNV.cboTrangThai.Enabled = true;
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void grdNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                lblMaNV.Text = gridView.GetRowCellValue(row, "ma_nhanvien").ToString();
                lblName.Text = gridView.GetRowCellValue(row, "ho_ten").ToString();
                lblNgaySinh.Text = gridView.GetRowCellValue(row, "ngay_sinh").ToString();
                lblGioiTinh.Text = gridView.GetRowCellValue(row, "gioi_tinh").ToString();
                lblCMTND.Text = gridView.GetRowCellValue(row, "cmtnd").ToString();
                lblQueQuan.Text = gridView.GetRowCellValue(row, "que_quan").ToString();
                lblNgayLV.Text = gridView.GetRowCellValue(row, "ngay_bd_lv").ToString();
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên '"+ lblName.Text.Trim() +"' không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "Delete nhan_vien where ma_nhanvien = '" + lblMaNV.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên '" + lblName.Text.Trim() + "' thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }   
                catch
                {
                    MessageBox.Show("Xóa nhân viên '" + lblName.Text.Trim() + "' không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
