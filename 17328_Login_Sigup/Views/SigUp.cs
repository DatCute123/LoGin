using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _17328_Login_Sigup.Model;
using _17328_Login_Sigup.Controllers;

namespace _17328_Login_Sigup
{
    public partial class SigUp : Form
    {
        string imageUrl = "";// Tạo 1 string để làm đường dẫn tới avatar
        public SigUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            of.ShowDialog(); // Sau khi chọn file thì of chứa 1 đường dẫn
            pictureBox1.Image = Image.FromFile(of.FileName); // Lấy đường dẫn để hiển thị ảnh
            DialogResult result = MessageBox.Show("Bạn có muốn đổi avatar ko", "Đổi avatar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Chúc mừng bạn đã trở thành weboo");
                pictureBox1.Image = Image.FromFile(of.FileName); // lấy đường dẫn để hiển thị ảnh
            }
            else
            {
                MessageBox.Show("Chúc mừng bạn đã trở thành weboo"); 
            }
            imageUrl = of.FileName;// gán đường dẫn sau khi đã chọn
        }

        private void bt_dk_Click(object sender, EventArgs e)
        {
            TaiKoanService tks = new TaiKoanService();
            FileService fs = new FileService();
            TaiKhoan taiKhoan = tks.TaoLaiTaiKhoanTuFrom(tbox_ten.Text, tbox_dc.Text, tbox_sdt.Text, cbbox_gt.Text,
                tbox_cc.Text, tbox_tk.Text, tbox_mk.Text, date_ns.Value, imageUrl);
            string path = @"E:\Ki III\NET103-C#3\17328_Login_Sigup\17328_Login_Sigup\TaiKhoans.xml";
            fs.WriteSVtoXML(path, taiKhoan);
            MessageBox.Show("Đăng ký thành công");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
