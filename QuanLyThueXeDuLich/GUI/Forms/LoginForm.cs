using BUS.Globals;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class LoginForm : Form
    {
        DataContext db = new DataContext();
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPW.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '•';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*var Acc = txtAccount.Text.ToLower();
            var PW = txtPassword.Text.ToLower();
            var _pw = Security.Encrypt(PW);

            var account = db.Employees.Where(x => x.Account == Acc && x.Password == _pw).FirstOrDefault();
            if (account != null)
            {
                LoginInfo.ID = account.ID;
                LoginInfo.Name = account.Name;
                LoginInfo.Role = account.Role;
                new MainForm().Visible=true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            new MainForm().Visible = true;
            this.Visible = false;
        }
    }
}
