
namespace Pro_QuanLyBanHang2023
{
    partial class Frm_LoaiChucNang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoaiChucNang = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhomChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhomChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhomChucNang = new System.Windows.Forms.TextBox();
            this.txtTenNhomChucNang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiChucNang
            // 
            this.dgvLoaiChucNang.AllowUserToAddRows = false;
            this.dgvLoaiChucNang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLoaiChucNang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLoaiChucNang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiChucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLoaiChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaNhomChucNang,
            this.colTenNhomChucNang,
            this.colIsDelete});
            this.dgvLoaiChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiChucNang.Location = new System.Drawing.Point(0, 113);
            this.dgvLoaiChucNang.Name = "dgvLoaiChucNang";
            this.dgvLoaiChucNang.ReadOnly = true;
            this.dgvLoaiChucNang.RowHeadersVisible = false;
            this.dgvLoaiChucNang.RowTemplate.Height = 32;
            this.dgvLoaiChucNang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiChucNang.Size = new System.Drawing.Size(1188, 459);
            this.dgvLoaiChucNang.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMaNhomChucNang
            // 
            this.colMaNhomChucNang.DataPropertyName = "MaNhomChucNang";
            this.colMaNhomChucNang.HeaderText = "Mã nhóm";
            this.colMaNhomChucNang.Name = "colMaNhomChucNang";
            this.colMaNhomChucNang.ReadOnly = true;
            this.colMaNhomChucNang.Visible = false;
            // 
            // colTenNhomChucNang
            // 
            this.colTenNhomChucNang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNhomChucNang.DataPropertyName = "TenNhomChucNang";
            this.colTenNhomChucNang.HeaderText = "Tên nhóm chức năng";
            this.colTenNhomChucNang.Name = "colTenNhomChucNang";
            this.colTenNhomChucNang.ReadOnly = true;
            // 
            // colIsDelete
            // 
            this.colIsDelete.DataPropertyName = "IsDelete";
            this.colIsDelete.HeaderText = "Delete";
            this.colIsDelete.Name = "colIsDelete";
            this.colIsDelete.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhóm chức năng";
            // 
            // txtMaNhomChucNang
            // 
            this.txtMaNhomChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNhomChucNang.Enabled = false;
            this.txtMaNhomChucNang.Location = new System.Drawing.Point(404, 20);
            this.txtMaNhomChucNang.Name = "txtMaNhomChucNang";
            this.txtMaNhomChucNang.Size = new System.Drawing.Size(502, 20);
            this.txtMaNhomChucNang.TabIndex = 3;
            // 
            // txtTenNhomChucNang
            // 
            this.txtTenNhomChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNhomChucNang.Location = new System.Drawing.Point(404, 49);
            this.txtTenNhomChucNang.Name = "txtTenNhomChucNang";
            this.txtTenNhomChucNang.Size = new System.Drawing.Size(502, 20);
            this.txtTenNhomChucNang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nhóm chức năng:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(429, 84);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(530, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(631, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(732, 84);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_LoaiChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 594);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNhomChucNang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhomChucNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoaiChucNang);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_LoaiChucNang";
            this.Text = "Frm_LoaiChucNang";
            this.Load += new System.EventHandler(this.Frm_LoaiChucNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiChucNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhomChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhomChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhomChucNang;
        private System.Windows.Forms.TextBox txtTenNhomChucNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}