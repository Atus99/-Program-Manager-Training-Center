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
    public partial class ucMonHoc : UserControl
    {
        public static string ConnectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        public static string strError = "";
        public static string Status = "";
        SqlConnection conn;
        DataSet ds;
        public ucMonHoc()
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

                    txtMaMH.Enabled = false;
                    txtTenMH.Enabled = false;
                    txtSoBuoi.Enabled = false;
                    txtThoiGian.Enabled = false;
                    txtHocPhi.Enabled = false;
                    txtMoTa.Enabled = false;
                    txtYeuCau.Enabled = false;
                    txtGhiChu.Enabled = false;
                    cboTrangThai.Enabled = false;

                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtSoBuoi.Text = "";
                    txtThoiGian.Text = "";
                    txtHocPhi.Text = "";
                    txtMoTa.Text = "";
                    txtYeuCau.Text = "";
                    txtGhiChu.Text = "";
                    cboTrangThai.Text = "";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;

                    break;
                case "Insert":

                    txtMaMH.Enabled = true;
                    txtTenMH.Enabled = true;
                    txtSoBuoi.Enabled = true;
                    txtThoiGian.Enabled = true;
                    txtHocPhi.Enabled = true;
                    txtMoTa.Enabled = true;
                    txtYeuCau.Enabled = true;
                    txtGhiChu.Enabled = true;
                    cboTrangThai.Enabled = true;

                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtSoBuoi.Text = "";
                    txtThoiGian.Text = "";
                    txtHocPhi.Text = "";
                    txtMoTa.Text = "";
                    txtYeuCau.Text = "";
                    txtGhiChu.Text = "";
                    cboTrangThai.Text = "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;

                    txtMaMH.Focus();
                    break;
                case "Update":

                    txtMaMH.Enabled = false;
                    txtTenMH.Enabled = true;
                    txtSoBuoi.Enabled = true;
                    txtThoiGian.Enabled = true;
                    txtHocPhi.Enabled = true;
                    txtMoTa.Enabled = true;
                    txtYeuCau.Enabled = true;
                    txtGhiChu.Enabled = true;
                    cboTrangThai.Enabled = true;

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
            conn = new SqlConnection(ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from mon_hoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdMonHoc.DataSource = ds.Tables[0];
                lblBanGhi.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

                txtMaMH.Text = ds.Tables[0].Rows[0]["ma_monhoc"].ToString();
                txtTenMH.Text = ds.Tables[0].Rows[0]["ten_monhoc"].ToString();
                txtSoBuoi.Text = ds.Tables[0].Rows[0]["so_buoihoc"].ToString();
                txtThoiGian.Text = ds.Tables[0].Rows[0]["thoi_gian_buoihoc"].ToString();
                txtHocPhi.Text = ds.Tables[0].Rows[0]["hoc_phi"].ToString();
                txtMoTa.Text = ds.Tables[0].Rows[0]["mo_ta"].ToString();
                txtYeuCau.Text = ds.Tables[0].Rows[0]["yeu_cau"].ToString();
                txtGhiChu.Text = ds.Tables[0].Rows[0]["ghi_chu"].ToString();
                cboTrangThai.Text = ds.Tables[0].Rows[0]["trang_thai"].ToString();

                //cboMaKhoaHoc.DataSource = ds.Tables[0];
                //cboMaKhoaHoc.ValueMember = "MA_KHOAHOC";
            }
            else
            {
                grdMonHoc.DataSource = null;
                lblBanGhi.Text = "Tổng số: 0 bản ghi";
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Insert";
            SetControl(Status);
            cboTrangThai.DisplayMember = "1";
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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn học '" + txtMaMH.Text.Trim() + "' không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    string query = "delete mon_hoc where ma_monhoc = '" + txtMaMH.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa '" + txtMaMH.Text.Trim() + "' thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertData(ref string Error)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "insert_monhoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_monhoc", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@ten_monhoc", txtTenMH.Text.Trim());
                cmd.Parameters.AddWithValue("@so_buoihoc", txtSoBuoi.Text.Trim());
                cmd.Parameters.AddWithValue("@thoi_gian_buoihoc", txtThoiGian.Text.Trim());
                cmd.Parameters.AddWithValue("@hoc_phi", txtHocPhi.Text.Trim());
                cmd.Parameters.AddWithValue("@mo_ta", txtMoTa.Text.Trim());
                cmd.Parameters.AddWithValue("@yeu_cau", txtYeuCau.Text.Trim());
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text);

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
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update_monhoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_monhoc", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@ten_monhoc", txtTenMH.Text.Trim());
                cmd.Parameters.AddWithValue("@so_buoihoc", txtSoBuoi.Text.Trim());
                cmd.Parameters.AddWithValue("@thoi_gian_buoihoc", txtThoiGian.Text.Trim());
                cmd.Parameters.AddWithValue("@hoc_phi", txtHocPhi.Text.Trim());
                cmd.Parameters.AddWithValue("@mo_ta", txtMoTa.Text.Trim());
                cmd.Parameters.AddWithValue("@yeu_cau", txtYeuCau.Text.Trim());
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text);

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

        private bool CheckExits_MonHoc(string ma_monhoc)
        {
            string Error;
            try
            {
                conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "check_exits_monhoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_monhoc", ma_monhoc);
                DataSet dsCheck = new DataSet();
                adapter.Fill(dsCheck);
                if (dsCheck != null && dsCheck.Tables.Count > 0 && dsCheck.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bResult = false;
            if (Status == "Insert")
            {
                bool cExits = false;
                cExits = CheckExits_MonHoc(txtMaMH.Text.Trim());
                if (cExits == false)
                {
                    MessageBox.Show("Đã tồn tại mã môn học '" + txtMaMH.Text + "' trong hệ thống ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMH.Focus();
                    return;
                }
                bResult = InsertData(ref strError);
                if (bResult == true)
                {
                    grdMonHoc.DataSource = ds.Tables[0];
                    lblBanGhi.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";
                    Status = "Reset";
                    SetControl(Status);
                    MessageBox.Show("Ghi dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (Status == "Update")
            {
                bResult = UpdateData(ref strError);
                if (bResult == true)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (dr["ma_monhoc"].ToString().Trim() == txtMaMH.Text.Trim())
                        {
                            dr["ten_monhoc"] = txtTenMH.Text.Trim();
                            dr["so_buoihoc"] = txtSoBuoi.Text.Trim();
                            dr["thoi_gian_buoihoc"] = txtThoiGian.Text;
                            dr["hoc_phi"] = txtHocPhi.Text.Trim();
                            dr["mo_ta"] = txtMoTa.Text.Trim();
                            dr["yeu_cau"] = txtYeuCau.Text.Trim();
                            dr["ghi_chu"] = txtGhiChu.Text.Trim();
                            dr["trang_thai"] = cboTrangThai.Text;
                            break;
                        }
                    }
                    grdMonHoc.DataSource = ds.Tables[0];
                    Status = "Reset";
                    SetControl(Status);
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi sửa dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            else
            {
                MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Reset";
            SetControl(Status);
            LoadData();
        }

        private void grdMonHoc_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtMaMH.Text = gridView1.GetRowCellValue(row, "ma_monhoc").ToString();
                txtTenMH.Text = gridView1.GetRowCellValue(row, "ten_monhoc").ToString();
                txtSoBuoi.Text = gridView1.GetRowCellValue(row, "so_buoihoc").ToString();
                txtThoiGian.Text = gridView1.GetRowCellValue(row, "thoi_gian_buoihoc").ToString();
                txtHocPhi.Text = gridView1.GetRowCellValue(row, "hoc_phi").ToString();
                txtMoTa.Text = gridView1.GetRowCellValue(row, "mo_ta").ToString();
                txtYeuCau.Text = gridView1.GetRowCellValue(row, "yeu_cau").ToString();
                txtGhiChu.Text = gridView1.GetRowCellValue(row, "ghi_chu").ToString();
                cboTrangThai.Text = gridView1.GetRowCellValue(row, "trang_thai").ToString();

                //cboMaKhoaHoc.SelectedValue = txtMaKhoaHoc.Text.Trim();
            }
        }
    }
}
