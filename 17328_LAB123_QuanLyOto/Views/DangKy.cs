using _17328_LAB123_QuanLyOto.Controllers;
using _17328_LAB123_QuanLyOto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17328_LAB123_QuanLyOto.Views
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            SanPhamService sps = new SanPhamService();
            FileService fs = new FileService();
            SanPham sanPham = sps.TaoLaiTaiKhoanTuFrom(tbx_Tenxe.Text,cbb_hangSanxuat.Text,tbx_giaca.Text,tbx_soluong.Text,
                tbx_tkDky.Text,tbx_mkDky.Text);
            string path = @"E:\Ki III\NET103-C#3\17328_Login_Sigup\17328_LAB123_QuanLyOto\TaiKhoanXe.xml";
            fs.WriteSVtoXML(path, sanPham);
            MessageBox.Show("Đăng ký thành công");
        }
    }
}
