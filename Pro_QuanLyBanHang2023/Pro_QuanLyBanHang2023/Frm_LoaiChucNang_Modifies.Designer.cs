
namespace Pro_QuanLyBanHang2023
{
    partial class Frm_LoaiChucNang_Modifies
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
            this.txtTenNhomChucNang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhomChucNang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenNhomChucNang
            // 
            this.txtTenNhomChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNhomChucNang.Location = new System.Drawing.Point(194, 50);
            this.txtTenNhomChucNang.Name = "txtTenNhomChucNang";
            this.txtTenNhomChucNang.Size = new System.Drawing.Size(502, 20);
            this.txtTenNhomChucNang.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên nhóm chức năng:";
            // 
            // txtMaNhomChucNang
            // 
            this.txtMaNhomChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNhomChucNang.Enabled = false;
            this.txtMaNhomChucNang.Location = new System.Drawing.Point(194, 21);
            this.txtMaNhomChucNang.Name = "txtMaNhomChucNang";
            this.txtMaNhomChucNang.Size = new System.Drawing.Size(502, 20);
            this.txtMaNhomChucNang.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã nhóm chức năng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(304, 105);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(179, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(502, 105);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(179, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Frm_LoaiChucNang_Modifies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 213);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTenNhomChucNang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhomChucNang);
            this.Controls.Add(this.label1);
            this.Name = "Frm_LoaiChucNang_Modifies";
            this.Text = "Frm_LoaiChucNang_Modifies";
            this.Load += new System.EventHandler(this.Frm_LoaiChucNang_Modifies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhomChucNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhomChucNang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}