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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Xpo.DB.Helpers;
using System.Security.AccessControl;

namespace dev_trung_tâm_dt
{
    public partial class frmKhoaHoc : UserControl
    {
        public static string ConnectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        public static string strError = "";
        public static string Status = "";
        SqlConnection conn;
        DataSet ds;

        public frmKhoaHoc()
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
                    txtMaKhoaHoc.Enabled = false;
                    txtTenKhoaHoc.Enabled = false;
                    dtpBatDau.Enabled = false;
                    dtpKetThuc.Enabled = false;
                    cboTrangThai.Enabled = false;

                    txtGhiChu.Text = "";
                    txtMaKhoaHoc.Text = "";
                    txtTenKhoaHoc.Text = "";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;                    

                    break;
                case "Insert":

                    txtGhiChu.Enabled = true;
                    txtMaKhoaHoc.Enabled = true;
                    txtTenKhoaHoc.Enabled = true;
                    dtpBatDau.Enabled = true;
                    dtpKetThuc.Enabled = true;
                    cboTrangThai.Enabled = true;

                    txtGhiChu.Text = "";
                    txtMaKhoaHoc.Text = "";
                    txtTenKhoaHoc.Text = "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;

                    txtMaKhoaHoc.Focus();
                    break;
                case "Update":

                    txtGhiChu.Enabled = true;
                    txtMaKhoaHoc.Enabled = false;
                    txtTenKhoaHoc.Enabled = true;
                    dtpBatDau.Enabled = true;
                    dtpKetThuc.Enabled = true;
                    cboTrangThai.Enabled = false;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        private void LoadData()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM khoa_hoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    grdKhoaHoc.DataSource = ds.Tables[0];
                    lblTongSo.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

                    txtMaKhoaHoc.Text = ds.Tables[0].Rows[0]["ma_khoahoc"].ToString();
                    txtTenKhoaHoc.Text = ds.Tables[0].Rows[0]["ten_khoahoc"].ToString();
                    txtGhiChu.Text = ds.Tables[0].Rows[0]["ghi_chu"].ToString();
                    dtpBatDau.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["thoi_gian_bd"]);
                    dtpKetThuc.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["thoi_gian_kt"]);
                    cboTrangThai.Text = ds.Tables[0].Rows[0]["trang_thai"].ToString();

                }
                else
                {
                    grdKhoaHoc.DataSource = null;
                    lblTongSo.Text = "Tổng số: 0 bản ghi";
                }
            }
            catch (Exception ex)
            {
            }
        }

        private bool InsertData(ref string Error)
        {
            try
            {          
                string MaKhoaHoc = txtMaKhoaHoc.Text.Trim();
                string TenKhoaHoc = txtTenKhoaHoc.Text.Trim();
                string GhiChu = txtGhiChu.Text;
                DateTime TGianBDau = dtpBatDau.Value;
                DateTime TGianKThuc = dtpKetThuc.Value;

                conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into khoa_hoc values (@ma_khoahoc, @ten_khoahoc, @thoi_gian_bd, @thoi_gian_kt, @ghi_chu, @trang_thai)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_khoahoc", txtMaKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@ten_khoahoc", txtTenKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@thoi_gian_bd", dtpBatDau.Value);
                cmd.Parameters.AddWithValue("@thoi_gian_kt", dtpKetThuc.Value);
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@trang_thai", "1");

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
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "update_khoahoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_khoahoc", txtMaKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@ten_khoahoc", txtTenKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@thoi_gian_bd", dtpBatDau.Value);
                cmd.Parameters.AddWithValue("@thoi_gian_kt", dtpKetThuc.Value);
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());

                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }
        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Insert";
            SetControl(Status);
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Reset";
            SetControl(Status);
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Update";
            SetControl(Status);
        }

        private void grdKhoaHoc_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtMaKhoaHoc.Text = gridView.GetRowCellValue(row, "ma_khoahoc").ToString();
                txtTenKhoaHoc.Text = gridView.GetRowCellValue(row, "ten_khoahoc").ToString();
                txtGhiChu.Text = gridView.GetRowCellValue(row, "ghi_chu").ToString();
                dtpBatDau.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "thoi_gian_bd"));
                dtpKetThuc.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "thoi_gian_kt"));
                cboTrangThai.Text = gridView.GetRowCellValue(row, "trang_thai").ToString();
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bResult = false;
            if(Status == "Insert")
            {
                bool cExits = false;
                cExits = CheckExits_Khoahoc(txtMaKhoaHoc.Text.Trim());
                if(cExits == false)
                {
                    MessageBox.Show("Đã tồn tài mã khóa học: " + txtMaKhoaHoc.Text.Trim() + " trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bResult = InsertData(ref strError);
                if(bResult == true)
                {
                    lblTongSo.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

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
            else if(Status == "Update")
            {
                bResult = UpdateData(ref strError);
                if(bResult == true)
                {
                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        if(dr["ma_khoahoc"].ToString().Trim() == txtMaKhoaHoc.Text.Trim())
                        {
                            dr["ten_khoahoc"] = txtTenKhoaHoc.Text.Trim();
                            dr["thoi_gian_bd"] = dtpBatDau.Value;
                            dr["thoi_gian_kt"] = dtpKetThuc.Value;
                            dr["ghi_chu"] = txtGhiChu.Text.Trim();
                            break;
                        }
                    }
                    ds.AcceptChanges();
                    grdKhoaHoc.DataSource = ds.Tables[0];
                    Status = "Reset";
                    SetControl(Status);
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
                else
                {
                    MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }    
        }

        private bool CheckExits_Khoahoc(string ma_khoahoc)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "select * from khoa_hoc where ma_khoahoc = '"+ txtMaKhoaHoc.Text.Trim() +"'";
                //SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                //cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@ma_khoahoc", ma_khoahoc);
                ds = new DataSet();
                adapter.Fill(ds);
                if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học '"+txtMaKhoaHoc.Text.Trim() +"' không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    string query = "delete khoa_hoc where ma_khoahoc = '" + txtMaKhoaHoc.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa '" + txtMaKhoaHoc.Text.Trim() + "' thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }                  
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}

