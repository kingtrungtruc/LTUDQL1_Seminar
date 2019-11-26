﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO.HT;
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
            BUS.HT.GiaoVienBUS giaoVien = new BUS.HT.GiaoVienBUS();
            giaoVienDangNhap = giaoVien.FindGiaoVien(tbEmail.Text, tbMatKhau.Text);
            if(giaoVienDangNhap != null)
            {
                this.Hide();
                GiaoVienGUI giaoVienGUI = new GiaoVienGUI(giaoVienDangNhap);
                giaoVienGUI.ShowDialog();
                this.Close();
            }
            if(giaoVienDangNhap == null)
            {
                MessageBox.Show("Không trùng Email hoặc Password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
