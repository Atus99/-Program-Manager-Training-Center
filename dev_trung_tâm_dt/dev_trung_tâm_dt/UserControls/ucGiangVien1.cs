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
    public partial class ucTest : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public static string strError = "";
        public static string Status = "";
        string GioiTinh;
        DataSet ds;
        public ucTest()
        {
            InitializeComponent();
            SetControl("Reset");
            LoadData();
        }

        private void SetControl(string x)
        {
            switch (x)
            {
                case "Reset":

                    txtGhiChu.Enabled = false;
                    txtTen.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    rdoNam.Enabled = false;
                    rdoNu.Enabled = false;
                    txtCMTND.Enabled = false;
                    txtQueQuan.Enabled = false;
                    txtSDT.Enabled = false;
                    txtEmail.Enabled = false;
                    txtHocVan.Enabled = false;
                    dtpNgayLV.Enabled = false;
                    cboTrangThai.Enabled = false;
                    txtDuongDanAnh.Enabled = false;

                    txtTen.Text = "";
                    txtCMTND.Text = "";
                    txtQueQuan.Text = "";
                    txtSDT.Text = "";
                    txtEmail.Text = "";
                    txtHocVan.Text = "";
                    txtGhiChu.Text = "";
                    txtDuongDanAnh.Text = "";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;
                    btnPath.Enabled = false;

                    break;
                case "Insert":

                    txtGhiChu.Enabled = true;
                    txtTen.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    txtCMTND.Enabled = true;
                    txtQueQuan.Enabled = true;
                    txtSDT.Enabled = true;
                    txtEmail.Enabled = true;
                    txtHocVan.Enabled = true;
                    dtpNgayLV.Enabled = true;
                    cboTrangThai.Enabled = false;
                    txtDuongDanAnh.Enabled = false;
                    
                    txtTen.Text = "";
                    txtCMTND.Text = "";
                    txtQueQuan.Text = "";
                    txtSDT.Text = "";
                    txtEmail.Text = "";
                    txtHocVan.Text = "";
                    txtGhiChu.Text = "";
                    txtDuongDanAnh.Text = "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnPath.Enabled = true;

                    txtTen.Focus();
                    break;
                case "Update":

                    txtTen.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    txtCMTND.Enabled = true;
                    txtQueQuan.Enabled = true;
                    txtSDT.Enabled = true;
                    txtEmail.Enabled = true;
                    txtHocVan.Enabled = true;
                    dtpNgayLV.Enabled = true;
                    cboTrangThai.Enabled = true;
                    txtDuongDanAnh.Enabled = false;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnPath.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from giang_vien";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdGiangVien.DataSource = ds.Tables[0];

                txtTen.Text = ds.Tables[0].Rows[0]["ho_ten"].ToString();
                if(ds.Tables[0].Rows[0]["gioi_tinh"].ToString() == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }    
                else
                {
                    rdoNu.Checked = true;
                    rdoNam.Checked = false;
                }    
                dtpNgaySinh.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["ngay_sinh"].ToString());
                txtCMTND.Text = ds.Tables[0].Rows[0]["cmtnd"].ToString();
                txtQueQuan.Text = ds.Tables[0].Rows[0]["que_quan"].ToString();
                dtpNgayLV.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["ngay_bat_dau_lv"].ToString());
                txtSDT.Text = ds.Tables[0].Rows[0]["so_dien_thoai"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtHocVan.Text = ds.Tables[0].Rows[0]["hoc_van"].ToString();
                cboTrangThai.Text = ds.Tables[0].Rows[0]["trang_thai"].ToString();
                txtDuongDanAnh.Text = ds.Tables[0].Rows[0]["anh"].ToString();
                txtGhiChu.Text = ds.Tables[0].Rows[0]["ghi_chu"].ToString();
                picAnh.Image = Image.FromFile(ds.Tables[0].Rows[0]["anh"].ToString());
            }
            else
            {
                grdGiangVien.DataSource = null;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Insert";
            SetControl(Status);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Update";
            SetControl(Status);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên '"+ txtTen.Text.Trim() +"' không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from giang_vien where id_giangvien = '" + gridView.GetRowCellValue(gridView.FocusedRowHandle, "id_giangvien") + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }
        }

        private bool InsertData(ref string Error)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "insert_giangvien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ho_ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay_sinh", dtpNgaySinh.Value);
                if(rdoNam.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gioi_tinh", "Nam");
                }    
                else if(rdoNu.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gioi_tinh", "Nữ");
                }    
                
                cmd.Parameters.AddWithValue("@cmtnd", txtCMTND.Text.Trim());
                cmd.Parameters.AddWithValue("@que_quan", txtQueQuan.Text.Trim());
                cmd.Parameters.AddWithValue("@so_dien_thoai", txtSDT.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@hoc_van", txtHocVan.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay_bat_dau_lv", dtpNgayLV.Value);
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text);
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@anh", txtDuongDanAnh.Text.Trim());

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private bool UpdateData(ref string Error)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "update_giangvien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_giangvien", gridView.GetRowCellValue(gridView.FocusedRowHandle, "id_giangvien".ToString()));
                cmd.Parameters.AddWithValue("@ho_ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay_sinh", dtpNgaySinh.Value);
                if (rdoNam.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gioi_tinh", "Nam");
                }
                else if (rdoNu.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gioi_tinh", "Nữ");
                }

                cmd.Parameters.AddWithValue("@cmtnd", txtCMTND.Text.Trim());
                cmd.Parameters.AddWithValue("@que_quan", txtQueQuan.Text.Trim());
                cmd.Parameters.AddWithValue("@so_dien_thoai", txtSDT.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@hoc_van", txtHocVan.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay_bat_dau_lv", dtpNgayLV.Value);
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text);
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@anh", txtDuongDanAnh.Text.Trim());

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rdoNam.Checked == true)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(dtpNgaySinh.Text) || string.IsNullOrEmpty(txtQueQuan.Text) || string.IsNullOrEmpty(txtDuongDanAnh.Text))
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Bạn chưa điền họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTen.Focus();
                }
                else if (string.IsNullOrEmpty(dtpNgaySinh.Text))
                {
                    MessageBox.Show("Bạn chưa điền ngày sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgaySinh.Focus();
                }
                else if (string.IsNullOrEmpty(txtQueQuan.Text))
                {
                    MessageBox.Show("Bạn chưa điền quê quán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQueQuan.Focus();
                }
                else if (string.IsNullOrEmpty(txtDuongDanAnh.Text))
                {
                    MessageBox.Show("Bạn chưa có ảnh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bool bResult = false;
                if (Status == "Insert")
                {
                    bResult = InsertData(ref strError);
                    if (bResult == true)
                    {
                        Status = "Reset";
                        SetControl(Status);
                        MessageBox.Show("Ghi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Status == "Update")
                {
                    bResult = UpdateData(ref strError);
                    if (bResult == true)
                    {
                        ds.AcceptChanges();
                        grdGiangVien.DataSource = ds.Tables[0];
                        Status = "Reset";
                        SetControl(Status);
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Reset";
            SetControl(Status);
            LoadData();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(open.FileName);
                string path = open.FileName;
                txtDuongDanAnh.Text = path;
            }
        }

        private void grdGiangVien_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtTen.Text = gridView.GetRowCellValue(row, "ho_ten").ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "ngay_sinh").ToString());
                if(gridView.GetRowCellValue(row, "gioi_tinh").ToString() == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }    
                else
                {
                    rdoNu.Checked = true;
                    rdoNam.Checked = false;
                }    
                txtCMTND.Text = gridView.GetRowCellValue(row, "cmtnd").ToString();
                txtQueQuan.Text = gridView.GetRowCellValue(row, "que_quan").ToString();
                txtSDT.Text = gridView.GetRowCellValue(row, "so_dien_thoai").ToString();
                txtEmail.Text = gridView.GetRowCellValue(row, "email").ToString();
                txtHocVan.Text = gridView.GetRowCellValue(row, "hoc_van").ToString();
                dtpNgayLV.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "ngay_bat_dau_lv").ToString());
                cboTrangThai.Text = gridView.GetRowCellValue(row, "trang_thai").ToString();
                txtGhiChu.Text = gridView.GetRowCellValue(row, "ghi_chu").ToString();
                txtDuongDanAnh.Text = gridView.GetRowCellValue(row, "anh").ToString();
                picAnh.Image = Image.FromFile(gridView.GetRowCellValue(row, "anh").ToString());
            }
        }

        private void btnEmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string email;
            email = txtEmail.Text;
            SendToMail mail = new SendToMail(email);
            mail.Show();
        }
    }
}
