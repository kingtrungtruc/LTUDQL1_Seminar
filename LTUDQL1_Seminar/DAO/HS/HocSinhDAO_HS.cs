using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.HS;
using System.Data.SqlClient;

namespace DAO
{
    public class HocSinhDAO_HS
    {
        HocSinhDataContext dbHocSinh = new HocSinhDataContext();

        public HocSinh FindOneHocSinh(string maHS, string password)
        {
            /*tìm học sinh trong bản nếu không có sẽ trả về null*/
            var checkHocSinh = 0;
            try
            {
                checkHocSinh = (from hocsinh in dbHocSinh.HocSinhs
                              where hocsinh.MaHocSinh == maHS && hocsinh.Password == password
                              select hocsinh).Count();
            }
            catch(SqlException SqlEx)
            {
                throw SqlEx;
            }
            
            if(checkHocSinh == 0)
            {
                return null;
            }
            else
            {
                HocSinh hs = new HocSinh();
                var hocSinh = from hocsinh in dbHocSinh.HocSinhs
                              where hocsinh.MaHocSinh == maHS && hocsinh.Password == password
                              select hocsinh;
                foreach(var temp in hocSinh)
                {
                    hs.MaHocSinh = temp.MaHocSinh;
                    hs.Password = temp.Password;
                    hs.NgaySinh = temp.NgaySinh;
                    hs.HoTen = temp.HoTen;
                    hs.DiaChi = temp.DiaChi;
                    hs.MaLop = temp.MaLop;
                    break;
                }

                return hs;
            }          
        }
    }
}
