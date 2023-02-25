
namespace Pro_QuanLyBanHang2023
{
    partial class Frm_KetNoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckWinNT = new System.Windows.Forms.CheckBox();
            this.btnLuuChuoiKetNoi = new System.Windows.Forms.Button();
            this.btnKiemTraKetNoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(185, 52);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(478, 26);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(185, 93);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(478, 26);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(185, 134);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(478, 26);
            this.txtUserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(185, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(478, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // ckWinNT
            // 
            this.ckWinNT.AutoSize = true;
            this.ckWinNT.Location = new System.Drawing.Point(588, 213);
            this.ckWinNT.Name = "ckWinNT";
            this.ckWinNT.Size = new System.Drawing.Size(75, 24);
            this.ckWinNT.TabIndex = 8;
            this.ckWinNT.Text = "WinNT";
            this.ckWinNT.UseVisualStyleBackColor = true;
            // 
            // btnLuuChuoiKetNoi
            // 
            this.btnLuuChuoiKetNoi.Location = new System.Drawing.Point(185, 255);
            this.btnLuuChuoiKetNoi.Name = "btnLuuChuoiKetNoi";
            this.btnLuuChuoiKetNoi.Size = new System.Drawing.Size(148, 38);
            this.btnLuuChuoiKetNoi.TabIndex = 9;
            this.btnLuuChuoiKetNoi.Text = "Lưu kết nối";
            this.btnLuuChuoiKetNoi.UseVisualStyleBackColor = true;
            // 
            // btnKiemTraKetNoi
            // 
            this.btnKiemTraKetNoi.Location = new System.Drawing.Point(347, 255);
            this.btnKiemTraKetNoi.Name = "btnKiemTraKetNoi";
            this.btnKiemTraKetNoi.Size = new System.Drawing.Size(148, 38);
            this.btnKiemTraKetNoi.TabIndex = 10;
            this.btnKiemTraKetNoi.Text = "Kiểm tra kết nối";
            this.btnKiemTraKetNoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(509, 255);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 38);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Frm_KetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKiemTraKetNoi);
            this.Controls.Add(this.btnLuuChuoiKetNoi);
            this.Controls.Add(this.ckWinNT);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Name = "Frm_KetNoi";
            this.Text = "Frm_KetNoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckWinNT;
        private System.Windows.Forms.Button btnLuuChuoiKetNoi;
        private System.Windows.Forms.Button btnKiemTraKetNoi;
        private System.Windows.Forms.Button btnThoat;
    }
}