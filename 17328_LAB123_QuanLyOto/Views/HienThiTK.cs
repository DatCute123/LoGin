using _17328_LAB123_QuanLyOto.Controllers;
using _17328_LAB123_QuanLyOto.Models;
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

namespace _17328_LAB123_QuanLyOto.Views
{
    public partial class HienThiTK : Form
    {
        public SanPham sanPhams { get; set; }
        public HienThiTK()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (sanPhams.Username.ToLower().Contains(""))
            {
                AllTaiKhoan atk = new AllTaiKhoan();
                atk.ShowDialog();
            }
            
        }

        private void HienThiTK_Load(object sender, EventArgs e)
        {
            tbx_ten.Text = sanPhams.TenXe;
            tbx_hangSanXutt.Text = sanPhams.HangSanXuatXe;
            tbx_Gia.Text = sanPhams.GiaXe;
            tbx_Soluong.Text = sanPhams.SoLuongXe;
            bool check = cb_ShowAll.Checked;
            tbx_ten.Enabled = check;
            tbx_hangSanXutt.Enabled = check;
            tbx_Gia.Enabled = check;
            tbx_Soluong.Enabled = check;
        }

        private void cb_ShowAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_ShowAll_Click(object sender, EventArgs e)
        {
            if (sanPhams.Username.ToLower().Contains(""))
            {
                AllTaiKhoan atk = new AllTaiKhoan();
                atk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn cần là admin để thực hiện tính năng này");
            }
        }

        private void cb_capNhatTT_CheckedChanged(object sender, EventArgs e)
        {
            bool check = cb_capNhatTT.Checked;
            tbx_ten.Enabled = check;
            tbx_hangSanXutt.Enabled = check;
            tbx_Gia.Enabled = check;
            tbx_Soluong.Enabled = check;
        }
    }
}
