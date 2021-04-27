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
using DevExpress.Utils.DirectXPaint.Svg;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace dev_trung_tâm_dt.UserControls
{
    public partial class ucLopHoc : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        public static string strError = "";
        public static string Status = "";
        SqlConnection conn;
        DataSet ds;
        public ucLopHoc()
        {
            InitializeComponent();
            SetControl("Reset");
            LoadData();
            DataSet dsKhoa = new DataSet();
            dsKhoa = GetKhoaHoc();
            if (dsKhoa != null && dsKhoa.Tables.Count > 0 && dsKhoa.Tables[0].Rows.Count > 0)
            {
                cboMaKH.DisplayMember = "ten_khoahoc";
                cboMaKH.ValueMember = "ma_khoahoc";
                cboMaKH.DataSource = dsKhoa.Tables[0];

                cboMaKH.SelectedValue = "-1";
            }
            else
            {
                cboMaKH.DataSource = null;
            }
        }

        private void ucLopHoc_Load(object sender, EventArgs e)
        {
            DataSet dsMon = new DataSet();
            dsMon = GetMonHoc();
            if (dsMon != null && dsMon.Tables.Count > 0 && dsMon.Tables[0].Rows.Count > 0)
            {
                cboMaMH.DisplayMember = "ten_monhoc";
                cboMaMH.ValueMember = "ma_monhoc";
                cboMaMH.DataSource = dsMon.Tables[0];

                cboMaMH.SelectedValue = "-1";
            }
            else
            {
                cboMaMH.DataSource = null;
            }
        }

        public void SetControl(string x)
        {
            switch(x)
            {
                case "Reset":
                    txtMaLH.Enabled = false;
                    txtTenLH.Enabled = false;
                    cboMaKH.Enabled = false;
                    cboMaMH.Enabled = false;
                    dtpNgayBD.Enabled = false;
                    dtpNgayKT.Enabled = false;
                    txtSoHV.Enabled = false;
                    cboTrangThai.Enabled = false;
                    txtGhiChu.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDL.Enabled = false;
                    btnHuyBo.Enabled = false;

                    break;

                case "Insert":

                    txtMaLH.Enabled = true;
                    txtTenLH.Enabled = true;
                    cboMaKH.Enabled = true;
                    cboMaMH.Enabled = true;
                    dtpNgayBD.Enabled = true;
                    dtpNgayKT.Enabled = true;
                    txtSoHV.Enabled = true;
                    cboTrangThai.Enabled = false;
                    txtGhiChu.Enabled = true;

                    txtMaLH.Text = "";
                    txtTenLH.Text = "";
                    txtSoHV.Text = "";
                    txtGhiChu.Text = "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuyBo.Enabled = true;

                    txtMaLH.Focus();
                    break;

                case "Update":
                    txtMaLH.Enabled = false;
                    txtTenLH.Enabled = true;
                    cboMaKH.Enabled = true;
                    cboMaMH.Enabled = true;
                    dtpNgayBD.Enabled = true;
                    dtpNgayKT.Enabled = true;
                    txtSoHV.Enabled = true;
                    cboTrangThai.Enabled = true;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuyBo.Enabled = true;

                    break;

            }
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = " select * from lop_hoc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            adapter.Fill(ds);

            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdLopHoc.DataSource = ds.Tables[0];
                lblBanGhi.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";
                txtMaLH.Text = ds.Tables[0].Rows[0]["ma_lophoc"].ToString();
                txtTenLH.Text = ds.Tables[0].Rows[0]["ten_lophoc"].ToString();
                cboMaKH.Text = ds.Tables[0].Rows[0]["ma_khoahoc"].ToString();
                cboMaMH.Text = ds.Tables[0].Rows[0]["ma_monhoc"].ToString();
                dtpNgayBD.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["thoi_gian_bd"].ToString());
                dtpNgayKT.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["thoi_gian_kt"].ToString());
                txtSoHV.Text = ds.Tables[0].Rows[0]["so_hocvien"].ToString();
                cboTrangThai.Text = ds.Tables[0].Rows[0]["trang_thai"].ToString();
                txtGhiChu.Text = ds.Tables[0].Rows[0]["ghi_chu"].ToString();
            }
            conn.Dispose();
        }

        public DataSet GetKhoaHoc()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string strQuery = "SELECT * FROM khoa_hoc";
                SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["ten_khoahoc"] = "All";
                    dr["ma_khoahoc"] = "-1";
                    ds.Tables[0].Rows.Add(dr);
                    return ds;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông Báo");
                return null;
            }
            finally
            {
                conn.Dispose(); 
            }
        }

        public DataSet GetMonHoc()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string strQuery = "SELECT * FROM mon_hoc";
                SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["ten_monhoc"] = "All";
                    dr["ma_monhoc"] = "-1";
                    ds.Tables[0].Rows.Add(dr);
                    return ds;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông Báo");
                return null;
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

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Update";
            SetControl(Status);
        }

        private bool InsertLop(ref string Error)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "insert_lophoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_lopHoc", txtMaLH.Text.Trim());
                cmd.Parameters.AddWithValue("@ma_khoahoc", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@ten_lophoc", txtTenLH.Text.Trim());
                cmd.Parameters.AddWithValue("@ma_monhoc", cboMaMH.Text);
                cmd.Parameters.AddWithValue("@so_hocvien", txtSoHV.Text.Trim());
                cmd.Parameters.AddWithValue("@thoi_gian_bd", dtpNgayBD.Value);
                cmd.Parameters.AddWithValue("@thoi_gian_kt", dtpNgayKT.Value);
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        private bool UpdateLop(ref string Error)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update_lophoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_lophoc", txtMaLH.Text.Trim());
                cmd.Parameters.AddWithValue("@ma_khoahoc", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@ten_lophoc", txtTenLH.Text.Trim());
                cmd.Parameters.AddWithValue("@ma_monhoc", cboMaMH.Text);
                cmd.Parameters.AddWithValue("@so_hocvien", txtSoHV.Text.Trim());
                cmd.Parameters.AddWithValue("@thoi_gian_bd", dtpNgayBD.Value);
                cmd.Parameters.AddWithValue("@thoi_gian_kt", dtpNgayKT.Value);
                cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học '"+ txtMaLH.Text.Trim() +"' không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "Delete lop_hoc where ma_lophoc = '" + txtMaLH.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa lớp học '" + txtMaLH.Text.Trim() + "' thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
            }    
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status = "Reset";
            SetControl(Status);
            LoadData();
        }

        private void btnGhiDL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bResult = false;
            if(Status == "Insert")
            {
                bool cExits = false;
                cExits = CheckExits_LopHoc(txtMaLH.Text.Trim());
                if(cExits == false)
                {
                    MessageBox.Show("Đã tồn tại mã lớp học '" + txtMaLH.Text + "' trong hệ thống ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLH.Focus();
                    return;
                }
                bResult = InsertLop(ref strError);
                if(bResult == true)
                {
                    grdLopHoc.DataSource = ds.Tables[0];
                    lblBanGhi.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";
                    Status = "Reset";
                    SetControl(Status);
                    MessageBox.Show("Ghi dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Ghi dữ liệu! Mời bạn kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }    
            else if(Status == "Update")
            {
                bResult = UpdateLop(ref strError);
                if(bResult == true)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (dr["ma_lophoc"].ToString().Trim() == txtMaLH.Text.Trim())
                        {
                            dr["ma_khoahoc"] = cboMaKH.Text;
                            dr["ten_lophoc"] = txtTenLH.Text.Trim();
                            dr["ma_monhoc"] = cboMaMH.Text;
                            dr["thoi_gian_bd"] = dtpNgayBD.Value;
                            dr["thoi_gian_kt"] = dtpNgayKT.Value;
                            dr["ghi_chu"] = txtGhiChu.Text.Trim();
                            dr["trang_thai"] = cboTrangThai.Text;
                            break;
                        }
                    }
                    grdLopHoc.DataSource = ds.Tables[0];
                    Status = "Reset";
                    SetControl(Status);
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa dữ liệu! Mời bạn kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void grdLopHoc_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtMaLH.Text = gridView1.GetRowCellValue(row, "ma_lophoc").ToString();
                cboMaKH.Text = gridView1.GetRowCellValue(row, "ma_khoahoc").ToString();
                txtTenLH.Text = gridView1.GetRowCellValue(row, "ten_lophoc").ToString();
                cboMaMH.Text = gridView1.GetRowCellValue(row, "ma_monhoc").ToString();
                txtSoHV.Text = gridView1.GetRowCellValue(row, "so_hocvien").ToString();
                dtpNgayBD.Value = Convert.ToDateTime(gridView1.GetRowCellValue(row, "thoi_gian_bd"));
                dtpNgayKT.Value = Convert.ToDateTime(gridView1.GetRowCellValue(row, "thoi_gian_kt"));
                txtGhiChu.Text = gridView1.GetRowCellValue(row, "ghi_chu").ToString();
                cboTrangThai.Text = gridView1.GetRowCellValue(row, "trang_thai").ToString();
            }
        }

        private bool CheckExits_LopHoc(string ma_lophoc)
        {
            string Error;
            try
            {
                conn = new SqlConnection(connectionString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "check_exits_lophoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_lophoc", ma_lophoc);
                DataSet dsCheck = new DataSet();
                adapter.Fill(dsCheck);
                if (dsCheck != null && dsCheck.Tables.Count > 0 && dsCheck.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                else
                    return true;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}
