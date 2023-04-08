using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyBanHang2023.DTO
{
   public class SanPham
    {
        string maSP, tenSP;
        int soTon, maDVT;

        public string MaSP { get { return maSP; } set { maSP = value; } }
        public string TenSP { get { return tenSP; } set { tenSP = value; } }
        public int SoTon { get { return soTon; } set { soTon = value; } }
        public int MaDVT { get { return maDVT; } set { maDVT = value; } }
    }
}
