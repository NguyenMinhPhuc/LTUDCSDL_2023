using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pro_QuanLyBanHang2023.BusinessLayer
{
  public  class BLL_PhieuNhap
    {
        Database data;
        public BLL_PhieuNhap()
        {
            data = new Database();
        }

        public string LayPhieuNhapChuaHoanThanh(ref string err,string maNhanVien)
        {
            return data.MyExcuteScalar(ref err, 
                "PSP_PhieuNhap_KiemTraPhieuTonTaiTheoUser", 
                CommandType.StoredProcedure, 
                new SqlParameter("@MaNhanVien",maNhanVien)).ToString();
        }

        public DataTable LayDanhSachSanPhamTheoPhieuNhap(ref string err,string maPhieuNhap)
        {
            return data.GetDataTable(ref err, "PSP_PhieuNhap_LoadDataPhieuNhapCu", CommandType.StoredProcedure, new SqlParameter("@MaPhieuNhap", maPhieuNhap));
        }

        public string SinhMaPhieuMoi(ref string err)
        {
            return data.MyExcuteScalar(ref err, "PSP_PhieuNhap_TaoPhieuMoi", CommandType.StoredProcedure, null).ToString();
        }
        public string SinhMaPhieuMoi(ref string err,DateTime ngayTaoPhieu)
        {
            return data.MyExcuteScalar(ref err, "PSP_PhieuNhap_TaoPhieuMoi", CommandType.StoredProcedure, new SqlParameter("@NgayTaoPhieu",ngayTaoPhieu)).ToString();
        }

        public int InsertPhieuNhap(ref string err, string maPhieuNhap, DateTime ngayNhap,string maNhanVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap", maPhieuNhap),
                 new SqlParameter("@NgayNhap", ngayNhap),
                  new SqlParameter("@MaNhanVien", maNhanVien)
            };
            return data.MyExcuteNonQuery(ref err, "PSP_PhieuNhap_Insert202303", CommandType.StoredProcedure, sqlParameters);
        }

        public int ThemSanPhamVaoPhieuNhap(ref string err,string maPhieuNhap,string maSP,int soLuongNhap,int donGia)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChiTietPhieuNhap_InsertAndUpdate", CommandType.StoredProcedure,
                new SqlParameter("@MaPhieuNhap",maPhieuNhap),
                new SqlParameter("@MaSP",maSP),
                new SqlParameter("@SoLuongNhap",soLuongNhap),
                new SqlParameter("@DonGiaNhap",donGia));
        }

        public int XacNhanPhieuNhapHoanThanh(ref string err, string maPhieuNhap) {
            return data.MyExcuteNonQuery(ref err, "PSP_PhieuNhap_XacNhanHoanThanh", CommandType.StoredProcedure, new SqlParameter("@MaPhieuNhap", maPhieuNhap));
        }

        internal int XoaChiTietPhieuNhap(ref string err, string maPhieuNhapXoa, string maSP)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChiTietPhieuNhap_XoaChiTietPhieuNhap", CommandType.StoredProcedure,
                new SqlParameter("@MaPhieuNhap", maPhieuNhapXoa),
                new SqlParameter("@MaSP", maSP));
        }
    }
}
