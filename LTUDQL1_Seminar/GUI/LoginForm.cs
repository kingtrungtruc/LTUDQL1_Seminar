using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO.HT;
using DAO.HS;
using System.Data.SqlClient;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            RegisterForm rgs = new RegisterForm();
            rgs.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }
        public delegate void send(); 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVienDangNhap = new GiaoVien();
<<<<<<< HEAD
            DAO.GiaoVienDAO_HT giaoVien = new DAO.GiaoVienDAO_HT();
            try
            {
                giaoVienDangNhap = giaoVien.FindGiaoVien(tbEmail.Text, tbMatKhau.Text);
            }
            catch(SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
            }
           
            if(giaoVienDangNhap.DiaChi != null)
=======
            BUS.HT.GiaoVienBUS giaoVien = new BUS.HT.GiaoVienBUS();
            giaoVienDangNhap = giaoVien.FindGiaoVien(tbEmail.Text, tbMatKhau.Text);
            if(giaoVienDangNhap != null)
>>>>>>> 2bc2634bffcb255b99f00eb9e2042b2a8db80d09
            {
                this.Hide();
                GiaoVienGUI giaoVienGUI = new GiaoVienGUI(giaoVienDangNhap);
                giaoVienGUI.ShowDialog();
                this.Close();
            }
<<<<<<< HEAD
            else
            {
                /*HS đăng nhập*/
                HocSinh HSLogin = new HocSinh();
                DAO.HocSinhDAO_HS hs = new DAO.HocSinhDAO_HS();

                try
                {
                    HSLogin = hs.FindOneHocSinh(tbEmail.Text, tbMatKhau.Text);
                }
                catch(SqlException SqlEx)
                {
                    MessageBox.Show(SqlEx.Message, "Lỗi truy vấn!");
                }
                
                if(HSLogin != null)
                {
                    this.Hide();
                    HocSinhGUI hocSinhGUI = new HocSinhGUI(HSLogin, this);
                    hocSinhGUI.ShowDialog();
                    this.Close();
                }
            }
            
=======
            if(giaoVienDangNhap == null)
            {
                MessageBox.Show("Không trùng Email hoặc Password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
>>>>>>> 2bc2634bffcb255b99f00eb9e2042b2a8db80d09
        }
    }
}
