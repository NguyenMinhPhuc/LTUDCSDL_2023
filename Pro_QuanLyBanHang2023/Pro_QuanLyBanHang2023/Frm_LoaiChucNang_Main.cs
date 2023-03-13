using Pro_QuanLyBanHang2023.BusinessLayer;
using Pro_QuanLyBanHang2023.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_QuanLyBanHang2023
{
    public partial class Frm_LoaiChucNang_Main : Form
    {
        public Frm_LoaiChucNang_Main()
        {
            InitializeComponent();
        }
        BLL_LoaiChucNang bd;
        string err = string.Empty;
        DataTable dataTableLoaiChucNang;
        int soLoaiChucNang = 0;

        LoaiChucNang loaiChucNang;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_LoaiChucNang_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_LoaiChucNang();
            HienThiLoaiChucNang();
        }
        private void HienThiLoaiChucNang()
        {
            dataTableLoaiChucNang = new DataTable();
            dataTableLoaiChucNang = bd.LayDanhSachLoaiChucNang(ref err, "0");

            dgvLoaiChucNang.DataSource = dataTableLoaiChucNang.DefaultView;
            soLoaiChucNang = dgvLoaiChucNang.Rows.Count;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_LoaiChucNang_Modifies frm_LoaiChucNang_Modifies = new Frm_LoaiChucNang_Modifies();
            frm_LoaiChucNang_Modifies.isAdd = true;
            frm_LoaiChucNang_Modifies.ShowDialog();
            HienThiLoaiChucNang();
            loaiChucNang = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (loaiChucNang!=null)
            {
                Frm_LoaiChucNang_Modifies frm_LoaiChucNang_Modifies = new Frm_LoaiChucNang_Modifies();
                frm_LoaiChucNang_Modifies.isAdd = false;
                frm_LoaiChucNang_Modifies.loaiChucNang = loaiChucNang;
                frm_LoaiChucNang_Modifies.ShowDialog();
                HienThiLoaiChucNang();
                loaiChucNang = null;
            }    
        }

        private void dgvLoaiChucNang_Click(object sender, EventArgs e)
        {
            if (dgvLoaiChucNang.Rows.Count > 0)
            {
                loaiChucNang = new LoaiChucNang()
                {
                    MaNhomChucNang =Convert.ToInt32( dgvLoaiChucNang.CurrentRow.Cells["colMaNhomChucNang"].Value.ToString()),
                    TenNhomChucNang = dgvLoaiChucNang.CurrentRow.Cells["colTenNhomChucNang"].Value.ToString()
                };
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(loaiChucNang!=null)
            {
                if (bd.DeleteNhomChucNang(ref err, loaiChucNang.MaNhomChucNang.ToString(), false) > 0)
                {
                    MessageBox.Show("Xóa loại chức năng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLoaiChucNang();
                    loaiChucNang = null;
                    
                }
                else
                {
                    MessageBox.Show("Xóa loại chức năng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }
    }
}
