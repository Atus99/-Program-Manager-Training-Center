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
    public partial class ucPhanLop : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        string Error;
        public ucPhanLop()
        {
            InitializeComponent();
            DataSet dsMonHoc = new DataSet();
            dsMonHoc = GetMonHoc();
            if (dsMonHoc != null && dsMonHoc.Tables.Count > 0 && dsMonHoc.Tables[0].Rows.Count > 0)
            {
                cboMaMH.DisplayMember = "ten_monhoc";
                cboMaMH.ValueMember = "ma_monhoc";
                cboMaMH.DataSource = dsMonHoc.Tables[0];

                cboMaMH.SelectedValue = "-1";
            }
            else
            {
                cboMaMH.DataSource = null;
            }
        }

        private void ucPhanLop_Load(object sender, EventArgs e)
        {
            DataSet dsLop = new DataSet();
            dsLop = GetLop();
            if (dsLop != null && dsLop.Tables.Count > 0 && dsLop.Tables[0].Rows.Count > 0)
            {
                cboLopHoc.DisplayMember = "ten_lophoc";
                cboLopHoc.ValueMember = "ma_lophoc";
                cboLopHoc.DataSource = dsLop.Tables[0];
            }
            else
            {
                cboLopHoc.DataSource = null;
            }
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "get_hocvien_phanlop";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                grdHocVien.DataSource = ds.Tables[0];
            }
            else
            {
                grdHocVien.DataSource = null;
            }
        }

        public DataSet GetHocVien(string ma_monhoc)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string strQuery = "get_hocvien_dangky_phanlop";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma_monhoc", ma_monhoc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Close();
                return ds;
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
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from mon_hoc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null & ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["ten_monhoc"] = "All";
                dr["ma_monhoc"] = "-1";
                ds.Tables[0].Rows.Add(dr);
                return ds;
            }
            else
                return null;
        }

        public DataSet GetLop()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from lop_hoc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null & ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
                return null;
        }

        private void cboMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsHocVien = GetHocVien(cboMaMH.SelectedValue.ToString());
            if (dsHocVien != null && dsHocVien.Tables.Count > 0 && dsHocVien.Tables[0].Rows.Count > 0)
            {
                grdHocVien.DataSource = dsHocVien.Tables[0];
            }
            else
            {
                grdHocVien.DataSource = null;
            }
        }

        private void cboMaMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from lop_hoc where ma_monhoc = '" + cboMaMH.SelectedValue.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            cboLopHoc.DataSource = ds;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from lop_hocvien where ma_lophoc = '"+ cboLopHoc.SelectedValue.ToString() +"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            MessageBox.Show("Tên lớp: " + cboLopHoc.Text.ToString() + "; Số lượng: " + dt.Rows.Count + " học viên", "Chi Tiết Lớp Học");
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = check_lophoc(cboLopHoc.Text);
            if(bResult == false)
            {
                MessageBox.Show("Lớp học đã đủ học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "insert into lop_hocvien values ('"+ cboLopHoc.SelectedValue + "', '"+ gridView.GetRowCellValue(gridView.FocusedRowHandle, "ma_hocvien") +"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã phân lớp thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadData();
        }

        private bool check_lophoc(string ma_lophoc)
        {
            conn = new SqlConnection(connectionString);
            if(conn.State == ConnectionState.Closed)
            {
                {
                    conn.Open();
                }
            }
            string query = "select count(ma_lophoc) as SoLuong from lop_hocvien where ma_lophoc = '"+ cboLopHoc.SelectedValue.ToString() +"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (Convert.ToInt32(ds.Tables[0].Rows[0]["SoLuong"].ToString()) > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
