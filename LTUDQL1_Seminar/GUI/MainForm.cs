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
    public partial class MainForm : Form
    {
        int Login = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        public delegate int SendLogin();

        public int checkLogin()
        {
            Login = 1;
            return Login;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
                       
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(Login == 0)
            {
                LoginForm lgf = new LoginForm(checkLogin);
                lgf.Show();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            RegisterForm rgtf = new RegisterForm();
            rgtf.Show();
        }
    }
}
