using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17328_LAB123_QuanLyOto.Models
{
    public class SanPham
    {
        public string TenXe { get; set; }
        public string HangSanXuatXe { get; set; }
        public string GiaXe { get; set; }
        public string SoLuongXe { get; set; }
        public string Username { get; set; }
        public string Passwrod { get; set; }
        public SanPham()
        {

        }

        public SanPham(string tenXe, string hangSanXuatXe, string giaXe, string soLuongXe, string username, string passwrod)
        {
            TenXe = tenXe;
            HangSanXuatXe = hangSanXuatXe;
            GiaXe = giaXe;
            SoLuongXe = soLuongXe;
            Username = username;
            Passwrod = passwrod;
        }
    }
}
