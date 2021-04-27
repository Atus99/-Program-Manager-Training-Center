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
    public partial class frmThemGiangVien : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        public static string strError = "";
        public static string Status = "";
        SqlConnection conn;
        DataSet ds;
        string GioiTinh;
        public frmThemGiangVien()
        {
            InitializeComponent();
            SetControl();
        }

        public void SetControl()
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            txtCMTND.Text = "";
            txtQueQuan.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            dtpNgayLV.Text = "";
            cboTrangThai.Text = "";
            txtGhiChu.Text = "";
            txtDuongDan.Text = "";

            txtHoTen.Focus();
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
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(dtpNgaySinh.Text) || string.IsNullOrEmpty(txtQueQuan.Text) || string.IsNullOrEmpty(txtDuongDan.Text))
            {
                if (string.IsNullOrEmpty(txtHoTen.Text))
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
                conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into giang_vien values (@HoTen, @NgaySinh, @GioiTinh, @CMTND, @QueQuan, @SDT, @Email, @HocVan, @NgayBDLV, @TrangThai, @GhiChu, @Anh)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@CMTND", txtCMTND.Text);
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@HocVan", txtHocVan.Text);
                cmd.Parameters.AddWithValue("@NgayBDLV", dtpNgayLV.Value);
                cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@Anh", txtDuongDan.Text);
                cmd.ExecuteNonQuery();
                SetControl();
                MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControl();
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
