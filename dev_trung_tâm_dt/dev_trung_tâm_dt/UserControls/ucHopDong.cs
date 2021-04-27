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
using System.Globalization;

namespace dev_trung_tâm_dt.UserControls
{
    public partial class ucHopDong : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public static string strError = "";
        public static string Status = "";
        public ucHopDong()
        {
            InitializeComponent();
            DataSet dsChucVu = new DataSet();
            dsChucVu = GetChucVu();
            if (dsChucVu != null && dsChucVu.Tables.Count > 0 && dsChucVu.Tables[0].Rows.Count > 0)
            {
                cboMaCV.DisplayMember = "ten_chucvu";
                cboMaCV.ValueMember = "ma_chucvu";
                cboMaCV.DataSource = dsChucVu.Tables[0];

                cboMaCV.SelectedValue = "-1";
            }
            else
            {
                cboMaCV.DataSource = null;
            }
            SetControl("Reset");
            LoadData();
        }

        private void SetControl(string x)
        {
            switch (x)
            {
                case "Reset":

                    txtGhiChu.Enabled = false;
                    txtMaNV.Enabled = false;
                    cboMaCV.Enabled = false;
                    txtMucLuong.Enabled = false;
                    txtSoQD.Enabled = false;
                    dtpNgayKy.Enabled = false;
                    dtpNgayHL.Enabled = false;
                    dtpNgayHH.Enabled = false;
                    dtpNgayCD.Enabled = false;
                    dtpNgayHH.Enabled = false;
                    txtNguoiKy.Enabled = false;

                    txtGhiChu.Text = "";
                    txtMaNV.Text = "";
                    txtMucLuong.Text = "";
                    cboMaCV.Text = "";
                    txtNguoiKy.Text = "";
                    txtSoQD.Text = "";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDL.Enabled = false;
                    btnHuyBo.Enabled = false;

                    break;
                case "Insert":

                    txtGhiChu.Enabled = true;
                    txtMaNV.Enabled = true;
                    cboMaCV.Enabled = true;
                    txtMucLuong.Enabled = true;
                    txtSoQD.Enabled = true;
                    dtpNgayKy.Enabled = true;
                    dtpNgayHL.Enabled = true;
                    dtpNgayHH.Enabled = true;
                    dtpNgayCD.Enabled = false;
                    txtNguoiKy.Enabled = true;

                    txtGhiChu.Text = "";
                    txtMaNV.Text = "";
                    txtMucLuong.Text = "";
                    cboMaCV.Text = "";
                    txtNguoiKy.Text = "";
                    txtSoQD.Text = "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuyBo.Enabled = true;

                    txtMaNV.Focus();
                    break;
                case "Update":

                    txtGhiChu.Enabled = true;
                    txtMaNV.Enabled = false;
                    cboMaCV.Enabled = true;
                    txtMucLuong.Enabled = true;
                    txtSoQD.Enabled = true;
                    dtpNgayKy.Enabled = true;
                    dtpNgayHL.Enabled = true;
                    dtpNgayHH.Enabled = true;
                    dtpNgayCD.Enabled = true;
                    txtNguoiKy.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuyBo.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        public DataSet GetChucVu()
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from chuc_vu";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
            {
                return null;
            }
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from hop_dong";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtMaNV.Text = ds.Tables[0].Rows[0]["ma_nhanvien"].ToString();
                cboMaCV.Text = ds.Tables[0].Rows[0]["ma_chucvu"].ToString();
                txtMucLuong.Text = ds.Tables[0].Rows[0]["muc_luong"].ToString();
                txtSoQD.Text = ds.Tables[0].Rows[0]["so_quyetdinh"].ToString();
                dtpNgayKy.Text = ds.Tables[0].Rows[0]["ngay_ky"].ToString();
                dtpNgayHL.Text = ds.Tables[0].Rows[0]["ngay_hieuluc"].ToString();
                dtpNgayHH.Text = ds.Tables[0].Rows[0]["ngay_hethan"].ToString();
                dtpNgayCD.Text = ds.Tables[0].Rows[0]["ngay_chamdut"].ToString();
                txtNguoiKy.Text = ds.Tables[0].Rows[0]["nguoi_ky"].ToString();
                txtGhiChu.Text = ds.Tables[0].Rows[0]["ghi_chu"].ToString();
                grdHopDong.DataSource = ds.Tables[0];
            }
            else
            {
                grdHopDong.DataSource = null;
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
                string query = "insert_hopdong";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_nhanvien", txtMaNV.Text.Trim());
                cmd.Parameters.AddWithValue("@ma_chucvu", cboMaCV.SelectedValue);
                cmd.Parameters.AddWithValue("@muc_luong", txtMucLuong.Text);
                cmd.Parameters.AddWithValue("@so_quyetdinh", txtSoQD.Text);
                cmd.Parameters.AddWithValue("@ngay_ky", dtpNgayKy.Value);
                cmd.Parameters.AddWithValue("@ngay_hieuluc", dtpNgayHL.Value);
                cmd.Parameters.AddWithValue("@ngay_hethan", dtpNgayHH.Value);
                cmd.Parameters.AddWithValue("@ngay_chamdut", "");
                cmd.Parameters.AddWithValue("@nguoi_ky", txtNguoiKy.Text.Trim());
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
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "update_hopdong";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", gridView.GetRowCellValue(gridView.FocusedRowHandle, "id"));
                cmd.Parameters.AddWithValue("@ma_nhanvien", txtMaNV.Text.Trim());
                cmd.Parameters.AddWithValue("@ma_chucvu", cboMaCV.SelectedValue);
                cmd.Parameters.AddWithValue("@muc_luong", txtMucLuong.Text);
                cmd.Parameters.AddWithValue("@so_quyetdinh", txtSoQD.Text);
                cmd.Parameters.AddWithValue("@ngay_ky", dtpNgayKy.Value);
                cmd.Parameters.AddWithValue("@ngay_hieuluc", dtpNgayHL.Value);
                cmd.Parameters.AddWithValue("@ngay_hethan", dtpNgayHH.Value);
                cmd.Parameters.AddWithValue("@ngay_chamdut", dtpNgayCD.Value);
                cmd.Parameters.AddWithValue("@nguoi_ky", txtNguoiKy.Text.Trim());
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());

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

        private void btnGhiDL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa  không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    string query = "delete hop_dong where id = '" + gridView.GetRowCellValue(gridView.FocusedRowHandle, "id") + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Reset";
            SetControl(Status);
            LoadData();
        }

        private void grdHopDong_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtMaNV.Text = gridView.GetRowCellValue(row, "ma_nhanvien").ToString();
                cboMaCV.Text = gridView.GetRowCellValue(row, "ma_chucvu").ToString();
                txtGhiChu.Text = gridView.GetRowCellValue(row, "ghi_chu").ToString();
                txtMucLuong.Text = gridView.GetRowCellValue(row, "muc_luong").ToString();
                txtGhiChu.Text = gridView.GetRowCellValue(row, "ghi_chu").ToString();
                dtpNgayKy.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "ngay_ky"));
                dtpNgayHL.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "ngay_hieuluc"));
                dtpNgayHH.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "ngay_hethan"));
                dtpNgayCD.Value = Convert.ToDateTime(gridView.GetRowCellValue(row, "ngay_chamdut"));
                txtNguoiKy.Text = gridView.GetRowCellValue(row, "nguoi_ky").ToString();
                txtGhiChu.Text = gridView.GetRowCellValue(row, "ghi_chu").ToString();
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}
