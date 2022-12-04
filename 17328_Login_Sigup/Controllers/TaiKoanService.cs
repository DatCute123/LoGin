using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _17328_Login_Sigup.Model;

namespace _17328_Login_Sigup.Controllers
{
    internal class TaiKoanService
    {
        public TaiKhoan KiemTraDangNhap(string username, string password)
        {
            FileService fsv = new FileService();
            string path = @"E:\Ki III\NET103-C#3\17328_Login_Sigup\17328_Login_Sigup\TaiKhoans.xml";
            List<TaiKhoan> TaiKhoans = fsv.ReadSVfromXML<TaiKhoan>(path);
            var account = TaiKhoans.FirstOrDefault(p=> p.Username == username && p.MatKhau == password);
            if (account == null) MessageBox.Show("Thông tin tài khoản bị sai");
            return account;
        }
        public TaiKhoan TaoLaiTaiKhoanTuFrom(string ten, string diaChi, string sDT, string gioiTinh, string canCuoc, string username, string matKhau, DateTime ngaySinh, string imagePath)
        {
            return new TaiKhoan(ten, diaChi,sDT,gioiTinh,canCuoc,username,matKhau,ngaySinh,imagePath);
        }
    }
}
