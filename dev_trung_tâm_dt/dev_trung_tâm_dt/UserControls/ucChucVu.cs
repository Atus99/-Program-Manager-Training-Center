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
    public partial class ucChucVu : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public static string Status = "";
        string Error;
        public ucChucVu()
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
                    txtMaCV.Enabled = false;
                    txtTenCV.Enabled = false;
                    txtMoTa.Enabled = false;

                    txtGhiChu.Text = "";
                    txtMaCV.Text = "";
                    txtMoTa.Text = "";
                    txtTenCV.Text = "";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;

                    break;
                case "Insert":

                    txtGhiChu.Enabled = true;
                    txtMaCV.Enabled = true;
                    txtTenCV.Enabled = true;
                    txtMoTa.Enabled = true;

                    txtGhiChu.Text = "";
                    txtMaCV.Text = "";
                    txtMoTa.Text = "";
                    txtTenCV.Text = "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;

                    txtMaCV.Focus();
                    break;
                case "Update":

                    txtGhiChu.Enabled = true;
                    txtMaCV.Enabled = false;
                    txtTenCV.Enabled = true;
                    txtMoTa.Enabled = true;

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

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "select * from chuc_vu";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdChucVu.DataSource = ds.Tables[0];
                txtMaCV.Text = ds.Tables[0].Rows[0]["ma_chucvu"].ToString();
                txtTenCV.Text = ds.Tables[0].Rows[0]["ten_chucvu"].ToString();
                txtGhiChu.Text = ds.Tables[0].Rows[0]["ghi_chu"].ToString();
                txtMoTa.Text = ds.Tables[0].Rows[0]["mo_ta"].ToString();
            }    
            else
            {
                grdChucVu.DataSource = null;
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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ '" + txtTenCV.Text.Trim() + "' không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    string query = "delete chuc_vu where ma_chucvu = '" + txtMaCV.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa chức vụ '" + txtTenCV.Text.Trim() + "' thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenCV.Text))
            {
                if(string.IsNullOrEmpty(txtMaCV.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã chức vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaCV.Focus();
                    return;
                }    
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên chức vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenCV.Focus();
                    return;
                }    
            }    
            if(Status == "Insert")
            {
                bool cExits = false;
                cExits = CheckExit_ChucVu(txtMaCV.Text.Trim());
                if (cExits == false)
                {
                    MessageBox.Show("Đã tồn tài mã chức vụ: " + txtMaCV.Text.Trim() + " trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "Insert into chuc_vu values ('" + txtMaCV.Text.Trim() + "', N'" + txtTenCV.Text.Trim() + "', N'" + txtMoTa.Text.Trim() + "', N'" + txtGhiChu.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ghi dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
                catch(Exception ex)
                {
                    Error = ex.Message;
                }
            }    
            else if(Status == "Update")
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "Update chuc_vu set ten_chucvu = N'" + txtTenCV.Text.Trim() + "', mo_ta = N'" + txtMoTa.Text.Trim() + "', ghi_chu = N'" + txtGhiChu.Text.Trim() + "' where ma_chucvu = '" + txtMaCV.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhât dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                }
            }    
        }

        public bool CheckExit_ChucVu(string ma_chucvu)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "select * from khoa_hoc where ma_chucvu = '" + txtMaCV.Text.Trim() + "'";
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            SetControl("Reset");
            LoadData();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void grdChucVu_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtMaCV.Text = gridView.GetRowCellValue(row, "ma_chucvu").ToString();
                txtTenCV.Text = gridView.GetRowCellValue(row, "ten_chucvu").ToString();
                txtGhiChu.Text = gridView.GetRowCellValue(row, "ghi_chu").ToString();
                txtMoTa.Text = gridView.GetRowCellValue(row, "mo_ta").ToString();
            }
        }
    }
}
