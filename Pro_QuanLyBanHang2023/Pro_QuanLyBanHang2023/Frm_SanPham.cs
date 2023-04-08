using Pro_QuanLyBanHang2023.BusinessLayer;
using Pro_QuanLyBanHang2023.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_QuanLyBanHang2023
{
    public partial class Frm_SanPham : Form
    {
        public Frm_SanPham()
        {
            InitializeComponent();
        }
        BLL_SanPham bd;
        string err = string.Empty;
        DataTable dataTable;
        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            bd = new BLL_SanPham();
            HienThiDanhSachSanPham();
            HienThiCboDonViTinh();
        }

        private void HienThiCboDonViTinh()
        {
            DataTable dt = new DataTable();
            dt = bd.LayDonViTinhCbo(ref err);
            cboDonViTinh.DataSource = dt;

            cboDonViTinh.DisplayMember = "TenDVT";
            cboDonViTinh.ValueMember = "MaDVT";

            cboDonViTinh.SelectedIndex = -1;
            cboDonViTinh.Text = "Chon don vi tinh";
        }

        private void HienThiDanhSachSanPham()
        {
            //b1: Khai bao doi tuong DataTable
            dataTable = new DataTable();
            //b2:Goi du lieu tu bussinessLayer
            dataTable = bd.LayDanhSachSanPhamAllOrByID(ref err, "0");
            //B3:gan datatable vao datagridview
            dgvDanhSachSanPham.DataSource = dataTable.DefaultView;
        }

        int countSP = 0;
        private void btnLaySanPham_Click(object sender, EventArgs e)
        {
            //SqlDataReader sqlDataReader = bd.LayDanhSachSanPham(ref err, "0");
            //if(sqlDataReader!=null)
            //{
            //    while(sqlDataReader.Read())
            //    {
            //        string line = string.Format("{0}-{1}-{2}", sqlDataReader["MaSP"], sqlDataReader["TenSP"], sqlDataReader["SoTon"]);
            //        lbDanhSachSanPham.Items.Add(line);
            //        countSP++;
            //    }
            //    lblTongSoLuong.Text = string.Format("Tổng số lượng: {0}", countSP);
            //}    
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
           // txtMaSP.Text = TaoMaSPTuDong();
        }

        private string TaoMaSPTuDong()
        {
            string maSP = string.Empty;
            int maxID = Convert.ToInt32(bd.LayMaxIDSanPham(ref err).ToString().Substring(2));
            maSP = string.Format("SP{0:0000000}",maxID+1);

            return maSP;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = TaoMaSPTuDong();
            txtTenSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu
            if (LuuDuLieuSanPham(txtMaSP.Text, txtTenSP.Text, txtSoTon.Text, cboDonViTinh.SelectedValue.ToString()))
            {
                HienThiDanhSachSanPham();
            }
            
        }

        private bool LuuDuLieuSanPham(string maSP, string tenSP, string soTon, string maDVT)
        {
            SanPham sanPham = new SanPham()
            {
                MaSP = maSP,
                TenSP = tenSP,
                SoTon = Convert.ToInt32(soTon),
                MaDVT=Convert.ToInt32(maDVT)
            };
            if (bd.InsertSanPham(ref err, sanPham) > 0)
                return true;
            return false;
        }
        SanPham sanPham;
        private void dgvDanhSachSanPham_Click(object sender, EventArgs e)
        {
            sanPham = new SanPham();
            if (dgvDanhSachSanPham.Rows.Count > 0)
            {
                sanPham.MaSP = dgvDanhSachSanPham.CurrentRow.Cells["colMaSP"].Value.ToString();
                sanPham.TenSP = dgvDanhSachSanPham.CurrentRow.Cells["colTenSP"].Value.ToString();
                sanPham.SoTon = Convert.ToInt32(dgvDanhSachSanPham.CurrentRow.Cells["colSoTon"].Value.ToString());
                sanPham.MaDVT = Convert.ToInt32(dgvDanhSachSanPham.CurrentRow.Cells["colMaDVT"].Value.ToString());
            }
            BingSanPhamToControl();
        }

        private void BingSanPhamToControl()
        {
            txtMaSP.Text = sanPham.MaSP;
            txtTenSP.Text = sanPham.TenSP;
            txtSoTon.Text = sanPham.SoTon.ToString();
            cboDonViTinh.SelectedValue = sanPham.MaDVT;
        }
    }
}
