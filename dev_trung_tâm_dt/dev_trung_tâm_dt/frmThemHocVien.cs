using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev_trung_tâm_dt
{
    public partial class frmThemHocVien : Form
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        public static string strError = "";
        public static string Status = "";
        SqlConnection conn;
        string trangthai;
        DataSet ds;
        string GioiTinh;
        public frmThemHocVien(string State)
        {
            InitializeComponent();
            trangthai = State;
            SetControl();
        }

        public void SetControl()
        {
            txtMaHV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            txtCMTND.Text = "";
            txtQueQuan.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            dtpNgayNhapHoc.Text = "";
            cboTrangThai.Text = "";
            cboTrangThai.SelectedIndex = 1;
            cboTrangThai.Enabled = false;
            txtGhiChu.Text = "";
            txtDuongDan.Text = "";

            txtMaHV.Focus();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(open.FileName);
                string path = open.FileName;
                txtDuongDan.Text = path;
            }
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rdoNam.Checked == true)
            {
                GioiTinh = "Nam";

            }
            else
            {
                GioiTinh = "Nữ";
            }
            if (string.IsNullOrEmpty(txtMaHV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(dtpNgaySinh.Text) || string.IsNullOrEmpty(txtQueQuan.Text) || string.IsNullOrEmpty(txtDuongDan.Text))
            {
                if (string.IsNullOrEmpty(txtMaHV.Text))
                {
                    MessageBox.Show("Bạn chưa điền mã học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHV.Focus();
                }
                else if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    MessageBox.Show("Bạn chưa điền họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                }
                else if (string.IsNullOrEmpty(dtpNgaySinh.Text))
                {
                    MessageBox.Show("Bạn chưa điền ngày sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgaySinh.Focus();
                }
                else if (string.IsNullOrEmpty(txtQueQuan.Text))
                {
                    MessageBox.Show("Bạn chưa điền quê quán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQueQuan.Focus();
                }
                else if (string.IsNullOrEmpty(txtDuongDan.Text))
                {
                    MessageBox.Show("Bạn chưa có ảnh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if(trangthai == "them")
                {
                    if (KiemTra(txtMaHV.Text) == false)
                    {
                        MessageBox.Show("Đã tồn tại mã học viên trong kho dữ liệu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtMaHV.Focus();
                        return;
                    }
                    else
                    {
                        conn = new SqlConnection(connectionString);
                        conn.Open();
                        string query = "Insert into hoc_vien values (@MaHV, @HoTen, @NgaySinh, @GioiTinh, @CMTND, @QuocTich, @QueQuan, @SDT, @Email, @NgayNhapHoc, @TrangThai, @GhiChu, @Anh)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaHV", txtMaHV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        cmd.Parameters.AddWithValue("@CMTND", txtCMTND.Text);
                        cmd.Parameters.AddWithValue("@QuocTich", txtQuocTich.Text);
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NgayNhapHoc", dtpNgayNhapHoc.Value);
                        cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                        cmd.Parameters.AddWithValue("@Anh", txtDuongDan.Text);
                        cmd.ExecuteNonQuery();
                        SetControl();
                        MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }    
                else if(trangthai == "sua")
                {
                    conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "update_hocvien";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma_hocvien", txtMaHV.Text);
                    cmd.Parameters.AddWithValue("@ho_ten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@ngay_sinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@gioi_tinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@cmtnd", txtCMTND.Text);
                    cmd.Parameters.AddWithValue("@quoc_tich", txtQuocTich.Text);
                    cmd.Parameters.AddWithValue("@que_quan", txtQueQuan.Text);
                    cmd.Parameters.AddWithValue("@so_dien_thoai", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ngay_nhap_hoc", dtpNgayNhapHoc.Value);
                    cmd.Parameters.AddWithValue("@trang_thai", cboTrangThai.Text);
                    cmd.Parameters.AddWithValue("@ghi_chu", txtGhiChu.Text);
                    cmd.Parameters.AddWithValue("@anh", txtDuongDan.Text);
                    cmd.ExecuteNonQuery();
                    SetControl();
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
        }

        public bool KiemTra(string MaHV)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "Select * from hoc_vien where ma_hocvien = '" + txtMaHV.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();

            if (data != null && data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            else { return true; }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControl();
        }
    }
}
