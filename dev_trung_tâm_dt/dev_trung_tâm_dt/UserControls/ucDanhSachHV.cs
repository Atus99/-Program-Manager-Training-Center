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

namespace dev_trung_tâm_dt.UserControls
{
    public partial class ucDanhSachHV : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        public static string strError = "";
        public static string Status = "";
        SqlConnection conn;
        DataSet ds;
        public ucDanhSachHV()
        {
            InitializeComponent();
            DataSet dsLop = new DataSet();
            dsLop = GetLop();
            if (dsLop != null && dsLop.Tables.Count > 0 && dsLop.Tables[0].Rows.Count > 0)
            {
                cboLopHoc.DisplayMember = "ten_lophoc";
                cboLopHoc.ValueMember = "ma_lophoc";
                cboLopHoc.DataSource = dsLop.Tables[0];

                cboLopHoc.SelectedValue = "-1";
            }
            else
            {
                cboLopHoc.DataSource = null;
            }
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "get_hocvien_lophoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            grdHocVien.DataSource = ds.Tables[0];
        }

        public DataSet GetLop()
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from lop_hoc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            if (ds != null & ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["ten_lophoc"] = "All";
                dr["ma_lophoc"] = "-1";
                ds.Tables[0].Rows.Add(dr);
                return ds;
            }
            else
                return null;
        }

        public DataSet GetHocVien(string ma_lophoc)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string strQuery = "get_danhsach_hocvien";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma_lophoc", ma_lophoc);
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

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsHocVien = GetHocVien(cboLopHoc.SelectedValue.ToString());
            if (dsHocVien != null && dsHocVien.Tables.Count > 0 && dsHocVien.Tables[0].Rows.Count > 0)
            {
                grdHocVien.DataSource = dsHocVien.Tables[0];
            }
            else
            {
                grdHocVien.DataSource = null;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
  
        }
    }
}
