using _17328_Login_Sigup.Model;
using _17328_Login_Sigup.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17328_Login_Sigup
{
    public partial class Infor : Form
    {
        public TaiKhoan Taikhoans { get; set; } // thêm cái này để truyền dữ liệu giữa các form
        public Infor()
        {
            InitializeComponent();
        }

        private void Infor_Load(object sender, EventArgs e)// Skien sảy ra khi form được load
        {
            tbox_ten.Text = Taikhoans.Ten;
            tbox_dc.Text = Taikhoans.DiaChi;
            tbox_sdt.Text = Taikhoans.SDT;
            tbox_cc.Text = Taikhoans.CanCuoc;
            cbbox_gt.Text = Taikhoans.GioiTinh;
            date_nsinh.Value = Taikhoans.NgaySinh;
            ptb_avatar.Image = Image.FromFile(Taikhoans.ImagePath);
            // Khi chưa check vào checkbox tôi muốn... thì không cho phép sửa
            bool check = cb_CapNhat.Checked;
            tbox_ten.Enabled = check;
            tbox_dc.Enabled = check;
            tbox_cc.Enabled = check;
            tbox_sdt.Enabled = check;
            cbbox_gt.Enabled = check;
            date_nsinh.Enabled = check; // Các control ban đầu đều Disable
            bt_CapnhatAnh.Visible = check;
            bt_CapnhatTT.Visible = check;
        }

        private void cb_CapNhat_CheckedChanged(object sender, EventArgs e)
        {
            bool check = cb_CapNhat.Checked;
            tbox_ten.Enabled = check;
            tbox_dc.Enabled = check;
            tbox_cc.Enabled = check;
            tbox_sdt.Enabled = check;
            cbbox_gt.Enabled = check;
            date_nsinh.Enabled = check; // Các control ban đầu đều Disable
            bt_CapnhatAnh.Visible = check;
            bt_CapnhatTT.Visible = check;
        }

        private void btn_ShowAllTk_Click(object sender, EventArgs e)
        {
            if (Taikhoans.Username.ToLower().Contains("admin"))
            {
                AllTaiKhoan atk = new AllTaiKhoan();
                atk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn cần là admin để thực hiện tính năng này");
            }
        }
    }
}
