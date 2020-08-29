namespace GUI.UserControls
{
    partial class ManagePunish
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
            this.dgvphat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttienphat = new System.Windows.Forms.TextBox();
            this.btnthemphieu = new System.Windows.Forms.Button();
            this.btnsuaphieu = new System.Windows.Forms.Button();
            this.btnxoaphieu = new System.Windows.Forms.Button();
            this.btntimphieu = new System.Windows.Forms.Button();
            this.datephieuphat = new System.Windows.Forms.DateTimePicker();
            this.cmbmanv = new System.Windows.Forms.ComboBox();
            this.cmbmakh = new System.Windows.Forms.ComboBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.txttimkiemphieu = new System.Windows.Forms.TextBox();
            this.btnrefesh = new System.Windows.Forms.Button();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieuphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvphat
            // 
            this.dgvphat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maphieuphat,
            this.mahd,
            this.manv,
            this.makh,
            this.mota,
            this.tienphat,
            this.ngaylap});
            this.dgvphat.Location = new System.Drawing.Point(7, 310);
            this.dgvphat.Margin = new System.Windows.Forms.Padding(5);
            this.dgvphat.Name = "dgvphat";
            this.dgvphat.Size = new System.Drawing.Size(1234, 697);
            this.dgvphat.TabIndex = 0;
            this.dgvphat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphat_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(88, 41);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(150, 29);
            this.txtmaphieu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(360, 41);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(150, 29);
            this.txtmahd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(802, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mô tả";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(88, 119);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(422, 29);
            this.txtmota.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày lập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tiền phạt";
            // 
            // txttienphat
            // 
            this.txttienphat.Location = new System.Drawing.Point(952, 119);
            this.txttienphat.Name = "txttienphat";
            this.txttienphat.Size = new System.Drawing.Size(150, 29);
            this.txttienphat.TabIndex = 2;
            // 
            // btnthemphieu
            // 
            this.btnthemphieu.Location = new System.Drawing.Point(183, 205);
            this.btnthemphieu.Name = "btnthemphieu";
            this.btnthemphieu.Size = new System.Drawing.Size(104, 43);
            this.btnthemphieu.TabIndex = 3;
            this.btnthemphieu.Text = "Thêm";
            this.btnthemphieu.UseVisualStyleBackColor = true;
            this.btnthemphieu.Click += new System.EventHandler(this.btnthemphieu_Click);
            // 
            // btnsuaphieu
            // 
            this.btnsuaphieu.Location = new System.Drawing.Point(359, 205);
            this.btnsuaphieu.Name = "btnsuaphieu";
            this.btnsuaphieu.Size = new System.Drawing.Size(104, 43);
            this.btnsuaphieu.TabIndex = 3;
            this.btnsuaphieu.Text = "Sửa";
            this.btnsuaphieu.UseVisualStyleBackColor = true;
            this.btnsuaphieu.Click += new System.EventHandler(this.btnsuaphieu_Click);
            // 
            // btnxoaphieu
            // 
            this.btnxoaphieu.Location = new System.Drawing.Point(535, 205);
            this.btnxoaphieu.Name = "btnxoaphieu";
            this.btnxoaphieu.Size = new System.Drawing.Size(104, 43);
            this.btnxoaphieu.TabIndex = 3;
            this.btnxoaphieu.Text = "Xóa";
            this.btnxoaphieu.UseVisualStyleBackColor = true;
            this.btnxoaphieu.Click += new System.EventHandler(this.btnxoaphieu_Click);
            // 
            // btntimphieu
            // 
            this.btntimphieu.Location = new System.Drawing.Point(535, 259);
            this.btntimphieu.Name = "btntimphieu";
            this.btntimphieu.Size = new System.Drawing.Size(104, 43);
            this.btntimphieu.TabIndex = 3;
            this.btntimphieu.Text = "Tìm kiếm";
            this.btntimphieu.UseVisualStyleBackColor = true;
            this.btntimphieu.Click += new System.EventHandler(this.btntimphieu_Click);
            // 
            // datephieuphat
            // 
            this.datephieuphat.CustomFormat = "dd-MM-yyyy";
            this.datephieuphat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datephieuphat.Location = new System.Drawing.Point(628, 127);
            this.datephieuphat.Name = "datephieuphat";
            this.datephieuphat.Size = new System.Drawing.Size(150, 29);
            this.datephieuphat.TabIndex = 4;
            // 
            // cmbmanv
            // 
            this.cmbmanv.FormattingEnabled = true;
            this.cmbmanv.Location = new System.Drawing.Point(628, 41);
            this.cmbmanv.Name = "cmbmanv";
            this.cmbmanv.Size = new System.Drawing.Size(150, 29);
            this.cmbmanv.TabIndex = 5;
            // 
            // cmbmakh
            // 
            this.cmbmakh.FormattingEnabled = true;
            this.cmbmakh.Location = new System.Drawing.Point(952, 41);
            this.cmbmakh.Name = "cmbmakh";
            this.cmbmakh.Size = new System.Drawing.Size(150, 29);
            this.cmbmakh.TabIndex = 6;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(7, 205);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(104, 43);
            this.btnlammoi.TabIndex = 3;
            this.btnlammoi.Text = "Nhập lại";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // txttimkiemphieu
            // 
            this.txttimkiemphieu.Location = new System.Drawing.Point(7, 254);
            this.txttimkiemphieu.Name = "txttimkiemphieu";
            this.txttimkiemphieu.Size = new System.Drawing.Size(503, 29);
            this.txttimkiemphieu.TabIndex = 2;
            // 
            // btnrefesh
            // 
            this.btnrefesh.Location = new System.Drawing.Point(696, 206);
            this.btnrefesh.Name = "btnrefesh";
            this.btnrefesh.Size = new System.Drawing.Size(93, 42);
            this.btnrefesh.TabIndex = 7;
            this.btnrefesh.Text = "Làm mới";
            this.btnrefesh.UseVisualStyleBackColor = true;
            this.btnrefesh.Click += new System.EventHandler(this.btnrefesh_Click);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // maphieuphat
            // 
            this.maphieuphat.HeaderText = "Mã phiếu phạt";
            this.maphieuphat.Name = "maphieuphat";
            // 
            // mahd
            // 
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // makh
            // 
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.Name = "makh";
            // 
            // mota
            // 
            this.mota.HeaderText = "Mô tả";
            this.mota.Name = "mota";
            this.mota.Width = 320;
            // 
            // tienphat
            // 
            this.tienphat.HeaderText = "Tiền phạt";
            this.tienphat.Name = "tienphat";
            this.tienphat.Width = 160;
            // 
            // ngaylap
            // 
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Width = 160;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "**Nhập mã phiếu cần tìm kiếm thông tin";
            // 
            // ManagePunish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnrefesh);
            this.Controls.Add(this.cmbmakh);
            this.Controls.Add(this.cmbmanv);
            this.Controls.Add(this.datephieuphat);
            this.Controls.Add(this.btntimphieu);
            this.Controls.Add(this.btnxoaphieu);
            this.Controls.Add(this.btnsuaphieu);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnthemphieu);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.txttienphat);
            this.Controls.Add(this.txttimkiemphieu);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtmaphieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvphat);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManagePunish";
            this.Size = new System.Drawing.Size(1234, 978);
            this.Load += new System.EventHandler(this.ManagePunish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvphat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttienphat;
        private System.Windows.Forms.Button btnthemphieu;
        private System.Windows.Forms.Button btnsuaphieu;
        private System.Windows.Forms.Button btnxoaphieu;
        private System.Windows.Forms.Button btntimphieu;
        private System.Windows.Forms.DateTimePicker datephieuphat;
        private System.Windows.Forms.ComboBox cmbmanv;
        private System.Windows.Forms.ComboBox cmbmakh;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.TextBox txttimkiemphieu;
        private System.Windows.Forms.Button btnrefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.Label label8;
    }
}
