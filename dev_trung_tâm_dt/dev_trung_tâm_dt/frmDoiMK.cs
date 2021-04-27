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
    public partial class frmDoiMK : Form
    {
        public static string connectionString = @"Data Source=DESKTOP-I62I3KB\ADMIN;Initial Catalog=CSDL_Trung_Tâm_Đào_Tạo;User ID=sa;Password=123";
        SqlConnection conn;
        public frmDoiMK(string username)
        {
            InitializeComponent();
            txtUser.Text = username;
        }

        public void SetControl()
        {
            txtUser.Enabled = false;
            txtPass.Text = "Mật khẩu cũ";
            txtPass1.Text = "Mật khẩu mới";
            txtPass2.Text = "Nhập lại mật khẩu";
        }

        public bool Update()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "Update account set mat_khau = '" + txtPass1.Text.ToString() + "' where ten_taikhoan = '" + txtUser.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtPass1.Text) || string.IsNullOrEmpty(txtPass2.Text))
            {
                if (MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    txtPass.Focus();
            }
            else
            {
                if (KiemTra(txtPass.Text) == false)
                {
                    MessageBox.Show("Mật khẩu không đúng", "Thông Báo");
                    txtPass.Focus();
                }
                else if (txtPass1.Text != txtPass2.Text)
                {
                    MessageBox.Show("Mật khẩu mới không đúng, mới nhập lại");
                    txtPass1.Focus();
                }
                else
                {
                    var Uresult = Update();
                    if (Uresult == true)
                    {
                        SetControl();
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public bool KiemTra(string mat_khau)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "Select * from account where mat_khau = '" + txtPass.Text.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet data = new DataSet();
            adapter.Fill(data);
            if (data != null && data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtPass.Text = "Mật khẩu cũ";
            txtPass1.Text = "Mật khẩu mới";
            txtPass2.Text = "Nhập lại mật khẩu";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.Clear();
        }

        private void txtPass1_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass1.Clear();
        }

        private void txtPass2_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass2.Clear();
        }
    }
}
