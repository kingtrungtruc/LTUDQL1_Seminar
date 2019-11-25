using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.HT;

namespace DAO
{

    class GiaoVienDAO_HT
    {
        GiaoVienDataContext dbGiaoVien = new GiaoVienDataContext();
        
        
        public GiaoVien FindGiaoVien(string MaGV,string Password) 
        {
            /*
             * Tìm giáo viên trong cơ sở dữ liệu ? 
             * nếu có : trả về thông tin của giáo viên
             * nếu không : trả về null
             */


            GiaoVien tempGiaoVien = new GiaoVien();
            int countgiaoVien = (from giaovien in dbGiaoVien.GiaoViens
                                where giaovien.MaGiaVien == MaGV && giaovien.Password == Password
                                select giaovien).Count();
            var giaoVien = from giaovien in dbGiaoVien.GiaoViens
                           where giaovien.MaGiaVien == MaGV && giaovien.Password == Password
                           select giaovien;
            
            if (countgiaoVien == 0) // nếu giáo viên = 0 thì có nghĩ giáo viên này không tồn tại
            {
                tempGiaoVien = null;
            }
            else
            {
                foreach(var temp in giaoVien)
                {
                    tempGiaoVien.MaGiaVien = temp.MaGiaVien;
                    tempGiaoVien.Password = temp.Password;
                    tempGiaoVien.HoTen = temp.HoTen;
                    tempGiaoVien.DiaChi = temp.DiaChi;
                    tempGiaoVien.Email = temp.Email;
                    tempGiaoVien.SDT = temp.SDT;
                    tempGiaoVien.Khoi = temp.Khoi;
                    break;
                }
            }
            return tempGiaoVien;
        }

        public int AddGiaoVien(string Password,string HoTen,string DiaChi,string Email,string SDT,int MaKhoi)
        {
            /* 
             * Thêm 1 giáo viên mới vào bảng giáo viên
             * MaGV     : tự thêm 
             * Email    : không được trùng nhau -> nếu trùng  : return 1
             * SDT      : không được trùng nhau -> nếu trùng  : return 2 
             * MaKhoi   : phải tồn tại trong khối -> nếu không tồn tại : return 3
             * Thành Công: return 0
             */

            int tempReturn = -1;
            
            
            var findEmail = from giaovien in dbGiaoVien.GiaoViens
                            where giaovien.Email == Email
                            select giaovien;
            if (findEmail.Count() != 0)
            {
                return tempReturn = 1;
            }


            var findSDT = from giaovien in dbGiaoVien.GiaoViens
                          where giaovien.SDT == SDT
                          select giaovien;
            if(findSDT.Count() != 0)
            {
                return tempReturn = 2;
            }
            
            
            var findMaKhoi = from khoi in dbGiaoVien.Khois
                             where khoi.MaKhoi == MaKhoi
                             select khoi;
            if(findMaKhoi.Count() == 0)
            {
                return tempReturn = 3;
            }


            // Khỏi tạo MaGV = GV+năm hiện tại + tổng số giáo viên+1
            string MaGVTop1 = (from giaovien in dbGiaoVien.GiaoViens
                               select giaovien.MaGiaVien).FirstOrDefault();
            string CountMaGV = MaGVTop1.Substring(6, 4);
            int CountMaGVint = Int32.Parse(CountMaGV) + 1;
            int Year = DateTime.Now.Year;
            CountMaGV = CountMaGV.ToString();
            int templength = CountMaGV.Length;
            string MaGV = "";
            if(templength == 1)
            {
                MaGV = "GV" + Year.ToString() + "000" + CountMaGV;
            }
            if (templength == 2)
            {
                MaGV = "GV" + Year.ToString() + "00" + CountMaGV;
            }
            if (templength == 3)
            {
                MaGV = "GV" + Year.ToString() + "0" + CountMaGV;
            }
            if (templength == 4)
            {
                MaGV = "GV" + Year.ToString() + CountMaGV;
            }


            // Insert
            GiaoVien giaoVien = new GiaoVien();
            giaoVien.MaGiaVien = MaGV;
            giaoVien.Password = Password;
            giaoVien.DiaChi = DiaChi;
            giaoVien.Email = Email;
            giaoVien.HoTen = HoTen;
            giaoVien.SDT = SDT;

            dbGiaoVien.GiaoViens.InsertOnSubmit(giaoVien);
            dbGiaoVien.SubmitChanges();

            return tempReturn = 0;
        }

        
    }
}
