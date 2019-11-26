using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.HT;
using DTO;

namespace BUS.HT
{
    public class GiaoVienBUS
    {
        public GiaoVien FindGiaoVien(string Email,string Password)
        {
            DAO.GiaoVienDAO_HT giaoVien = new DAO.GiaoVienDAO_HT();
            return giaoVien.FindGiaoVien(Email, Password);
        }
    }
}
