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
    public partial class GiaoVienGUI : Form
    {
        GiaoVien GiaoVien;
        public GiaoVienGUI(GiaoVien giaoVien)
        {
            InitializeComponent();
            lbNameGiaoVien.Text = giaoVien.HoTen;
            this.GiaoVien = giaoVien;
            
        }

        private void GiaoVienGUI_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdateGiaoVien_Click(object sender, EventArgs e)
        {
            CapNhatGiaoVienGUI capNhatGiaoVien = new CapNhatGiaoVienGUI(GiaoVien);
            capNhatGiaoVien.ShowDialog();
        }
    }
}
