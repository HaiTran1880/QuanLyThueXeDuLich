namespace GUI.UserControls
{
    partial class CustomersUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoCMNDKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(625, 284);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(102, 42);
            this.btnLamMoi.TabIndex = 90;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbbTimKiemTheo
            // 
            this.cbbTimKiemTheo.FormattingEnabled = true;
            this.cbbTimKiemTheo.Items.AddRange(new object[] {
            "Tên Khách Hàng",
            "Địa chỉ",
            "Số CMND"});
            this.cbbTimKiemTheo.Location = new System.Drawing.Point(950, 292);
            this.cbbTimKiemTheo.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTimKiemTheo.Name = "cbbTimKiemTheo";
            this.cbbTimKiemTheo.Size = new System.Drawing.Size(176, 29);
            this.cbbTimKiemTheo.TabIndex = 89;
            this.cbbTimKiemTheo.Text = "---Tìm kiếm theo---";
            this.cbbTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiemTheo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(945, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 88;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(157, 180);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(236, 29);
            this.txtTenKH.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 86;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // grGioiTinh
            // 
            this.grGioiTinh.Controls.Add(this.rdbNu);
            this.grGioiTinh.Controls.Add(this.rdbNam);
            this.grGioiTinh.Location = new System.Drawing.Point(422, 145);
            this.grGioiTinh.Margin = new System.Windows.Forms.Padding(5);
            this.grGioiTinh.Name = "grGioiTinh";
            this.grGioiTinh.Padding = new System.Windows.Forms.Padding(5);
            this.grGioiTinh.Size = new System.Drawing.Size(382, 99);
            this.grGioiTinh.TabIndex = 80;
            this.grGioiTinh.TabStop = false;
            this.grGioiTinh.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(247, 39);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(5);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(51, 25);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(67, 39);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(5);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(63, 25);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(980, 75);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(251, 29);
            this.txtSDTKH.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSoCMNDKH
            // 
            this.txtSoCMNDKH.Location = new System.Drawing.Point(560, 75);
            this.txtSoCMNDKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoCMNDKH.Name = "txtSoCMNDKH";
            this.txtSoCMNDKH.Size = new System.Drawing.Size(241, 29);
            this.txtSoCMNDKH.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "Số CMND";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(157, 74);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(236, 29);
            this.txtMaKH.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(250, 284);
            this.btnSuaKH.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(108, 40);
            this.btnSuaKH.TabIndex = 83;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(62, 283);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(108, 40);
            this.btnThemKH.TabIndex = 82;
            this.btnThemKH.Text = "Thêm mới";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(980, 184);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(251, 29);
            this.txtDiaChi.TabIndex = 76;
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Location = new System.Drawing.Point(795, 286);
            this.btnTimKiemKH.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(108, 40);
            this.btnTimKiemKH.TabIndex = 85;
            this.btnTimKiemKH.Text = "Tìm Kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(445, 284);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(108, 40);
            this.btnXoaKH.TabIndex = 84;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(854, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 72;
            this.label5.Text = "Địa chỉ";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenKH,
            this.SoCMND,
            this.GioiTinh,
            this.SDT,
            this.DiaChi});
            this.dgvKhachHang.Location = new System.Drawing.Point(5, 342);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(1224, 350);
            this.dgvKhachHang.TabIndex = 81;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Mã Khách Hàng";
            this.ID.Name = "ID";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // SoCMND
            // 
            this.SoCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoCMND.HeaderText = "Số CMND";
            this.SoCMND.Name = "SoCMND";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // CustomersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbbTimKiemTheo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grGioiTinh);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoCMNDKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnTimKiemKH);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvKhachHang);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomersUC";
            this.Size = new System.Drawing.Size(1234, 697);
            this.grGioiTinh.ResumeLayout(false);
            this.grGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbbTimKiemTheo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grGioiTinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoCMNDKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
