using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyBanHang2023.DTO
{
    public class LoaiChucNang
    {
        int maNhomChucNang;
        string tenNhomChucNang;
        bool isDelete;

        public int MaNhomChucNang
        {
            get{return maNhomChucNang; }
            set{maNhomChucNang = value;}
        }
        public string TenNhomChucNang
        {
            get { return tenNhomChucNang; }
            set { tenNhomChucNang = value; }
        }
        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
    }
}
