using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Data.Entity;
using System.Data.SqlClient;
using dev_trung_tâm_dt.UserControls;

namespace dev_trung_tâm_dt
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmHocVien hocvien;
        frmKhoaHoc khoahoc;
        ucLopHoc lophoc;
        ucMonHoc monhoc;
        ucNhanVien nhanvien;
        ucGiangVien giangvien;
        ucThongKe thongke;
        ucBangLuong bangluong;
        ucTest test;
        ucDangKyHoc dangkyhoc;
        //ucBaoCao baocao;
        ucPhanLop phanlop;
        ucHopDong hopdong;
        ucDanhSachHV danhsach;
        ucChucVu chucvu;
        ucTaiKhoan taikhoan;
        ucHocPhi hocphi;
        string username;
        public frmMain(string quyen, string user)
        {
            InitializeComponent();
            username = user;
            if (quyen == "Admin")
            {
                btnTaiKhoan.Enabled = true;
            }
            else if (quyen == "Users")
            {
                btnTaiKhoan.Enabled = false;
            }
            hocvien = new frmHocVien();
            pnlMain.Controls.Add(hocvien);
            khoahoc = new frmKhoaHoc();
            pnlMain.Controls.Add(khoahoc);
            lophoc = new ucLopHoc();
            pnlMain.Controls.Add(lophoc);
            monhoc = new ucMonHoc();
            pnlMain.Controls.Add(monhoc);
            nhanvien = new ucNhanVien();
            pnlMain.Controls.Add(nhanvien);
            giangvien = new ucGiangVien();
            pnlMain.Controls.Add(giangvien);
            thongke = new ucThongKe();
            pnlMain.Controls.Add(thongke);
            bangluong = new ucBangLuong();
            pnlMain.Controls.Add(bangluong);
            test = new ucTest();
            pnlMain.Controls.Add(test);
            dangkyhoc = new ucDangKyHoc();
            pnlMain.Controls.Add(dangkyhoc);
            //baocao = new ucBaoCao();
            //pnlMain.Controls.Add(baocao);
            phanlop = new ucPhanLop();
            pnlMain.Controls.Add(phanlop);
            hopdong = new ucHopDong();
            pnlMain.Controls.Add(hopdong);
            danhsach = new ucDanhSachHV();
            pnlMain.Controls.Add(danhsach);
            chucvu = new ucChucVu();
            pnlMain.Controls.Add(chucvu);
            taikhoan = new ucTaiKhoan();
            pnlMain.Controls.Add(taikhoan);
            hocphi = new ucHocPhi();
            pnlMain.Controls.Add(hocphi);

            hocvien.Show();
            hocvien.Dock = DockStyle.Fill;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnHocVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            hocvien.Show();
            hocvien.Dock = DockStyle.Fill;
            khoahoc.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            bangluong.Hide();
            test.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnKhoaHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            khoahoc.Show();
            khoahoc.Dock = DockStyle.Fill;
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            thongke.Hide();
            bangluong.Hide();
            test.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            lophoc.Show();
            lophoc.Dock = DockStyle.Fill;
            hocvien.Hide();
            khoahoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            bangluong.Hide();
            test.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            monhoc.Show();
            monhoc.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            bangluong.Hide();
            test.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            nhanvien.Show();
            nhanvien.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            giangvien.Hide();
            thongke.Hide();
            bangluong.Hide();
            test.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnGiangVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            test.Show();
            test.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            thongke.Hide();
            bangluong.Hide();
            giangvien.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide(); 
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            thongke.Show();
            thongke.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            bangluong.Hide();
            test.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnBangLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            bangluong.Show();
            bangluong.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnDangKyHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            dangkyhoc.Show();
            dangkyhoc.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            bangluong.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            //baocao.Show();
            //baocao.Dock = DockStyle.Fill;
            //khoahoc.Hide();
            //hocvien.Hide();
            //lophoc.Hide();
            //monhoc.Hide();
            //nhanvien.Hide();
            //giangvien.Hide();
            //thongke.Hide();
            //test.Hide();
            //bangluong.Hide();
            //dangkyhoc.Hide();
            //phanlop.Hide();
            //hopdong.Hide();
            //danhsach.Hide();
            //chucvu.Hide();
            //taikhoan.Hide();
            //hocphi.Hide();
        }

        private void btnPhanLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            phanlop.Show();
            phanlop.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            bangluong.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            hopdong.Show();
            hopdong.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            bangluong.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }

        private void btnDanhSachHV_ItemClick(object sender, ItemClickEventArgs e)
        {
            danhsach.Show();
            danhsach.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            bangluong.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            chucvu.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }
        private void btnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            chucvu.Show();
            chucvu.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            bangluong.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            taikhoan.Hide();
            hocphi.Hide();
        }
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            taikhoan.Show();
            taikhoan.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            bangluong.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            hocphi.Hide();
        }

        private void btnHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            hocphi.Show();
            hocphi.Dock = DockStyle.Fill;
            khoahoc.Hide();
            hocvien.Hide();
            lophoc.Hide();
            monhoc.Hide();
            nhanvien.Hide();
            giangvien.Hide();
            thongke.Hide();
            test.Hide();
            bangluong.Hide();
            dangkyhoc.Hide();
            //baocao.Hide();
            phanlop.Hide();
            hopdong.Hide();
            danhsach.Hide();
            chucvu.Hide();
            taikhoan.Hide();
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmDoiMK doiMK = new frmDoiMK(username);
            //doiMK.Show();
        }
    }
}