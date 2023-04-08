using Pro_QuanLyBanHang2023.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_QuanLyBanHang2023.NhapHang
{
    public partial class Frm_NhapHang : Form
    {
        public Frm_NhapHang()
        {
            InitializeComponent();
        }
        string maPhieuNhap = string.Empty;
        BLL_PhieuNhap bd;

        string err = string.Empty;
        private void Frm_NhapHang_Load(object sender, EventArgs e)
        {
            bd = new BLL_PhieuNhap();
            if (KiemTraPhieuNhapTonTaiTheoUser(ClsMain.maNhanVien))
            {
                //Co phieu nhap chua hoan thanh
                LoadThongTinTheoPhieuNhapCu(maPhieuNhap);
            }
            else
            {
                //khong co phieu nhap nao chua hoan thanh
                //tao phieu moi
               txtMaPhieuNhap.Text= TaoPhieuMoi();
                txtNhanVienNhap.Text = ClsMain.maNhanVien;
                //insert phieu nhap vao data.
                if(bd.InsertPhieuNhap(ref err, txtMaPhieuNhap.Text, dtpNgayNhap.Value, txtNhanVienNhap.Text)==0)
                {
                    MessageBox.Show("Chua insert");
                }
            }
        }
        DataTable dtChiTietPhieuNhap;
        private void LoadThongTinTheoPhieuNhapCu(string maPhieuNhap)
        {
            dtChiTietPhieuNhap = new DataTable();
            dtChiTietPhieuNhap = bd.LayDanhSachSanPhamTheoPhieuNhap(ref err, maPhieuNhap);
            dgvDanhSachSanPhamNhap.DataSource = dtChiTietPhieuNhap.DefaultView;
            if (dtChiTietPhieuNhap.Rows.Count > 0)
            {
                txtMaPhieuNhap.Text = dtChiTietPhieuNhap.Rows[0]["MaPhieuNhap"].ToString();
                txtNhanVienNhap.Text = dtChiTietPhieuNhap.Rows[0]["MaNhanVien"].ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(dtChiTietPhieuNhap.Rows[0]["NgayNhap"].ToString());
            }
            else
            {
                txtMaPhieuNhap.Text = maPhieuNhap;
                txtNhanVienNhap.Text = ClsMain.maNhanVien;
            }
        }

        private string TaoPhieuMoi()
        {
            string maPhieuNhap = string.Empty;
            maPhieuNhap = bd.SinhMaPhieuMoi(ref err);
            return maPhieuNhap;
        }

       /// <summary>
       /// Kiểm tra phiếu nhập tồn tại theo User
       /// </summary>
       /// <param name="maNhanVien">Mã nhân viên đăng nhập vào CT</param>
       /// <returns></returns>
        private bool KiemTraPhieuNhapTonTaiTheoUser(string maNhanVien)
        {
            bool result = false;
            maPhieuNhap = bd.LayPhieuNhapChuaHoanThanh(ref err, maNhanVien);
            if (maPhieuNhap.ToLower().Equals("no"))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
