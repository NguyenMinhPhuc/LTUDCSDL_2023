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
    public partial class Frm_LoaiChucNang : Form
    {
        public Frm_LoaiChucNang()
        {
            InitializeComponent();
        }
        BLL_LoaiChucNang bd;
        string err = string.Empty;
        DataTable dataTableLoaiChucNang;
        int soLoaiChucNang = 0;

        LoaiChucNang loaiChucNang;
        private void Frm_LoaiChucNang_Load(object sender, EventArgs e)
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
            txtMaNhomChucNang.Text = 0.ToString();

            if (!string.IsNullOrEmpty(txtTenNhomChucNang.Text))
            {
                loaiChucNang = new LoaiChucNang()
                {
                    MaNhomChucNang = Convert.ToInt32(txtMaNhomChucNang.Text),
                    TenNhomChucNang = txtTenNhomChucNang.Text
                };
                if (bd.InsertAndUpdate(ref err, loaiChucNang) > 0)
                {
                    MessageBox.Show("Thêm loại chức năng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLoaiChucNang();
                    loaiChucNang = null;
                    txtTenNhomChucNang.ResetText();
                    txtTenNhomChucNang.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm loại chức năng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Chưa nhập tên loại chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (loaiChucNang != null)
            {
                loaiChucNang = new LoaiChucNang()
                {
                    MaNhomChucNang = Convert.ToInt32(txtMaNhomChucNang.Text),
                    TenNhomChucNang = txtTenNhomChucNang.Text
                };

                if (!string.IsNullOrEmpty(txtTenNhomChucNang.Text))
                {
                    loaiChucNang = new LoaiChucNang()
                    {
                        MaNhomChucNang = Convert.ToInt32(txtMaNhomChucNang.Text),
                        TenNhomChucNang = txtTenNhomChucNang.Text
                    };
                    if (bd.InsertAndUpdate(ref err, loaiChucNang) > 0)
                    {
                        MessageBox.Show("Sửa loại chức năng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiLoaiChucNang();
                        loaiChucNang = null;
                        txtMaNhomChucNang.ResetText();
                        txtTenNhomChucNang.ResetText();
                        txtTenNhomChucNang.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Sửa loại chức năng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("Chưa nhập tên loại chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (loaiChucNang != null)
            {
                loaiChucNang = new LoaiChucNang()
                {
                    MaNhomChucNang = Convert.ToInt32(txtMaNhomChucNang.Text),
                    TenNhomChucNang = txtTenNhomChucNang.Text
                };
                if (bd.DeleteNhomChucNang(ref err, loaiChucNang.MaNhomChucNang.ToString(), false) > 0)
                {
                    MessageBox.Show("Xóa loại chức năng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLoaiChucNang();
                    loaiChucNang = null;
                    txtMaNhomChucNang.ResetText();
                    txtTenNhomChucNang.ResetText();
                    txtTenNhomChucNang.Focus();
                }
                else
                {
                    MessageBox.Show("Xóa loại chức năng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}