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
   public class BLL_LoaiChucNang
    {
        //Bước 1; tạo đối tường database và viết hàm tạo cho lớp để khởi tạo đối tượng Database.
        Database database;
        public BLL_LoaiChucNang()
        {
            database = new Database();
        }
        //Bước 2 Viết các phương thức tương ứng với các thao tác dữ liệu
        //Phương thức lấy danh sách Loại chức năng.
        public DataTable LayDanhSachLoaiChucNang(ref string err,string maLoaiChucNang)
        {
            return database.GetDataTable(ref err, "PSP_LoaiChucNang_Select", CommandType.StoredProcedure, new SqlParameter("@MaNhomChucNang", maLoaiChucNang));
        }
        //Phương thức insert và update dữ liệu
        public int InsertAndUpdate(ref string err,LoaiChucNang loaiChucNang)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaNhomChucNang",loaiChucNang.MaNhomChucNang),
                 new SqlParameter("@TenNhomChucNang",loaiChucNang.TenNhomChucNang)
            };
            return database.MyExcuteNonQuery(ref err, "PSP_LoaiChucNang_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }

        //Phương thuc delete
        public int DeleteNhomChucNang(ref string err, string maNhomChucNawng, bool isDelete)
        {

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaNhomChucNawng",maNhomChucNawng),
                 new SqlParameter("@IsDelete",isDelete)
            };
            return database.MyExcuteNonQuery(ref err, "PSP_LoaiChucNang_Delete", CommandType.StoredProcedure, sqlParameters);
        }
    }
}
