using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI.UserControls
{
    public partial class CustomersUC : UserControl
    {
        String connstring = @"Data Source=HOANGUYEN;Initial Catalog=QLXeDuLich;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        public CustomersUC()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(connstring);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customers", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int index = 0;
            dgvKhachHang.ColumnCount = 6;
            dgvKhachHang.Rows.Clear();
            while (dr.Read())
            {
                dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = dr["ID"];
                dgvKhachHang.Rows[index].Cells[1].Value = dr["Name"];
                dgvKhachHang.Rows[index].Cells[2].Value = dr["IDCardNumber"];
                if (dr["Sex"].Equals(true))
                {
                    dgvKhachHang.Rows[index].Cells[3].Value = "Nam";
                }
                else
                {
                    dgvKhachHang.Rows[index].Cells[3].Value = "Nữ";
                }
                dgvKhachHang.Rows[index].Cells[4].Value = dr["Phone"];
                dgvKhachHang.Rows[index].Cells[5].Value = dr["Address"];

                index++;
            }
        }

        private void SetNull()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSoCMNDKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChi.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            cbbTimKiemTheo.SelectedIndex = -1;
            cbbTimKiemTheo.Text = "---Tìm kiếm theo---";

        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql = "Insert into Customers values (@ID,@Name, @Sex, @IDCardNumber, @Phone, @Address)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtMaKH.Text));
                cmd.Parameters.AddWithValue("@Name", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@IDCardNumber", Int32.Parse(txtSoCMNDKH.Text));
                cmd.Parameters.AddWithValue("@Phone", txtSDTKH.Text);
                cmd.Parameters.AddWithValue("@Address", txtDiaChi.Text);
                if (rdbNam.Checked)
                {
                    cmd.Parameters.AddWithValue("@Sex", 1);
                }
                else
                {

                    cmd.Parameters.AddWithValue("@Sex", 0);
                }
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql = "Update Customers set Name=@Name, Sex=@Sex, IDCardNumber=@IDCardNumber, Phone=@Phone, Address=@Address Where ID='" + txtMaKH.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@IDCardNumber", Int32.Parse(txtSoCMNDKH.Text));
                cmd.Parameters.AddWithValue("@Phone", txtSDTKH.Text);
                cmd.Parameters.AddWithValue("@Address", txtDiaChi.Text);
                if (rdbNam.Checked)
                {
                    cmd.Parameters.AddWithValue("@Sex", true);
                }
                else
                {

                    cmd.Parameters.AddWithValue("@Sex", false);
                }
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Bạn muốn xoá nhân viên {txtTenKH.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Customers Where ID='" + txtMaKH.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int row;
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtMaKH.Text = dgvKhachHang.Rows[row].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[row].Cells[1].Value.ToString();
                txtSoCMNDKH.Text = dgvKhachHang.Rows[row].Cells[2].Value.ToString();
                txtSDTKH.Text = dgvKhachHang.Rows[row].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[row].Cells[5].Value.ToString();
                if (dgvKhachHang.Rows[row].Cells[3].Value.Equals(rdbNam.Text))
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
            }
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var index = cbbTimKiemTheo.SelectedIndex;

                switch (index)
                {
                    case 0://tìm kiếm theo tên
                        String sql0 = "Select * from Customers Where Name=N'" + txtTenKH.Text + "'";
                        SqlCommand cmd0 = new SqlCommand(sql0, conn);
                        cmd0.ExecuteNonQuery();
                        SqlDataReader dr0 = cmd0.ExecuteReader();
                        int i0 = 0;
                        dgvKhachHang.ColumnCount = 6;
                        dgvKhachHang.Rows.Clear();
                        while (dr0.Read())
                        {
                            dgvKhachHang.Rows.Add();
                            dgvKhachHang.Rows[i0].Cells[0].Value = dr0["ID"];
                            dgvKhachHang.Rows[i0].Cells[1].Value = dr0["Name"];
                            dgvKhachHang.Rows[i0].Cells[2].Value = dr0["IDCardNumber"];
                            if (dr0["Sex"].Equals(true))
                            {
                                dgvKhachHang.Rows[i0].Cells[3].Value = "Nam";
                            }
                            else
                            {
                                dgvKhachHang.Rows[i0].Cells[3].Value = "Nữ";
                            }
                            dgvKhachHang.Rows[i0].Cells[4].Value = dr0["Phone"];
                            dgvKhachHang.Rows[i0].Cells[5].Value = dr0["Address"];

                            i0++;
                        }

                        break;


                    case 1://tìm kiếm theo địa chỉ
                        String sql1 = "Select * from Customers Where Address=N'" + txtDiaChi.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                        cmd1.ExecuteNonQuery();
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        int i1 = 0;
                        dgvKhachHang.ColumnCount = 6;
                        dgvKhachHang.Rows.Clear();
                        while (dr1.Read())
                        {
                            dgvKhachHang.Rows.Add();
                            dgvKhachHang.Rows[i1].Cells[0].Value = dr1["ID"];
                            dgvKhachHang.Rows[i1].Cells[1].Value = dr1["Name"];
                            dgvKhachHang.Rows[i1].Cells[2].Value = dr1["IDCardNumber"];
                            if (dr1["Sex"].Equals(true))
                            {
                                dgvKhachHang.Rows[i1].Cells[3].Value = "Nam";
                            }
                            else
                            {
                                dgvKhachHang.Rows[i1].Cells[3].Value = "Nữ";
                            }
                            dgvKhachHang.Rows[i1].Cells[4].Value = dr1["Phone"];
                            dgvKhachHang.Rows[i1].Cells[5].Value = dr1["Address"];

                            i1++;
                        }

                        break;



                    case 2://tìm kiếm theo số CMND
                        String sql2 = "Select * from Customers Where IDCardNumber='" + txtSoCMNDKH.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        cmd2.ExecuteNonQuery();
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        int i2 = 0;
                        dgvKhachHang.ColumnCount = 6;
                        dgvKhachHang.Rows.Clear();
                        while (dr2.Read())
                        {
                            dgvKhachHang.Rows.Add();
                            dgvKhachHang.Rows[i2].Cells[0].Value = dr2["ID"];
                            dgvKhachHang.Rows[i2].Cells[1].Value = dr2["Name"];
                            dgvKhachHang.Rows[i2].Cells[2].Value = dr2["IDCardNumber"];
                            if (dr2["Sex"].Equals(true))
                            {
                                dgvKhachHang.Rows[i2].Cells[3].Value = "Nam";
                            }
                            else
                            {
                                dgvKhachHang.Rows[i2].Cells[3].Value = "Nữ";
                            }
                            dgvKhachHang.Rows[i2].Cells[4].Value = dr2["Phone"];
                            dgvKhachHang.Rows[i2].Cells[5].Value = dr2["Address"];

                            i2++;
                        }

                        break;

                    default:
                        txtSoCMNDKH.Enabled = true;
                        txtSDTKH.Enabled = true;
                        txtTenKH.Enabled = true;
                        rdbNam.Enabled = true;
                        rdbNu.Enabled = true;
                        txtTenKH.Enabled = true;
                        txtDiaChi.Enabled = true;
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbbTimKiemTheo.SelectedIndex;

            switch (index)
            {
                case 0://tìm kiếm theo tên
                    txtMaKH.Enabled = false;
                    txtTenKH.Enabled = true;
                    txtSoCMNDKH.Enabled = false;
                    txtSDTKH.Enabled = false;
                    txtDiaChi.Enabled = false;
                    rdbNam.Enabled = false;
                    rdbNu.Enabled = false;
                    break;

                case 1://tìm kiếm theo địa chỉ
                    txtMaKH.Enabled = false;
                    txtDiaChi.Enabled = true;
                    txtSoCMNDKH.Enabled = false;
                    txtSDTKH.Enabled = false;
                    txtTenKH.Enabled = false;
                    rdbNam.Enabled = false;
                    rdbNu.Enabled = false;
                    break;

                case 2://tìm kiếm theo số CMND
                    txtMaKH.Enabled = false;
                    txtSoCMNDKH.Enabled = true;
                    txtDiaChi.Enabled = false;
                    txtSDTKH.Enabled = false;
                    txtTenKH.Enabled = false;
                    rdbNam.Enabled = false;
                    rdbNu.Enabled = false;
                    break;

                default:
                    txtMaKH.Enabled = true;
                    txtSoCMNDKH.Enabled = true;
                    txtSDTKH.Enabled = true;
                    txtTenKH.Enabled = true;
                    rdbNam.Enabled = true;
                    rdbNu.Enabled = true;
                    txtTenKH.Enabled = true;
                    txtDiaChi.Enabled = true;
                    break;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SetNull();
            LoadData();
        }

    }
}
