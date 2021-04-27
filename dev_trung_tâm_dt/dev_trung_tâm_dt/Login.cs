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
    public partial class Login : Form
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        string user;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string quyen = "admin";
                string query = "select * from account where ten_taikhoan = '" + txtUsername.Text + "' and mat_khau = '" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtUsername.Focus();
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
                        user = txtUsername.Text;
                        frmMain main = new frmMain(quyen, user);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại, kiểm tra lại thông tin tài khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
