using Pro_QuanLyBanHang2023.BusinessLayer;
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
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        string tenNhanVien = string.Empty;
        BLL_DangNhap bd;
        string err = string.Empty;
        bool trangThai = false;

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            bd = new BLL_DangNhap();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                if(!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if(KiemTraDangNhap(txtTenDangNhap.Text,txtMatKhau.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tai khoan hoac mat khau khong dung");
                    }
                }
                else
                {
                    MessageBox.Show("Chua co pass");
                }
            }
            else
            {
                MessageBox.Show("Chua co username");
            }
        }
       
        private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            SqlDataReader sqlDataReader = bd.KiemTraDangNhap(ref err, tenDangNhap, matKhau);
            while(sqlDataReader.Read())
            {
                trangThai =Convert.ToBoolean(sqlDataReader["TrangThai"]);
                tenNhanVien = sqlDataReader["TenNhanVien"].ToString();
            }
            return trangThai;
        }
       
        
    }
}
