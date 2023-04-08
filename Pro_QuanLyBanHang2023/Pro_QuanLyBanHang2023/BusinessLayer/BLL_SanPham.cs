using DataLayer;
using Pro_QuanLyBanHang2023.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable LayDanhSachSanPhamAllOrByID(ref string err,string maSP)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                  new SqlParameter("@MaSP", maSP)
            };
            return database.LayDuLieuTheoDangBang(ref err, "PSP_SanPham_Select230204", CommandType.StoredProcedure, sqlParameters
              );
        }
        public DataTable LayDonViTinhCbo(ref string err)
        {
            return database.LayDuLieuTheoDangBang(ref err, "PSP_DonViTinh_SelectCbo230304", CommandType.StoredProcedure, null);
        }

        public int InsertSanPham(ref string err, SanPham sanPham)
        {
            return database.MyExcuteNonQuery(ref err, "PSP_SanPham_InsertAndUpdate230304", CommandType.StoredProcedure,
                new SqlParameter("@MaSP", sanPham.MaSP),
                new SqlParameter("@TenSP", sanPham.TenSP),
                new SqlParameter("@SoTon", sanPham.SoTon),
                new SqlParameter("@MaDVT", sanPham.MaDVT));
        }
    }
}
