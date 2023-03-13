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
    public partial class Frm_LoaiChucNang_Modifies : Form
    {
        public Frm_LoaiChucNang_Modifies()
        {
            InitializeComponent();
        } 
        BLL_LoaiChucNang bd;
        public LoaiChucNang loaiChucNang;
      
        public bool isAdd = false;

        string err = string.Empty;

        private void Frm_LoaiChucNang_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_LoaiChucNang();
            if (isAdd)
            {
                txtMaNhomChucNang.Text = 0.ToString();
                txtTenNhomChucNang.Focus();
            }
            else
            {
                txtMaNhomChucNang.Text = loaiChucNang.MaNhomChucNang.ToString();
                txtTenNhomChucNang.Text = loaiChucNang.TenNhomChucNang;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Cập nhật loại chức năng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại chức năng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Chưa nhập tên loại chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
