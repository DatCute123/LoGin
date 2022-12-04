using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17328_Login_Sigup.Model
{
    public class TaiKhoan
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string CanCuoc { get; set; }
        public string Username { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ImagePath { get; set; }

        public TaiKhoan()
        {

        }

        public TaiKhoan(string ten, string diaChi, string sDT, string gioiTinh, string canCuoc, string username, string matKhau, DateTime ngaySinh, string imagePath)
        {
            Ten = ten;
            DiaChi = diaChi;
            SDT = sDT;
            GioiTinh = gioiTinh;
            CanCuoc = canCuoc;
            Username = username;
            MatKhau = matKhau;
            NgaySinh = ngaySinh;
            ImagePath = imagePath;
        }
    }
}
