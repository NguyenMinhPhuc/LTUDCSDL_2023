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

        #region Khai báo biến toàn cục của Class Frm_NhapHang
        string maPhieuNhap = string.Empty;
        BLL_PhieuNhap bd;

        string err = string.Empty;
        DataTable dtChiTietPhieuNhap;

        int tongSoLuong = 0;
        int tongThanhTien = 0;
        bool phieuNhapHoanThanh = false;//Kiểm soát việc thay đổi Maphieu theo ngày.
        #endregion

        #region Các sự kiện trong form Frm_NhapHang
        private void Frm_NhapHang_Load(object sender, EventArgs e)
        {
            bd = new BLL_PhieuNhap();
            if (KiemTraPhieuNhapTonTaiTheoUser(ClsMain.maNhanVien))
            {
                //Co phieu nhap chua hoan thanh
                LoadThongTinTheoPhieuNhapCu(maPhieuNhap);
                phieuNhapHoanThanh = false;
            }
            else
            {
                //khong co phieu nhap nao chua hoan thanh
                //tao phieu moi
                txtMaPhieuNhap.Text = TaoPhieuMoi();
                txtNhanVienNhap.Text = ClsMain.maNhanVien;
                //insert phieu nhap vao data.
                if (bd.InsertPhieuNhap(ref err, txtMaPhieuNhap.Text, dtpNgayNhap.Value, txtNhanVienNhap.Text) == 0)
                {
                    MessageBox.Show("Chua insert");
                }
                phieuNhapHoanThanh = true;
            }
            LoadCboSanPham();
        }
        bool statusloadSanPham = false;
        private void LoadCboSanPham()
        {
            DataTable dt = new DataTable();
            dt = new BLL_SanPham().LaySanPhamCbo(ref err);

            cboSanPham.DataSource = dt;

            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";

            cboSanPham.SelectedIndex = -1;
            cboSanPham.Text = "--- chọn sản phẩm --- ";
            statusloadSanPham = true;
        }
        #endregion

        #region Các Phương thức trong Class Frm_NhapHang
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
            foreach (DataRow item in dtChiTietPhieuNhap.Rows)
            {
                tongSoLuong = Convert.ToInt32(item["SoLuongNhap"].ToString());
                tongThanhTien = Convert.ToInt32(item["ThanhTien"].ToString());
            }
            txtTongSL.Text = string.Format("{0:#,###0}", tongSoLuong);
            txtTongThanhTien.Text = string.Format("{0:#,###0}", tongThanhTien);
        }

        /// <summary>
        /// Tạo mã phiếu nhập mới
        /// </summary>
        /// <returns>Mã phiếu được tạo</returns>
        private string TaoPhieuMoi()
        {
            string maPhieuNhap = bd.SinhMaPhieuMoi(ref err);
            return maPhieuNhap;
        }

        private string TaoPhieuMoi(DateTime ngayTaoPhieu)
        {
            string maPhieuNhap = bd.SinhMaPhieuMoi(ref err,ngayTaoPhieu);
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
        #endregion

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            if (phieuNhapHoanThanh == true)
            {
                txtMaPhieuNhap.Text = TaoPhieuMoi(dtpNgayNhap.Value);
            }
            
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedIndex >= 0 && statusloadSanPham==true)
            {
                DataTable dtSanPham = new BLL_SanPham().LayDanhSachSanPhamAllOrByID(ref err, cboSanPham.SelectedValue.ToString());

                txtDonViTinh.Text = dtSanPham.Rows[0]["MaDVT"].ToString();
            }
                    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cboSanPham.SelectedIndex>-1)
            {
                if (!string.IsNullOrEmpty(txtSoLuongNhap.Text))
                {
                    if (!string.IsNullOrEmpty(txtDonViTinh.Text))
                    {
                        if(!string.IsNullOrEmpty(txtDonGiaNhap.Text))
                        {
                            //Them du lieu vao phieu nhap
                            if(bd.ThemSanPhamVaoPhieuNhap(ref err, txtMaPhieuNhap.Text, cboSanPham.SelectedValue.ToString(), Convert.ToInt32(txtSoLuongNhap.Text), Convert.ToInt32(txtDonGiaNhap.Text))>=1){
                                MessageBox.Show("Them thanh công");
                                LoadThongTinTheoPhieuNhapCu(txtMaPhieuNhap.Text);
                                phieuNhapHoanThanh = true;
                            }
                            else
                            {
                                MessageBox.Show(err);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chua nhap gia");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chua nhap don vi tinh");
                    }
                }
                else
                {
                    MessageBox.Show("Chua nhap so luong");
                }
            }
            else
            {
                MessageBox.Show("Chua chon san pham");
            }
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if(bd.XacNhanPhieuNhapHoanThanh(ref err, txtMaPhieuNhap.Text)>=1)
            {
                MessageBox.Show("phieu nhap hoan thanh");
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(bd.XoaChiTietPhieuNhap(ref err, maPhieuNhapXoa, maSP) >= 1)
            {
                LoadThongTinTheoPhieuNhapCu(txtMaPhieuNhap.Text);
            }
        }
        string maPhieuNhapXoa = string.Empty;
        string maSP = string.Empty;
        private void dgvDanhSachSanPhamNhap_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachSanPhamNhap.Rows.Count>0)
            {
                maPhieuNhapXoa = dgvDanhSachSanPhamNhap.CurrentRow.Cells["colMaPhieuNhap"].Value.ToString();
                maSP= dgvDanhSachSanPhamNhap.CurrentRow.Cells["colMaSP"].Value.ToString();
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemSanPhamMoi_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            for (int i = dgvDanhSachSanPhamNhap.Rows.Count - 1; i >= 0; i++)
            {
                bd.XoaChiTietPhieuNhap(ref err, dgvDanhSachSanPhamNhap.Rows[i].Cells["colMaPhieuNhap"].Value.ToString(), dgvDanhSachSanPhamNhap.Rows[i].Cells["colMaSP"].Value.ToString());
            }
            LoadThongTinTheoPhieuNhapCu(txtMaPhieuNhap.Text);
        }
    }
}
