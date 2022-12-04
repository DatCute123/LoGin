using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _17328_LAB123_QuanLyOto.Models;

namespace _17328_LAB123_QuanLyOto.Controllers
{
    internal class SanPhamService
    {
        public SanPham KiemTraDangNhap(string username, string password)
        {
            FileService fsv = new FileService();
            string path = @"E:\Ki III\NET103-C#3\17328_Login_Sigup\17328_LAB123_QuanLyOto\TaiKhoanXe.xml";
            List<SanPham> sanPhams = fsv.ReadSVfromXML<SanPham>(path);
            var account = sanPhams.FirstOrDefault(p=> p.Username == username && p.Passwrod == password);
            if (account == null) MessageBox.Show("Thông tin tài khoản bị sai");
            return account;
        }
        public SanPham TaoLaiTaiKhoanTuFrom(string tenXe, string hangSanXuatXe, string giaXe, string soLuongXe, string username, string passwrod)
        {
            return new SanPham(tenXe,hangSanXuatXe,giaXe,soLuongXe,username,passwrod);
        }
    }
}
