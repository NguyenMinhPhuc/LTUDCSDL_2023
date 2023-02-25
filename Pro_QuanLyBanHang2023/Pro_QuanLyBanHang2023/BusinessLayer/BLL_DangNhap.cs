using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyBanHang2023.BusinessLayer
{
   public class BLL_DangNhap
    {
        Database data;
        public BLL_DangNhap()
        {
            data = new Database();
        }

        //Phương thực lấy thông tin đăng nhập
        public SqlDataReader KiemTraDangNhap(ref string err,string tenDangNhap, string matKhau)
        {
            return data.ReadDataBySqlDataReader(ref err, "PSP_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau));
        }
    }
}
