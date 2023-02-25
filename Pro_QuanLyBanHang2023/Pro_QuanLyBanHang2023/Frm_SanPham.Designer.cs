
namespace Pro_QuanLyBanHang2023
{
    partial class Frm_SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLaySanPham = new System.Windows.Forms.Button();
            this.lbDanhSachSanPham = new System.Windows.Forms.ListBox();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaySanPham
            // 
            this.btnLaySanPham.Location = new System.Drawing.Point(48, 25);
            this.btnLaySanPham.Name = "btnLaySanPham";
            this.btnLaySanPham.Size = new System.Drawing.Size(170, 43);
            this.btnLaySanPham.TabIndex = 0;
            this.btnLaySanPham.Text = "Lấy sản phẩm";
            this.btnLaySanPham.UseVisualStyleBackColor = true;
            this.btnLaySanPham.Click += new System.EventHandler(this.btnLaySanPham_Click);
            // 
            // lbDanhSachSanPham
            // 
            this.lbDanhSachSanPham.FormattingEnabled = true;
            this.lbDanhSachSanPham.ItemHeight = 20;
            this.lbDanhSachSanPham.Location = new System.Drawing.Point(48, 86);
            this.lbDanhSachSanPham.Name = "lbDanhSachSanPham";
            this.lbDanhSachSanPham.Size = new System.Drawing.Size(682, 324);
            this.lbDanhSachSanPham.TabIndex = 1;
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Location = new System.Drawing.Point(600, 63);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(130, 20);
            this.lblTongSoLuong.TabIndex = 2;
            this.lblTongSoLuong.Text = "Tổng số lượng : 0";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(410, 33);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(228, 26);
            this.txtMaSP.TabIndex = 3;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(238, 25);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(157, 43);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Them SP";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblTongSoLuong);
            this.Controls.Add(this.lbDanhSachSanPham);
            this.Controls.Add(this.btnLaySanPham);
            this.Name = "Frm_SanPham";
            this.Text = "Frm_SanPham";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaySanPham;
        private System.Windows.Forms.ListBox lbDanhSachSanPham;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnThemSP;
    }
}