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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            Frm_SanPham frm_SanPham = new Frm_SanPham();
            frm_SanPham.StartPosition = FormStartPosition.CenterScreen;
            frm_SanPham.ShowDialog();
        }
    }
}
