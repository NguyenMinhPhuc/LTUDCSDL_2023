using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyBanHang2023.BusinessLayer
{
   public class BLL_SanPham
    {
        Database database;
        public BLL_SanPham()
        {
            database = new Database();
        }

        public SqlDataReader LayDanhSachSanPham(ref string err,string maSP)
        {
            return database.ReadDataBySqlDataReader(ref err, "PSP_SanPham_Select230225", System.Data.CommandType.StoredProcedure, new SqlParameter("@MaSP", maSP));
        }

        public object LayMaxIDSanPham(ref string err)
        {
            return database.MyExcuteScalar(ref err, "PSP_SanPham_MaxID", System.Data.CommandType.StoredProcedure, null);
        }
    }
}
