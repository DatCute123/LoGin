using _17328_Login_Sigup.Model;
using _17328_Login_Sigup.Controllers;

namespace _17328_Login_Sigup
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void quen_mk_Click(object sender, EventArgs e)
        {

        }

        private void d_nhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem các thông tin đã được điền chưa
            if (tbox_dn.Text.Trim() == "" || tbox_mk.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (!check.Checked)// Khi chưa check tôi kp người máy
            {
                MessageBox.Show("Bạn là người máy à");
            }else
            {
                FileService fs = new FileService();
                TaiKoanService tks = new TaiKoanService();
                string path = @"E:\Ki III\NET103-C#3\17328_Login_Sigup\17328_Login_Sigup\TaiKhoans.xml";
                List<TaiKhoan> TaiKhoans = fs.ReadSVfromXML<TaiKhoan>(path);
                if (TaiKhoans == null)
                {
                    MessageBox.Show("Chưa có tài khoản nào, bạn cần đăng ký đã nhé");
                }
                else
                {
                    TaiKhoan tk = tks.KiemTraDangNhap(tbox_dn.Text, tbox_mk.Text);
                    if (tk == null)
                    {
                        MessageBox.Show("Chưa có tài khoản nào, bạn cần đăng ký đã nhé");
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        Infor inf = new Infor(); // Khi thành công gọi form infor
                        inf.Taikhoans = tk; // Gán gtri tài khoản của infor = tk vừa đăng nhập
                        inf.ShowDialog();
                    }
                    
                }
                
            }
        }

        private void dky_tk_MouseHover(object sender, EventArgs e)
        {
            dky_tk.ForeColor = Color.YellowGreen;
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ten_dn_Click(object sender, EventArgs e)
        {

        }

        private void m_khau_Click(object sender, EventArgs e)
        {

        }

        private void dky_tk_Click(object sender, EventArgs e)
        {
            SigUp sn = new SigUp();
            sn.ShowDialog();
        }
    }
}