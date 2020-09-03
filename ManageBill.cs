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
using DTO;

namespace GUI.UserControls
{
    public partial class ManageBill : UserControl
    {
        String connstring = @"Data Source=DESKTOP-3KKJ8H8\SLQ2019;Initial Catalog=QLXeDuLich;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        public ManageBill()
        {
            InitializeComponent();
            txtNameEmp.Text = LoginInfo.Name;

            LoadCustomers();
            LoadCars();
            LoadData();
        }

        private void ManageBill_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCustomers();
            LoadCars();
        }

        public void LoadCustomers()
        {
            try 
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select Customers.ID,Customers.[Name] From Customers", conn);
                DataTable cmbKH = new DataTable();
                da.Fill(cmbKH);
                cmbmakh.DataSource = cmbKH;
                cmbmakh.DisplayMember = "Name";
                cmbmakh.ValueMember = "ID";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadCars()
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select InforCar.ID,InforCar.[Name] from InforCar", conn);
                DataTable cmbXE = new DataTable();
                da.Fill(cmbXE);
                cmbmaxe.DataSource = cmbXE;
                cmbmaxe.DisplayMember = "Name";
                cmbmaxe.ValueMember = "ID";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadData()
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql = $"select Bills.ID,Bills.DateOfHire,Bills.DateOfPayment,Bills.PricePerDay,InforCar.[Name] as CarName,Customers.[Name] as CustomerName, Employee.[Name] as EmpName " +
                                "from Bills inner join Customers on Bills.CustomerID = Customers.ID inner " +
                                "join Employee on Bills.EmpID = Employee.ID inner " +
                                "join InforCar on Bills.InforCarID = InforCar.ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlCommand cmd = new SqlCommand("Select * from Bills", conn);

                //SqlDataAdapter ad1 = new SqlDataAdapter("Select ID From Customers", conn);
                //DataTable cmbKH = new DataTable();
                //ad1.Fill(cmbKH);
                //cmbmakh.DataSource = cmbKH;
                //cmbmakh.DisplayMember = "ID";
                //cmbmakh.ValueMember = "ID";

                //SqlDataAdapter ad2 = new SqlDataAdapter("Select ID From Employee", conn);
                //DataTable cmbNV = new DataTable();
                //ad2.Fill(cmbNV);
                //cmbmanv.DataSource = cmbNV;
                //cmbmanv.DisplayMember = "ID";
                //cmbmanv.ValueMember = "ID";

                //SqlDataAdapter ad3 = new SqlDataAdapter("Select ID From InforCar", conn);
                //DataTable cmbXE = new DataTable();
                //ad3.Fill(cmbXE);
                //cmbmaxe.DataSource = cmbXE;
                //cmbmaxe.DisplayMember = "ID";
                //cmbmaxe.ValueMember = "ID";

                SqlDataReader dr = cmd.ExecuteReader();
                int index = 0;
                dgvhoadon.ColumnCount = 8;
                dgvhoadon.Rows.Clear();
                while (dr.Read())
                {
                    dgvhoadon.Rows.Add();
                    dgvhoadon.Rows[index].Cells[0].Value = index + 1;
                    dgvhoadon.Rows[index].Cells[1].Value = dr["ID"];
                    dgvhoadon.Rows[index].Cells[2].Value = dr["CustomerName"];
                    dgvhoadon.Rows[index].Cells[3].Value = dr["EmpName"];
                    dgvhoadon.Rows[index].Cells[4].Value = dr["DateOfHire"];
                    dgvhoadon.Rows[index].Cells[5].Value = dr["DateOfPayment"];
                    dgvhoadon.Rows[index].Cells[6].Value = dr["CarName"];
                    dgvhoadon.Rows[index].Cells[7].Value = dr["PricePerDay"];

                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void SetNull()
        {
            txtmahd.Text = null;
            txttienthue.Text = null;
            cmbmakh.Text = null;
            //cmbmanv.Text = null;
            cmbmaxe.Text = null;
            datetimetraxe.Text = null;
            datetimetraxe.Text = null;
            txttienthue.Text = null;

            txtmahd.Focus();
        }

        private void dgvhoadonCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvhoadon.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvhoadon.Rows[index];

            txtmahd.Text = Convert.ToString(row.Cells[1].Value);
            cmbmakh.Text = Convert.ToString(row.Cells[2].Value);
            //cmbmanv.Text = Convert.ToString(row.Cells[3].Value);
            cmbmaxe.Text = Convert.ToString(row.Cells[6].Value);
            datetimethuexe.Text = Convert.ToString(row.Cells[4].Value);
            datetimetraxe.Text = Convert.ToString(row.Cells[5].Value);
            txttienthue.Text = Convert.ToString(row.Cells[7].Value);

        }

        private void btnchitiethd_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txtmahd.Text);

                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql = "select * from Bills inner join Punish on Bills.ID=Punish.BillsID inner join Customers on Customers.ID=Punish.CustomerID inner join Employee on Employee.ID=Punish.EmpID inner join InforCar on InforCar.ID=Bills.InforCarID where Bills.ID='" + ma + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);



                SqlDataReader dr = cmd.ExecuteReader();
                int index = 0;
                dgvchitiethoadon.ColumnCount = 10;
                dgvchitiethoadon.Rows.Clear();
                while (dr.Read())
                {
                    dgvchitiethoadon.Rows.Add();
                    dgvchitiethoadon.Rows[index].Cells[0].Value = index + 1;
                    dgvchitiethoadon.Rows[index].Cells[1].Value = dr["Name"];
                    dgvchitiethoadon.Rows[index].Cells[2].Value = dr[18];
                    dgvchitiethoadon.Rows[index].Cells[3].Value = dr[24];

                    DateTime ngaytra = Convert.ToDateTime(dr["DateOfPayment"]);
                    DateTime ngaymuon = Convert.ToDateTime(dr["DateOfHire"]);
                    TimeSpan Time = ngaytra - ngaymuon;
                    int TongSoNgay = Time.Days;
                    int dongia = int.Parse(dr["PricePerDay"].ToString());
                    dgvchitiethoadon.Rows[index].Cells[4].Value = TongSoNgay;
                    dgvchitiethoadon.Rows[index].Cells[5].Value = dr["PricePerDay"];
                    dgvchitiethoadon.Rows[index].Cells[6].Value = dr[32];
                    dgvchitiethoadon.Rows[index].Cells[7].Value = dr[34];
                    dgvchitiethoadon.Rows[index].Cells[8].Value = dr[37];
                    dgvchitiethoadon.Rows[index].Cells[9].Value = TongSoNgay * dongia;

                    index++;
                }
                LoadData();
                SetNull();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnthemhd_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
               
                string sql = $"insert into Bills values(N'HĐ{txtmahd}',{LoginInfo.ID},{cmbmakh.SelectedValue},'{datetimethuexe.Value}','{datetimetraxe.Value}',{int.Parse(txttienthue.Text)},{cmbmaxe.SelectedValue},'{DateTime.Now}',0)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();

                LoadData();
                SetNull();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoahd_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Bạn muốn xoá hóa đơn {txtmahd.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Bills Where ID='" + txtmahd.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    SetNull();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsuahd_Click(object sender, EventArgs e)
        {

            try
            {
                var result = MessageBox.Show($"Bạn muốn sửa thông tin hóa đơn {txtmahd.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string sql = "Update Bills set CustomerID=@IDKH, EmpID=@IDNV,InforCarID=@IDCAR,PricePerDay=@TT,DateOfHire=@DATE1,DateOfPayment=@DATE2 Where ID='" + txtmahd.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@IDKH", cmbmakh.SelectedValue);
                    cmd.Parameters.AddWithValue("@IDNV", LoginInfo.ID);
                    cmd.Parameters.AddWithValue("@DATE1", datetimethuexe.Value);
                    cmd.Parameters.AddWithValue("@DATE2", datetimetraxe.Value);
                    cmd.Parameters.AddWithValue("@TT", Int32.Parse(txttienthue.Text));
                    cmd.Parameters.AddWithValue("@IDCAR", cmbmaxe.SelectedValue);

                    cmd.ExecuteNonQuery();

                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    LoadData();
                    SetNull();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btntimkiemhoadon_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"select Bills.ID,Bills.DateOfHire,Bills.DateOfPayment,Bills.PricePerDay,InforCar.[Name] as CarName,Customers.[Name] as CustomerName, Employee.[Name] as EmpName " +
                                "from Bills inner join Customers on Bills.CustomerID = Customers.ID inner " +
                                "join Employee on Bills.EmpID = Employee.ID inner " +
                                "join InforCar on Bills.InforCarID = InforCar.ID where Bills.ID='"+txttimkiemhoadon.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                SqlDataReader dr = cmd.ExecuteReader();
                int index = 0;
                dgvhoadon.ColumnCount = 8;
                dgvhoadon.Rows.Clear();
                while (dr.Read())
                {
                    dgvhoadon.Rows.Add();
                    dgvhoadon.Rows[index].Cells[0].Value = index + 1;
                    dgvhoadon.Rows[index].Cells[1].Value = dr["ID"];
                    dgvhoadon.Rows[index].Cells[2].Value = dr["CustomerName"];
                    dgvhoadon.Rows[index].Cells[3].Value = dr["EmpName"];
                    dgvhoadon.Rows[index].Cells[4].Value = dr["DateOfHire"];
                    dgvhoadon.Rows[index].Cells[5].Value = dr["DateOfPayment"];
                    dgvhoadon.Rows[index].Cells[6].Value = dr["CarName"];
                    dgvhoadon.Rows[index].Cells[7].Value = dr["PricePerDay"];

                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            LoadData();
            SetNull();
            dgvchitiethoadon.Rows.Clear();
        }
    }
}
