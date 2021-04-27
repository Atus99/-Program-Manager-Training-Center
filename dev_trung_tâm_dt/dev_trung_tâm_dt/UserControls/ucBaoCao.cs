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
using dev_trung_tâm_dt.BaoCao;

namespace dev_trung_tâm_dt.UserControls
{
    public partial class ucBaoCao : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        DataSet ds;
        public ucBaoCao()
        {
            InitializeComponent();
            //report_hocvien();
        }

        public void report_hocvien()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "report_hocvien_thang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@thang", 7 / 7 / 2029);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].TableName = "report_hocvien_thang";
                    //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                    Danhsach_Hocvien _bc = new Danhsach_Hocvien();
                    _bc.SetDataSource(ds.Tables[0]);
                    _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                    printBaoCao.ReportSource = _bc;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
            }
        }

        #region soLuong_hocvien
        public void soluong_hocvien()
            {
                if (rdoNgay.Checked == true)
                {
                    try
                    {
                        conn = new SqlConnection(connectionString);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string query = "soluong_hocvien_ngay";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@tu_ngay", 1 / 1 / 2010);
                        cmd.Parameters.AddWithValue("@den_ngay", DateTime.Now);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            ds.Tables[0].TableName = "soluong_hocvien_ngay";
                            //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                            Danhsach_Hocvien _bc = new Danhsach_Hocvien();
                            _bc.SetDataSource(ds.Tables[0]);
                            _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                            printBaoCao.ReportSource = _bc;
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

                else if (rdoThang.Checked == true)
                {
                    try
                    {
                        conn = new SqlConnection(connectionString);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string query = "report_hocvien_thang";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@thang", cboThang.Text.Trim());

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            ds.Tables[0].TableName = "report_hocvien_thang";
                            //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                            Danhsach_Hocvien _bc = new Danhsach_Hocvien();
                            _bc.SetDataSource(ds.Tables[0]);
                            _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                            printBaoCao.ReportSource = _bc;
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

                else if (rdoQuy.Checked == true)
                {
                    try
                    {
                        conn = new SqlConnection(connectionString);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string query = "report_hocvien_quy";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@quy", cboQuy.Text.Trim());

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            ds.Tables[0].TableName = "report_hocvien_quy";
                            //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                            Danhsach_Hocvien _bc = new Danhsach_Hocvien();
                            _bc.SetDataSource(ds.Tables[0]);
                            _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                            printBaoCao.ReportSource = _bc;
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (rdoNam.Checked == true)
                {
                    try
                    {
                        conn = new SqlConnection(connectionString);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string query = "report_hocvien_nam";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nam", txtNam.Text.Trim());

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            ds.Tables[0].TableName = "report_hocvien_nam";
                            //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                            Danhsach_Hocvien _bc = new Danhsach_Hocvien();
                            _bc.SetDataSource(ds.Tables[0]);
                            _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                            printBaoCao.ReportSource = _bc;
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        #endregion

        #region khoa_hoc
        public void Khoa_Hoc()
        {
            if(rdoNgay.Checked == true)
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "report_khoahoc_ngay";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tu_ngay", dtpTuNgay.Value);
                cmd.Parameters.AddWithValue("@den_ngay", dtpDenNgay.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].TableName = "report_khoahoc_ngay";
                    //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                    report_khoahoc_ngay _bc = new report_khoahoc_ngay();
                    _bc.SetDataSource(ds.Tables[0]);
                    _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                    printBaoCao.ReportSource = _bc;
                }
            }
            else if(rdoThang.Checked == true)
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "report_khoahoc_thang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@thang", cboThang.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].TableName = "report_khoahoc_thang";
                    //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                    report_khoahoc_ngay _bc = new report_khoahoc_ngay();
                    _bc.SetDataSource(ds.Tables[0]);
                    _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                    printBaoCao.ReportSource = _bc;
                }
            }
            else if (rdoQuy.Checked == true)
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "report_khoahoc_quy";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@quy", cboQuy.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].TableName = "report_khoahoc_quy";
                    //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                    report_khoahoc_ngay _bc = new report_khoahoc_ngay();
                    _bc.SetDataSource(ds.Tables[0]);
                    _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                    printBaoCao.ReportSource = _bc;
                }
            }
            else if (rdoNam.Checked == true)
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "report_khoahoc_nam";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nam", txtNam.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].TableName = "report_khoahoc_nam";
                    //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                    report_khoahoc_ngay _bc = new report_khoahoc_ngay();
                    _bc.SetDataSource(ds.Tables[0]);
                    _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                    printBaoCao.ReportSource = _bc;
                }
            }


        }
        #endregion

        #region Hoc_phi
        public void Hoc_Phi()
        {
            if (rdoNgay.Checked == true)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "soluong_hocvien_ngay";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@tu_ngay", 1 / 1 / 2010);
                    cmd.Parameters.AddWithValue("@den_ngay", DateTime.Now);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Tables[0].TableName = "soluong_hocvien_ngay";
                        //ds.WriteXmlSchema("D://file log//report_hocphi.xsd");

                        Danhsach_Hocvien _bc = new Danhsach_Hocvien();
                        _bc.SetDataSource(ds.Tables[0]);
                        _bc.SetParameterValue("@thoigian", DateTime.Now.ToString("dd/MM/yyyy"));
                        printBaoCao.ReportSource = _bc;
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        #endregion
        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            if (rdoSoLuongHV.Checked == true)
            {
                    soluong_hocvien();
            }
            else if(rdoKhoahoc.Checked == true)
            {
                Khoa_Hoc();
            }
        }
    }
}
