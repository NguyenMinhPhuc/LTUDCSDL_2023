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
    public partial class Frm_SanPham : Form
    {
        public Frm_SanPham()
        {
            InitializeComponent();
        }
        BLL_SanPham bd;
        string err = string.Empty;
        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            bd = new BLL_SanPham();
        }
        int countSP = 0;
        private void btnLaySanPham_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader = bd.LayDanhSachSanPham(ref err, "0");
            if(sqlDataReader!=null)
            {
                while(sqlDataReader.Read())
                {
                    string line = string.Format("{0}-{1}-{2}", sqlDataReader["MaSP"], sqlDataReader["TenSP"], sqlDataReader["SoTon"]);
                    lbDanhSachSanPham.Items.Add(line);
                    countSP++;
                }
                lblTongSoLuong.Text = string.Format("Tổng số lượng: {0}", countSP);
            }    
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = TaoMaSPTuDong();
        }

        private string TaoMaSPTuDong()
        {
            string maSP = string.Empty;
            int maxID = Convert.ToInt32(bd.LayMaxIDSanPham(ref err).ToString().Substring(2));
            maSP = string.Format("SP{0:0000000}",maxID+1);

            return maSP;
        }
    }
}
