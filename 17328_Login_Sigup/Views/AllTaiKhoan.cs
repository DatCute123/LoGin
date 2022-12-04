using _17328_Login_Sigup.Model;
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
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>()
            {
                new TaiKhoan("1","a","1","1","1","1","1",DateTime.Now,"1"),
                new TaiKhoan("2","bb","1","1","1","1","1",DateTime.Now,"1"),
                new TaiKhoan("3","ccc","1","1","1","1","1",DateTime.Now,"1"),
                new TaiKhoan("4","dd","1","1","1","1","1",DateTime.Now,"1"),
                new TaiKhoan("5","e","1","1","1","1","1",DateTime.Now,"1"),
            };
            //Gán datasource của datagridview = List fake
            dtg_Show.DataSource = taiKhoans;
            //Đổi tên cột trong datagridview
            dtg_Show.Columns[0].HeaderCell.Value = "Cột đầu tiên";
        }
    }
}