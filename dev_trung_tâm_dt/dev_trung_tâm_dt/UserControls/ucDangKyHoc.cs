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
    public partial class ucDangKyHoc : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public static string strError = "";
        public static string Status = "";
        DataSet ds;
        public ucDangKyHoc()
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

                    txtMaHV.Enabled = false;
                    cboMaMH.Enabled = false;
                    dtpNgayDK.Enabled = false;
                    cboHTDK.Enabled = false;
                    cboTrangThai.Enabled = false;
                    grcNgayHoc.Enabled = false;

                    txtMaHV.Text = "";
                    cboMaMH.Text = "";
                    dtpNgayDK.Text = "";
                    cboHTDK.Text = "";
                    cboTrangThai.Text = "";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;
                    btnRefresh.Enabled = true;

                    break;
                case "Insert":

                    txtMaHV.Enabled = true;
                    cboMaMH.Enabled = true;
                    dtpNgayDK.Enabled = false;
                    cboHTDK.Enabled = true;
                    cboHTDK.SelectedIndex = 1;
                    cboTrangThai.Enabled = false;
                    grcNgayHoc.Enabled = true;

                    txtMaHV.Text = "";
                    cboMaMH.Text = "";
                    dtpNgayDK.Text = "";
                    cboTrangThai.Text = "1";

                    chkT2.Checked = true;
                    chkT3.Checked = true;
                    chkT4.Checked = true;
                    chkT5.Checked = true;
                    chkT6.Checked = true;
                    chkT7.Checked = true;
                    chkCN.Checked = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnRefresh.Enabled = true;

                    txtMaHV.Focus();
                    break;
                case "Update":

                    txtMaHV.Enabled = false;
                    cboMaMH.Enabled = true;
                    dtpNgayDK.Enabled = true;
                    cboHTDK.Enabled = true;
                    cboTrangThai.Enabled = true;
                    grcNgayHoc.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnRefresh.Enabled = true;

                    break;

                default:
                    break;
            }
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from hocvien_dangky";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdDangKy.DataSource = ds.Tables[0];

                txtMaHV.Text = ds.Tables[0].Rows[0]["ma_hocvien"].ToString();
                cboMaMH.Text = ds.Tables[0].Rows[0]["ma_monhoc"].ToString();
                dtpNgayDK.Text = ds.Tables[0].Rows[0]["ngay_dangky"].ToString();
                cboHTDK.Text = ds.Tables[0].Rows[0]["hinhthuc_dangky"].ToString();
                cboTrangThai.Text = ds.Tables[0].Rows[0]["trang_thai"].ToString();
                if (ds.Tables[0].Rows[0]["thu_3"].ToString() == "1")
                {
                    chkT2.Checked = true;
                }
                else
                {
                    chkT2.Checked = false;
                }
                if (ds.Tables[0].Rows[0]["thu_2"].ToString() == "1")
                {
                    chkT3.Checked = true;
                }
                else
                {
                    chkT3.Checked = false;
                }
                if (ds.Tables[0].Rows[0]["thu_4"].ToString() == "1")
                {
                    chkT4.Checked = true;
                }
                else
                {
                    chkT4.Checked = false;
                }
                if (ds.Tables[0].Rows[0]["thu_5"].ToString() == "1")
                {
                    chkT5.Checked = true;
                }
                else
                {
                    chkT5.Checked = false;
                }
                if (ds.Tables[0].Rows[0]["thu_6"].ToString() == "1")
                {
                    chkT6.Checked = true;
                }
                else
                {
                    chkT6.Checked = false;
                }
                if (ds.Tables[0].Rows[0]["thu_7"].ToString() == "1")
                {
                    chkT7.Checked = true;
                }
                else
                {
                    chkT7.Checked = false;
                }
                if (ds.Tables[0].Rows[0]["chu_nhat"].ToString() == "1")
                {
                    chkCN.Checked = true;
                }
                else
                {
                    chkCN.Checked = false;
                }
            }
            else
            {
                grdDangKy.DataSource = null;
            }
            conn.Close();
        }

        private void grdDangKy_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

                txtMaHV.Text = gridView.GetRowCellValue(row, "ma_hocvien").ToString();
                cboMaMH.Text = gridView.GetRowCellValue(row, "ma_monhoc").ToString();
                dtpNgayDK.Text = gridView.GetRowCellValue(row, "ngay_dangky").ToString();
                cboHTDK.Text = gridView.GetRowCellValue(row, "hinhthuc_dangky").ToString();
                cboTrangThai.Text = gridView.GetRowCellValue(row, "trang_thai").ToString();
                if (gridView.GetRowCellValue(row, "thu_2").ToString() == "1")
                {
                    chkT2.Checked = true;
                }
                else
                {
                    chkT2.Checked = false;
                }
                if (gridView.GetRowCellValue(row, "thu_3").ToString() == "1")
                {
                    chkT3.Checked = true;
                }
                else
                {
                    chkT3.Checked = false;
                }
                if (gridView.GetRowCellValue(row, "thu_4").ToString() == "1")
                {
                    chkT4.Checked = true;
                }
                else
                {
                    chkT4.Checked = false;
                }
                if (gridView.GetRowCellValue(row, "thu_5").ToString() == "1")
                {
                    chkT5.Checked = true;
                }
                else
                {
                    chkT5.Checked = false;
                }
                if (gridView.GetRowCellValue(row, "thu_6").ToString() == "1")
                {
                    chkT6.Checked = true;
                }
                else
                {
                    chkT6.Checked = false;
                }
                if (gridView.GetRowCellValue(row, "thu_7").ToString() == "1")
                {
                    chkT7.Checked = true;
                }
                else
                {
                    chkT7.Checked = false;
                }
                if (gridView.GetRowCellValue(row, "chu_nhat").ToString() == "1")
                {
                    chkCN.Checked = true;
                }
                else
                {
                    chkCN.Checked = false;
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            SetControl("Reset");
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa '" + gridView.GetRowCellValue(gridView.FocusedRowHandle, "ma_hocvien") + "' không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from hocvien_dangky where id = '" + gridView.GetRowCellValue(gridView.FocusedRowHandle, "id") + "'";
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

        private bool InsertData(ref string Error)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "insert_hocvien_dangky";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma_hocvien", txtMaHV.Text.Trim());
                cmd.Parameters.AddWithValue("@id_taikhoan", "1");
                cmd.Parameters.AddWithValue("@ma_monhoc", cboMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay_dangky", DateTime.Now);
                cmd.Parameters.AddWithValue("@hinhthuc_dangky", cboHTDK.Text.Trim());
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text.Trim());
                if (chkT2.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_2", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_2", "0");
                if (chkT3.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_3", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_3", "0");
                if (chkT4.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_4", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_4", "0");
                if (chkT5.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_5", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_5", "0");
                if (chkT6.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_6", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_6", "0");
                if (chkT7.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_7", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_7", "0");
                if (chkCN.Checked == true)
                    cmd.Parameters.AddWithValue("@chu_nhat", "1");
                else
                    cmd.Parameters.AddWithValue("@chu_nhat", "0");

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
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update_hocvien_dangky";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", gridView.GetRowCellValue(gridView.FocusedRowHandle, "id".ToString()));
                cmd.Parameters.AddWithValue("@ma_hocvien", txtMaHV.Text.Trim());
                cmd.Parameters.AddWithValue("@id_taikhoan", "1");
                cmd.Parameters.AddWithValue("@ma_monhoc", cboMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay_dangky", DateTime.Now);
                cmd.Parameters.AddWithValue("@hinhthuc_dangky", cboHTDK.Text.Trim());
                cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text.Trim());
                if (chkT2.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_2", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_2", "0");
                if (chkT3.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_3", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_3", "0");
                if (chkT4.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_4", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_4", "0");
                if (chkT5.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_5", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_5", "0");
                if (chkT6.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_6", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_6", "0");
                if (chkT7.Checked == true)
                    cmd.Parameters.AddWithValue("@thu_7", "1");
                else
                    cmd.Parameters.AddWithValue("@thu_7", "0");
                if (chkCN.Checked == true)
                    cmd.Parameters.AddWithValue("@chu_nhat", "1");
                else
                    cmd.Parameters.AddWithValue("@chu_nhat", "0");

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
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bResult = false;
            if (Status == "Insert")
            {
                bResult = InsertData(ref strError);
                if (bResult == true)
                {
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
                    Status = "Reset";
                    SetControl(Status);
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
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
            SetControl("Reset");
            LoadData();
        }
    }
}
