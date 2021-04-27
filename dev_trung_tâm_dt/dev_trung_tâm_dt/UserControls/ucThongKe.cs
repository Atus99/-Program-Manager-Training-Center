using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraCharts;

namespace dev_trung_tâm_dt.UserControls
{
    public partial class ucThongKe : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public ucThongKe()
        {
            InitializeComponent();

            DataSet dsTuoi = new DataSet();
            dsTuoi = GetTuoi();

            chartControl2.DataSource = dsTuoi.Tables[0];
            Series s1 = new Series("Tuổi", ViewType.Pie);
            s1.Name = "Số lượng học viên theo tuổi";
            foreach (DataRow dr in dsTuoi.Tables[0].Rows)
            {
                s1.Points.Add(new SeriesPoint(dr["tuoi"].ToString(), Convert.ToInt32(dr["so_luong"].ToString())));
            }
            chartControl1.Series.Add(s1);

            //gioi tinh

            DataSet dsGioiTinh = new DataSet();
            dsGioiTinh = GetGioiTinh();

            chartControl2.DataSource = dsGioiTinh.Tables[0];
            Series s2 = new Series("Series 2", ViewType.Pie3D);
            s2.Name = "Số lượng học viên";
            foreach (DataRow dr in dsGioiTinh.Tables[0].Rows)
            {
                s2.Points.Add(new SeriesPoint(dr["gioi_tinh"].ToString(), Convert.ToInt32(dr["tong"].ToString())));
            }
            chartControl2.Series.Add(s2);

            //lophoc_khoahoc

            DataSet dslophoc = new DataSet();
            dslophoc = GetLopHoc_KhoaHoc();

            chartControl3.DataSource = dslophoc.Tables[0];
            Series s3 = new Series("Series 3", ViewType.Bar);
            s3.Name = "Số lương lớp học theo khóa học";
            foreach (DataRow dr in dslophoc.Tables[0].Rows)
            {
                s3.Points.Add(new SeriesPoint(dr["ten_khoahoc"].ToString(), Convert.ToInt32(dr["tong"].ToString())));
            }
            chartControl3.Series.Add(s3);

            //so luong hoc vien
            DataSet dsTGDangKy = new DataSet();
            dsTGDangKy = GetTGDangKy();

            chartControl4.DataSource = dsTGDangKy.Tables[0];
            Series s4 = new Series("Series 4", ViewType.Spline);
            s4.Name = "Số lương học viên theo thời gian đăng ký";
            foreach (DataRow dr in dsTGDangKy.Tables[0].Rows)
            {
                s4.Points.Add(new SeriesPoint(dr["nam"].ToString(), Convert.ToInt32(dr["soluong"].ToString())));
            }
            chartControl4.Series.Add(s4);
        }

        public DataSet GetTuoi()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string storeName = "get_soluong_tuoi";
                SqlCommand cmd = new SqlCommand(storeName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet GetGioiTinh()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string storeName = "get_gioitinh_hocvien";
                SqlCommand cmd = new SqlCommand(storeName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet GetLopHoc_KhoaHoc()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string storeName = "get_lophoc_khoahoc";
                SqlCommand cmd = new SqlCommand(storeName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet GetTGDangKy()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string storeName = "get_thoigian_dangky";
                SqlCommand cmd = new SqlCommand(storeName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
