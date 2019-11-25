using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        MainForm.SendLogin send;
        public LoginForm(MainForm.SendLogin send)
        {
            InitializeComponent();
            this.send = send;
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
            {
                tbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Register rgs = new Register();
            rgs.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.send();
            this.Close();
        }
    }
}
