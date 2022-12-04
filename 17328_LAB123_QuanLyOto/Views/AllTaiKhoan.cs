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

namespace _17328_Login_Sigup.Views
{
    public partial class AllTaiKhoan : Form
    {
        public AllTaiKhoan()
        {
            InitializeComponent();
        }

        private void AllTaiKhoan_Load(object sender, EventArgs e)
        {
            // fake data tài khoản 
            List<SanPham> sanPhams = new List<SanPham>()
            {
                new SanPham("Oto","Toyota","100 triệu","10 nghìn xe","thanhndph23682","thanh123456"),
                new SanPham("Oto","Huyndai","80 triệu","12 nghìn xe","quannxph25874","quan123456"),
                new SanPham("Oto","Honda","90 triệu","1 nghìn xe","namntph25721","nam123456"),
                new SanPham("Oto","Mercedes","3 tỷ","15 xe","namnhph24458","nam123654"),
                new SanPham("Oto","BMW","10 tỷ","10 xe","huynbpn21445","huy123456"),
            };
            //Gán datasource của datagridview = List fake
            dtg_Show.DataSource = sanPhams;
            //Đổi tên cột trong datagridview
            dtg_Show.Columns[0].HeaderCell.Value = "Cột đầu tiên";
        }
    }
}