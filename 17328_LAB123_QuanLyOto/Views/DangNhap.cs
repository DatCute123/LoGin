using _17328_LAB123_QuanLyOto.Controllers;
using _17328_LAB123_QuanLyOto.Models;
using _17328_LAB123_QuanLyOto.Views;

namespace _17328_LAB123_QuanLyOto
{
    public partial class from1 : Form
    {
        public from1()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (tbx_taiKhoan.Text.Trim() == "" || tbx_matKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                FileService fs = new FileService();
                SanPhamService sps = new SanPhamService();
                string path = @"E:\Ki III\NET103-C#3\17328_Login_Sigup\17328_LAB123_QuanLyOto\TaiKhoanXe.xml";
                List<SanPham> sanPhams = fs.ReadSVfromXML<SanPham>(path);
                if (sanPhams == null)
                {
                    MessageBox.Show("Chưa có tài khoản nào, bạn cần đăng ký đã nhé");
                }
                else
                {
                    SanPham sp = sps.KiemTraDangNhap(tbx_taiKhoan.Text, tbx_matKhau.Text);
                    if (sp == null)
                    {
                        MessageBox.Show("Chưa có tài khoản nào, bạn cần đăng ký đã nhé");
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        HienThiTK ht = new HienThiTK();
                        ht.sanPhams = sp;
                        ht.ShowDialog();
                    }

                }
            }
        }

        private void tbx_dangKy_Click(object sender, EventArgs e)
        {
            DangKy dky = new DangKy();
            dky.ShowDialog();
        }
    }
}