namespace GUI.UserControls
{
    partial class ManageBill
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
            this.dgvchitiethoadon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mausac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btntimkiemhoadon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnchitiethd = new System.Windows.Forms.Button();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.txttimkiemhoadon = new System.Windows.Forms.TextBox();
            this.datetimethuexe = new System.Windows.Forms.DateTimePicker();
            this.datetimetraxe = new System.Windows.Forms.DateTimePicker();
            this.cmbmakh = new System.Windows.Forms.ComboBox();
            this.btnxoahd = new System.Windows.Forms.Button();
            this.btnsuahd = new System.Windows.Forms.Button();
            this.btnthemhd = new System.Windows.Forms.Button();
            this.txttienthue = new System.Windows.Forms.TextBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.cmbmaxe = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvchitiethoadon
            // 
            this.dgvchitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dongia,
            this.tenxe,
            this.mausac,
            this.soxe,
            this.thanhtien});
            this.dgvchitiethoadon.Location = new System.Drawing.Point(3, 453);
            this.dgvchitiethoadon.Name = "dgvchitiethoadon";
            this.dgvchitiethoadon.Size = new System.Drawing.Size(1228, 241);
            this.dgvchitiethoadon.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hóa đơn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Số ngày thuê";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // tenxe
            // 
            this.tenxe.HeaderText = "Tên xe";
            this.tenxe.Name = "tenxe";
            this.tenxe.Width = 150;
            // 
            // mausac
            // 
            this.mausac.HeaderText = "Màu sắc";
            this.mausac.Name = "mausac";
            // 
            // soxe
            // 
            this.soxe.HeaderText = "Số xe";
            this.soxe.Name = "soxe";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 150;
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.mahd,
            this.CustomerName,
            this.manv,
            this.ngaythue,
            this.ngaytra,
            this.maxe,
            this.tienthue});
            this.dgvhoadon.Location = new System.Drawing.Point(408, 38);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.Size = new System.Drawing.Size(823, 320);
            this.dgvhoadon.TabIndex = 3;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadonCellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(796, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Danh Sách Hóa Đơn ";
            // 
            // btntimkiemhoadon
            // 
            this.btntimkiemhoadon.BackgroundImage = global::GUI.Properties.Resources.red_search_icon;
            this.btntimkiemhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimkiemhoadon.Location = new System.Drawing.Point(408, 364);
            this.btntimkiemhoadon.Name = "btntimkiemhoadon";
            this.btntimkiemhoadon.Size = new System.Drawing.Size(124, 39);
            this.btntimkiemhoadon.TabIndex = 16;
            this.btntimkiemhoadon.Text = "Tìm kiếm";
            this.btntimkiemhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiemhoadon.UseVisualStyleBackColor = true;
            this.btntimkiemhoadon.Click += new System.EventHandler(this.btntimkiemhoadon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "**Nhập mã hóa đơn cần tìm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(456, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thông tin chi tiết dịch vụ";
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackgroundImage = global::GUI.Properties.Resources.Windows_Restart_icon;
            this.btnlammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlammoi.Location = new System.Drawing.Point(150, 364);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(135, 39);
            this.btnlammoi.TabIndex = 11;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnchitiethd
            // 
            this.btnchitiethd.Location = new System.Drawing.Point(150, 303);
            this.btnchitiethd.Name = "btnchitiethd";
            this.btnchitiethd.Size = new System.Drawing.Size(135, 39);
            this.btnchitiethd.TabIndex = 12;
            this.btnchitiethd.Text = "Chi Tiết";
            this.btnchitiethd.UseVisualStyleBackColor = true;
            this.btnchitiethd.Click += new System.EventHandler(this.btnchitiethd_Click);
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.BackgroundImage = global::GUI.Properties.Resources.Windows_Restart_icon;
            this.btnnhaplai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnnhaplai.Location = new System.Drawing.Point(31, 303);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(113, 39);
            this.btnnhaplai.TabIndex = 13;
            this.btnnhaplai.Text = "Nhập Lại";
            this.btnnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // txttimkiemhoadon
            // 
            this.txttimkiemhoadon.Location = new System.Drawing.Point(538, 364);
            this.txttimkiemhoadon.Name = "txttimkiemhoadon";
            this.txttimkiemhoadon.Size = new System.Drawing.Size(488, 29);
            this.txttimkiemhoadon.TabIndex = 10;
            // 
            // datetimethuexe
            // 
            this.datetimethuexe.CustomFormat = "dd-MM-yyyy";
            this.datetimethuexe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimethuexe.Location = new System.Drawing.Point(203, 178);
            this.datetimethuexe.Name = "datetimethuexe";
            this.datetimethuexe.Size = new System.Drawing.Size(198, 29);
            this.datetimethuexe.TabIndex = 33;
            // 
            // datetimetraxe
            // 
            this.datetimetraxe.CustomFormat = "dd-MM-yyyy";
            this.datetimetraxe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimetraxe.Location = new System.Drawing.Point(203, 213);
            this.datetimetraxe.Name = "datetimetraxe";
            this.datetimetraxe.Size = new System.Drawing.Size(198, 29);
            this.datetimetraxe.TabIndex = 32;
            // 
            // cmbmakh
            // 
            this.cmbmakh.FormattingEnabled = true;
            this.cmbmakh.Location = new System.Drawing.Point(202, 73);
            this.cmbmakh.Name = "cmbmakh";
            this.cmbmakh.Size = new System.Drawing.Size(199, 29);
            this.cmbmakh.TabIndex = 29;
            // 
            // btnxoahd
            // 
            this.btnxoahd.BackgroundImage = global::GUI.Properties.Resources.Actions_edit_delete_icon;
            this.btnxoahd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoahd.Location = new System.Drawing.Point(291, 303);
            this.btnxoahd.Name = "btnxoahd";
            this.btnxoahd.Size = new System.Drawing.Size(81, 39);
            this.btnxoahd.TabIndex = 27;
            this.btnxoahd.Text = "Xóa";
            this.btnxoahd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoahd.UseVisualStyleBackColor = true;
            this.btnxoahd.Click += new System.EventHandler(this.btnxoahd_Click);
            // 
            // btnsuahd
            // 
            this.btnsuahd.BackgroundImage = global::GUI.Properties.Resources.Actions_document_edit_icon;
            this.btnsuahd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsuahd.Location = new System.Drawing.Point(291, 364);
            this.btnsuahd.Name = "btnsuahd";
            this.btnsuahd.Size = new System.Drawing.Size(86, 39);
            this.btnsuahd.TabIndex = 26;
            this.btnsuahd.Text = "Sửa";
            this.btnsuahd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsuahd.UseVisualStyleBackColor = true;
            this.btnsuahd.Click += new System.EventHandler(this.btnsuahd_Click);
            // 
            // btnthemhd
            // 
            this.btnthemhd.BackgroundImage = global::GUI.Properties.Resources.Actions_list_add_user_icon;
            this.btnthemhd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthemhd.Location = new System.Drawing.Point(30, 364);
            this.btnthemhd.Name = "btnthemhd";
            this.btnthemhd.Size = new System.Drawing.Size(113, 39);
            this.btnthemhd.TabIndex = 28;
            this.btnthemhd.Text = "Thêm Mới";
            this.btnthemhd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemhd.UseVisualStyleBackColor = true;
            this.btnthemhd.Click += new System.EventHandler(this.btnthemhd_Click);
            // 
            // txttienthue
            // 
            this.txttienthue.Location = new System.Drawing.Point(203, 248);
            this.txttienthue.Name = "txttienthue";
            this.txttienthue.Size = new System.Drawing.Size(198, 29);
            this.txttienthue.TabIndex = 25;
            // 
            // txtmahd
            // 
            this.txtmahd.Enabled = false;
            this.txtmahd.Location = new System.Drawing.Point(202, 38);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(199, 29);
            this.txtmahd.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Đơn giá/Ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày Thuê Xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày Trả Xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhân viên lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Enabled = false;
            this.txtNameEmp.Location = new System.Drawing.Point(202, 109);
            this.txtNameEmp.Multiline = true;
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(199, 28);
            this.txtNameEmp.TabIndex = 34;
            // 
            // cmbmaxe
            // 
            this.cmbmaxe.FormattingEnabled = true;
            this.cmbmaxe.Location = new System.Drawing.Point(202, 146);
            this.cmbmaxe.Name = "cmbmaxe";
            this.cmbmaxe.Size = new System.Drawing.Size(198, 29);
            this.cmbmaxe.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "ID";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            this.mahd.Width = 70;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.Name = "CustomerName";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "EmpName";
            this.manv.HeaderText = "Tên nhân viên";
            this.manv.Name = "manv";
            // 
            // ngaythue
            // 
            this.ngaythue.DataPropertyName = "DateOfHire";
            this.ngaythue.HeaderText = "Ngày thuê";
            this.ngaythue.Name = "ngaythue";
            // 
            // ngaytra
            // 
            this.ngaytra.DataPropertyName = "DateOfPayment";
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.Name = "ngaytra";
            // 
            // maxe
            // 
            this.maxe.DataPropertyName = "CarName";
            this.maxe.HeaderText = "Tên xe";
            this.maxe.Name = "maxe";
            // 
            // tienthue
            // 
            this.tienthue.DataPropertyName = "PricePerDay";
            this.tienthue.HeaderText = "Đơn giá/Ngày";
            this.tienthue.Name = "tienthue";
            // 
            // ManageBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbmaxe);
            this.Controls.Add(this.txtNameEmp);
            this.Controls.Add(this.datetimethuexe);
            this.Controls.Add(this.datetimetraxe);
            this.Controls.Add(this.cmbmakh);
            this.Controls.Add(this.btnxoahd);
            this.Controls.Add(this.btnsuahd);
            this.Controls.Add(this.btnthemhd);
            this.Controls.Add(this.txttienthue);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiemhoadon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnchitiethd);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.txttimkiemhoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvhoadon);
            this.Controls.Add(this.dgvchitiethoadon);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageBill";
            this.Size = new System.Drawing.Size(1234, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvchitiethoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mausac;
        private System.Windows.Forms.DataGridViewTextBoxColumn soxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntimkiemhoadon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnchitiethd;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.TextBox txttimkiemhoadon;
        private System.Windows.Forms.DateTimePicker datetimethuexe;
        private System.Windows.Forms.DateTimePicker datetimetraxe;
        private System.Windows.Forms.ComboBox cmbmakh;
        private System.Windows.Forms.Button btnxoahd;
        private System.Windows.Forms.Button btnsuahd;
        private System.Windows.Forms.Button btnthemhd;
        private System.Windows.Forms.TextBox txttienthue;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.ComboBox cmbmaxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthue;
    }
}
