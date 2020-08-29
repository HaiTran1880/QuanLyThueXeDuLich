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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttienthue = new System.Windows.Forms.TextBox();
            this.btnthemhd = new System.Windows.Forms.Button();
            this.btnsuahd = new System.Windows.Forms.Button();
            this.btnxoahd = new System.Windows.Forms.Button();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.bthhuy = new System.Windows.Forms.Button();
            this.cmbmakh = new System.Windows.Forms.ComboBox();
            this.cmbmanv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnchitiethd = new System.Windows.Forms.Button();
            this.dgvchitiethoadon = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datetimetraxe = new System.Windows.Forms.DateTimePicker();
            this.txttimkiemhoadon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btntimkiemhoadon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datetimethuexe = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbmaxe = new System.Windows.Forms.ComboBox();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthue = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhân Viên Lập ";
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mahd,
            this.makh,
            this.manv,
            this.ngaythue,
            this.ngaytra,
            this.maxe,
            this.tienthue});
            this.dgvhoadon.Location = new System.Drawing.Point(399, 34);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.Size = new System.Drawing.Size(817, 373);
            this.dgvhoadon.TabIndex = 1;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadonCellClick);
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(175, 34);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(200, 29);
            this.txtmahd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Trả Xe";
            // 
            // txttienthue
            // 
            this.txttienthue.Location = new System.Drawing.Point(175, 316);
            this.txttienthue.Name = "txttienthue";
            this.txttienthue.Size = new System.Drawing.Size(199, 29);
            this.txttienthue.TabIndex = 2;
            // 
            // btnthemhd
            // 
            this.btnthemhd.Location = new System.Drawing.Point(0, 368);
            this.btnthemhd.Name = "btnthemhd";
            this.btnthemhd.Size = new System.Drawing.Size(104, 39);
            this.btnthemhd.TabIndex = 3;
            this.btnthemhd.Text = "Thêm Mới";
            this.btnthemhd.UseVisualStyleBackColor = true;
            this.btnthemhd.Click += new System.EventHandler(this.btnthemhd_Click);
            // 
            // btnsuahd
            // 
            this.btnsuahd.Location = new System.Drawing.Point(119, 368);
            this.btnsuahd.Name = "btnsuahd";
            this.btnsuahd.Size = new System.Drawing.Size(135, 39);
            this.btnsuahd.TabIndex = 3;
            this.btnsuahd.Text = "Sửa Thông Tin";
            this.btnsuahd.UseVisualStyleBackColor = true;
            this.btnsuahd.Click += new System.EventHandler(this.btnsuahd_Click);
            // 
            // btnxoahd
            // 
            this.btnxoahd.Location = new System.Drawing.Point(267, 368);
            this.btnxoahd.Name = "btnxoahd";
            this.btnxoahd.Size = new System.Drawing.Size(104, 39);
            this.btnxoahd.TabIndex = 3;
            this.btnxoahd.Text = "Xóa";
            this.btnxoahd.UseVisualStyleBackColor = true;
            this.btnxoahd.Click += new System.EventHandler(this.btnxoahd_Click);
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.Location = new System.Drawing.Point(1, 426);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(104, 39);
            this.btnnhaplai.TabIndex = 3;
            this.btnnhaplai.Text = "Nhập Lại";
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // bthhuy
            // 
            this.bthhuy.Location = new System.Drawing.Point(268, 426);
            this.bthhuy.Name = "bthhuy";
            this.bthhuy.Size = new System.Drawing.Size(104, 39);
            this.bthhuy.TabIndex = 3;
            this.bthhuy.Text = "Hủy";
            this.bthhuy.UseVisualStyleBackColor = true;
            // 
            // cmbmakh
            // 
            this.cmbmakh.FormattingEnabled = true;
            this.cmbmakh.Location = new System.Drawing.Point(175, 81);
            this.cmbmakh.Name = "cmbmakh";
            this.cmbmakh.Size = new System.Drawing.Size(200, 29);
            this.cmbmakh.TabIndex = 4;
            // 
            // cmbmanv
            // 
            this.cmbmanv.FormattingEnabled = true;
            this.cmbmanv.Location = new System.Drawing.Point(175, 128);
            this.cmbmanv.Name = "cmbmanv";
            this.cmbmanv.Size = new System.Drawing.Size(200, 29);
            this.cmbmanv.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(655, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Danh Sách Hóa Đơn ";
            // 
            // btnchitiethd
            // 
            this.btnchitiethd.Location = new System.Drawing.Point(120, 426);
            this.btnchitiethd.Name = "btnchitiethd";
            this.btnchitiethd.Size = new System.Drawing.Size(135, 39);
            this.btnchitiethd.TabIndex = 3;
            this.btnchitiethd.Text = "Chi Tiết";
            this.btnchitiethd.UseVisualStyleBackColor = true;
            this.btnchitiethd.Click += new System.EventHandler(this.btnchitiethd_Click);
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
            this.dgvchitiethoadon.Location = new System.Drawing.Point(3, 508);
            this.dgvchitiethoadon.Name = "dgvchitiethoadon";
            this.dgvchitiethoadon.Size = new System.Drawing.Size(1209, 273);
            this.dgvchitiethoadon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(543, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thông tin chi tiết dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tiền Thuê";
            // 
            // datetimetraxe
            // 
            this.datetimetraxe.CustomFormat = "dd-MM-yyyy";
            this.datetimetraxe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimetraxe.Location = new System.Drawing.Point(175, 269);
            this.datetimetraxe.Name = "datetimetraxe";
            this.datetimetraxe.Size = new System.Drawing.Size(199, 29);
            this.datetimetraxe.TabIndex = 6;
            // 
            // txttimkiemhoadon
            // 
            this.txttimkiemhoadon.Location = new System.Drawing.Point(540, 426);
            this.txttimkiemhoadon.Name = "txttimkiemhoadon";
            this.txttimkiemhoadon.Size = new System.Drawing.Size(488, 29);
            this.txttimkiemhoadon.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "**Nhập mã hóa đơn cần tìm";
            // 
            // btntimkiemhoadon
            // 
            this.btntimkiemhoadon.Location = new System.Drawing.Point(396, 426);
            this.btntimkiemhoadon.Name = "btntimkiemhoadon";
            this.btntimkiemhoadon.Size = new System.Drawing.Size(124, 39);
            this.btntimkiemhoadon.TabIndex = 9;
            this.btntimkiemhoadon.Text = "Tìm kiếm";
            this.btntimkiemhoadon.UseVisualStyleBackColor = true;
            this.btntimkiemhoadon.Click += new System.EventHandler(this.btntimkiemhoadon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày Thuê Xe";
            // 
            // datetimethuexe
            // 
            this.datetimethuexe.CustomFormat = "dd-MM-yyyy";
            this.datetimethuexe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimethuexe.Location = new System.Drawing.Point(175, 222);
            this.datetimethuexe.Name = "datetimethuexe";
            this.datetimethuexe.Size = new System.Drawing.Size(199, 29);
            this.datetimethuexe.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Xe ";
            // 
            // cmbmaxe
            // 
            this.cmbmaxe.FormattingEnabled = true;
            this.cmbmaxe.Location = new System.Drawing.Point(175, 175);
            this.cmbmaxe.Name = "cmbmaxe";
            this.cmbmaxe.Size = new System.Drawing.Size(200, 29);
            this.cmbmaxe.TabIndex = 4;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // mahd
            // 
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            this.mahd.Width = 70;
            // 
            // makh
            // 
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.Name = "makh";
            this.makh.Width = 70;
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            this.manv.Width = 70;
            // 
            // ngaythue
            // 
            this.ngaythue.HeaderText = "Ngày thuê";
            this.ngaythue.Name = "ngaythue";
            // 
            // ngaytra
            // 
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.Name = "ngaytra";
            // 
            // maxe
            // 
            this.maxe.HeaderText = "Mã xe thuê";
            this.maxe.Name = "maxe";
            // 
            // tienthue
            // 
            this.tienthue.HeaderText = "Tiền thuê xe";
            this.tienthue.Name = "tienthue";
            this.tienthue.Width = 180;
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
            // ManageBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btntimkiemhoadon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datetimethuexe);
            this.Controls.Add(this.datetimetraxe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbmaxe);
            this.Controls.Add(this.cmbmanv);
            this.Controls.Add(this.cmbmakh);
            this.Controls.Add(this.bthhuy);
            this.Controls.Add(this.btnxoahd);
            this.Controls.Add(this.btnchitiethd);
            this.Controls.Add(this.btnsuahd);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.btnthemhd);
            this.Controls.Add(this.txttimkiemhoadon);
            this.Controls.Add(this.txttienthue);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.dgvchitiethoadon);
            this.Controls.Add(this.dgvhoadon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageBill";
            this.Size = new System.Drawing.Size(1234, 697);
            this.Load += new System.EventHandler(this.ManageBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttienthue;
        private System.Windows.Forms.Button btnthemhd;
        private System.Windows.Forms.Button btnsuahd;
        private System.Windows.Forms.Button btnxoahd;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Button bthhuy;
        private System.Windows.Forms.ComboBox cmbmakh;
        private System.Windows.Forms.ComboBox cmbmanv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnchitiethd;
        private System.Windows.Forms.DataGridView dgvchitiethoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datetimetraxe;
        private System.Windows.Forms.TextBox txttimkiemhoadon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btntimkiemhoadon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datetimethuexe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbmaxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthue;
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
    }
}
