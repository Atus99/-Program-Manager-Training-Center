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
    public partial class ucTaiKhoan : UserControl
    {
        public static string ConnectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        public static string strError = "";
        public static string Status = "";
        SqlConnection conn;
        string Error;
        public ucTaiKhoan()
        {
            InitializeComponent();
            SetControl("Reset");
            LoadData();
        }

        public void SetControl(string x)
        {
            switch (x)
            {
                case "Reset":

                    txtGhiChu.Enabled = false;
                    txtTenTK.Enabled = false;
                    txtMK.Enabled = false;
                    cboQuyen.Enabled = false;
                    cboTrangThai.Enabled = false;

                    txtGhiChu.Text = "";
                    txtTenTK.Text = "";
                    txtMK.Text = "";                    

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;

                    break;
                case "Insert":

                    txtGhiChu.Enabled = true;
                    txtTenTK.Enabled = true;
                    txtMK.Enabled = true;
                    cboQuyen.Enabled = true;
                    cboTrangThai.Enabled = true;

                    txtGhiChu.Text = "";
                    txtTenTK.Text = "";
                    txtMK.Text = "";


                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;

                    txtTenTK.Focus();
                    break;
                case "Update":

                    txtGhiChu.Enabled = true;
                    txtTenTK.Enabled = true;
                    txtMK.Enabled = true;
                    cboQuyen.Enabled = true;
                    cboTrangThai.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;

                    break;

                case "Refresh":

                    txtGhiChu.Enabled = false;
                    txtTenTK.Enabled = false;
                    txtMK.Enabled = false;
                    cboQuyen.Enabled = false;
                    cboTrangThai.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;

                    break;
                default:
                    break;
            }
        }
        public void LoadData()
        {
            conn = new SqlConnection(ConnectionString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "select * from account";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdTaiKhoan.DataSource = ds.Tables[0];
                txtTenTK.Text = ds.Tables[0].Rows[0]["ten_taikhoan"].ToString();
                txtMK.Text = ds.Tables[0].Rows[0]["mat_khau"].ToString();
                cboQuyen.Text = ds.Tables[0].Rows[0]["quyen"].ToString();
                if (ds.Tables[0].Rows[0]["trang_thai"].ToString() == "1")
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = "Hết hạn";
                }
            }    
            else
            {
                grdTaiKhoan.DataSource = null;
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
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản '" + txtTenTK.Text.Trim() + "' không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    string query = "delete account where ten_taikhoan = '" + txtTenTK.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa tài khoản '" + txtTenTK.Text.Trim() + "' thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text))
            {
                if (string.IsNullOrEmpty(txtMK.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMK.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenTK.Focus();
                    return;
                }
            }
            if (Status == "Insert")
            {
                bool cExits = false;
                cExits = CheckExit_TaiKhoan(txtTenTK.Text.Trim());
                if (cExits == false)
                {
                    MessageBox.Show("Đã tồn tài tên tài khoản: " + txtTenTK .Text.Trim() + " trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    conn = new SqlConnection(ConnectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if(cboQuyen.Text == "Hoạt động")
                    {
                        string query = "Insert into account values ('" + txtTenTK.Text.Trim() + "', '" + txtMK.Text.Trim() + "', '" + cboQuyen.Text + "', N'" + txtGhiChu.Text.Trim() + "', '" + DateTime.Now + "', '1')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        SetControl("Refresh");
                        LoadData();
                        MessageBox.Show("Ghi dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                    else
                    {
                        string query = "Insert into account values ('" + txtTenTK.Text.Trim() + "', '" + txtMK.Text.Trim() + "', '" + cboQuyen.Text + "', N'" + txtGhiChu.Text.Trim() + "', '" + DateTime.Now + "', '0')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        SetControl("Refresh");
                        LoadData();
                        MessageBox.Show("Ghi dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                    
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                }
            }
            else if (Status == "Update")
            {
                try
                {
                    conn = new SqlConnection(ConnectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if(cboTrangThai.Text == "Hoạt động")
                    {
                        string query = "Update account set mat_khau = '" + txtMK.Text.Trim() + "', quyen = '" + cboQuyen.Text.Trim() + "', ghi_chu = N'" + txtGhiChu.Text.Trim() + "', ngay_tao = '" + DateTime.Now + "', trang_thai = '1' where ten_taikhoan = '" + txtTenTK.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        SetControl("Refresh");
                        LoadData();
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                    else
                    {
                        string query = "Update account set mat_khau = '" + txtMK.Text.Trim() + "', quyen = '" + cboQuyen.Text.Trim() + "', ghi_chu = N'" + txtGhiChu.Text.Trim() + "', ngay_tao = '" + DateTime.Now + "', trang_thai = '1' where ten_taikhoan = '" + txtTenTK.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        SetControl("Refresh");
                        LoadData();
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                      
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                }
            }
        }

        public bool CheckExit_TaiKhoan(string ten_taikhoan)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "select * from account where ten_taikhoan = '" + txtTenTK.Text.Trim() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetControl("Reset");
            LoadData();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void grdTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtTenTK.Text = gridView.GetRowCellValue(row, "ten_taikhoan").ToString();
                txtMK.Text = gridView.GetRowCellValue(row, "mat_khau").ToString();
                cboQuyen.Text = gridView.GetRowCellValue(row, "quyen").ToString();
                txtGhiChu.Text = gridView.GetRowCellValue(row, "ghi_chu").ToString();
                if (gridView.GetRowCellValue(row, "trang_thai").ToString() == "1")
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = "Hết hạn";
                }
            }
        }

        // combobox quyen
        private void cboQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "select * from account where quyen = '" + cboQuyen.Text.Trim() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    grdTaiKhoan.DataSource = ds.Tables[0];
                }
                else
                {
                    grdTaiKhoan.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông Báo");
            }
            finally
            {
                conn.Dispose();
            }
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
