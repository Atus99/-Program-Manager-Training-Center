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
    public partial class ucHocPhi : UserControl
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        string error;
        public static string Status;
        public ucHocPhi()
        {
            InitializeComponent();
            SetControl("Reset");
            get_hocvien_donghoc();
            LoadData();
        }

        public void SetControl(string x)
        {
            switch (x)
            {
                case "Reset":

                    txtMaHV.Enabled = false;
                    txtTienDong.Enabled = false;
                    txtMaLH.Enabled = false;
                    txtHocPhi.Enabled = false;
                    cboHinhThuc.Enabled = false;

                    txtMaHV.Text = "";
                    txtHocPhi.Text = "";
                    txtTienDong.Text = "";

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;
                    break;

                case "Insert":

                    txtMaHV.Enabled = true;
                    txtHocPhi.Enabled = false;
                    txtTienDong.Enabled = true;
                    txtMaLH.Enabled = true;
                    cboHinhThuc.Enabled = true;

                    txtMaHV.Text = "";
                    txtHocPhi.Text = "";
                    txtTienDong.Text = "";

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;
                    break;

                case "Update":

                    txtMaHV.Enabled = false;
                    txtHocPhi.Enabled = false;
                    txtTienDong.Enabled = true;
                    txtMaLH.Enabled = false;
                    cboHinhThuc.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuyBo.Enabled = true;

                    break;
            }    
        }

        public void LoadData()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "get_hocphi";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grdHocPhi.DataSource = ds.Tables[0];
        }

        public void get_hocvien_donghoc()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "get_danhsach_donghoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grdDongHoc.DataSource = ds.Tables[0];
        }

        private void cboHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdDongHoc_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn column = info.Column;

                txtMaHV.Text = gridView.GetRowCellValue(row, "ma_hocvien").ToString();
                txtMaLH.Text = gridView.GetRowCellValue(row, "ma_lophoc").ToString();
                txtHocPhi.Text = gridView.GetRowCellValue(row, "hoc_phi").ToString();
            }
        }

        private void grdHocPhi_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn column = info.Column;

                txtMaHV.Text = gridView.GetRowCellValue(row, "ma_hocvien").ToString();
                txtMaLH.Text = gridView.GetRowCellValue(row, "ma_lophoc").ToString();
                cboHinhThuc.Text = gridView.GetRowCellValue(row, "hinhthuc_dong").ToString();
                txtHocPhi.Text = gridView.GetRowCellValue(row, "hoc_phi").ToString();
                txtTienDong.Text = gridView.GetRowCellValue(row, "da_dong").ToString();
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

        public bool Insert_hocphi()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "insert_hocphi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma_hocvien", txtMaHV.Text);
                cmd.Parameters.AddWithValue("@ma_lophoc", txtMaLH.Text);
                cmd.Parameters.AddWithValue("@id_taikhoan_hocphi", '1');
                cmd.Parameters.AddWithValue("@hinhthuc_dong", cboHinhThuc.Text);
                cmd.Parameters.AddWithValue("@hoc_phi", txtHocPhi.Text);
                cmd.Parameters.AddWithValue("@da_dong", txtTienDong.Text);
                cmd.Parameters.AddWithValue("@ngay_dong", DateTime.Now.ToString("dd/MM/yyyy"));
                //cmd.Parameters.AddWithValue("@trang_thai", '1');
                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Update_hocphi()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "update_hocphi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma_hocvien", txtMaHV.Text);
                cmd.Parameters.AddWithValue("@ma_lophoc", txtMaLH.Text);
                cmd.Parameters.AddWithValue("@id_taikhoan_hocphi", '1');
                cmd.Parameters.AddWithValue("@hinhthuc_dong", cboHinhThuc.Text);
                cmd.Parameters.AddWithValue("@hoc_phi", txtHocPhi.Text);
                cmd.Parameters.AddWithValue("@da_dong", txtTienDong.Text);
                //cmd.Parameters.AddWithValue("@ngay_dong", DateTime.Now.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@trang_thai", '1');
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bResult = false;
            if (Status == "Insert")
            {
                bResult = Insert_hocphi();
                if (bResult == true)
                {
                    SetControl("Reset");
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi thêm dữ liệu, kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(Status == "Update")
            {
                bResult = Update_hocphi();
                if (bResult == true)
                {
                    SetControl("Reset");
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi sửa dữ liệu, kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetControl("Reset");
        }
    }
}
