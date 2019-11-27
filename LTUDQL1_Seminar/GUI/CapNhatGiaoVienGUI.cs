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
using DTO;

namespace GUI
{
    public partial class CapNhatGiaoVienGUI : Form
    {
        GiaoVien giaovien;
        public CapNhatGiaoVienGUI(GiaoVien giaoVien)
        {
            InitializeComponent();
            giaovien = giaoVien;
            this.LoadGiaoVien();
        }

        void LoadGiaoVien()
        {
            txtMaGiaoVien.Text = giaovien.MaGiaVien;
            txtHoTenGiaoVien.Text = giaovien.HoTen;
            txtEmailGiaoVien.Text = giaovien.Email;
            txtDiaChiGiaoVien.Text = giaovien.DiaChi;
            txtPasswordGiaoVien.PasswordChar = '*';
            txtPasswordGiaoVien.Text = giaovien.Password;
            txtSDTGiaoVien.Text = giaovien.SDT;
            
        }

        private void CapNhatGiaoVienGUI_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
