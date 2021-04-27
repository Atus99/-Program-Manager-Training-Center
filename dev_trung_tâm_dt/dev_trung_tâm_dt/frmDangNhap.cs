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
    public partial class frmDangNhap : Form
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        string quyen;
        string user;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            txtPass.Text = txtShow.Text;
            try
            {

                conn = new SqlConnection(connectionString);
                conn.Open();
                string user = txtUser.Text;
                string pass = txtShow.Text;
                string query = "select * from account where ten_taikhoan = '" + user + "' and mat_khau = '" + pass + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    if (string.IsNullOrEmpty(txtUser.Text))
                    {
                        MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtUser.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtPass.Focus();
                    }
                }
                else
                {
                    if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
                    {
                        quyen = dt.Tables[0].Rows[0]["quyen"].ToString();
                        user = txtUser.Text;
                        frmMain main = new frmMain(quyen, user);
                        main.Show();
                        if(quyen == "Admin")
                        {
                            MessageBox.Show("Chào mừng quản trị viên '" + txtUser.Text + "' đến với hệ thống", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }    
                        else if(quyen == "Users")
                        {
                            MessageBox.Show("Chào mừng người dùng '" + txtUser.Text + "' đến với hệ thống", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }    
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại, kiểm tra lại thông tin tài khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    conn.Close();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtShow.Clear();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtShow.Hide();
        }

        private void picShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtShow.Show();
        }

        private void txtShow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtShow.Clear();
            txtShow.PasswordChar = '•';
        }

        private void txtUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtUser.Text = "";
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtPass.Text = txtShow.Text;
        }
    }
}
