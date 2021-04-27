using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev_trung_tâm_dt
{
    public partial class SendToMail : Form
    {
        Attachment attach = null;
        string mail;
        public SendToMail(string email)
        {
            mail = email;
            InitializeComponent();
            SetControl();
        }

        public void SetControl()
        {
            txtTo.Enabled = false;
            txtFile.Enabled = false;
            txtTieuDe.Enabled = true;
            txtNoiDung.Enabled = true;
            txtTo.Text = mail;

            txtFile.Text = "";
            txtTieuDe.Text = "";
            txtNoiDung.Text = "";

            btnGui.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show("Bạn chưa điền mail người nhận", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTo.Focus();
            }
            else
            {
                Gui();
            }
        }

        public void Gui()
        {
            attach = null;
            try
            {
                FileInfo file = new FileInfo(txtFile.Text);
                attach = new Attachment(txtFile.Text);
            }
            catch { }

            SendMail("pttu99@gmail.com", txtTo.Text, txtTieuDe.Text, txtNoiDung.Text, attach);
        }

        public void SendMail(string from, string to, string subject, string body, Attachment file)
        {
            try
            {
                MailMessage mess = new MailMessage(from, to, subject, body);
                if(attach != null)
                {
                    mess.Attachments.Add(attach);
                }
                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                smt.Credentials = new NetworkCredential("pttu99@gmail.com", "anhtu060799");
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(mess);

                MessageBox.Show("Gửi mail thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControl();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = file.FileName;
            }    
        }
    }
}
