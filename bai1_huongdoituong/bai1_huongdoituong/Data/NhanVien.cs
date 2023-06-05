using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_huongdoituong.Data
{
     class NhanVien
    {
        public string SMaNV, SEmail, SSĐT, SHoTen;
        public DateTime DTNgaySinh;
        public bool BGioitinh;
        public float FChieuCao, FCannang, FLuong;
        

        public void nhap()
        {
            Console.WriteLine("\n nhập thông tin \n");

            Console.WriteLine(" nhập mã nhân viên: ");
            SMaNV = Console.ReadLine();


            Console.WriteLine(" nhập họ tên: ");
            SHoTen = Console.ReadLine();

            Console.WriteLine("nhập ngày sinh: ");
            DTNgaySinh = (DateTime) Convert.ToDateTime( Console.ReadLine());


            Console.WriteLine("Nhập chiều cao");
            FChieuCao = (float) Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Nhập cân nặng");
            FCannang = (float)Convert.ToDouble(Console.ReadLine());
        }
        public void hienthi()
        {
            Console.WriteLine("\n hiển thị thông tin \n");
            Console.WriteLine("Mã nhân viên: " + SMaNV);
            Console.WriteLine("Họ tên: " + SHoTen);
            Console.WriteLine("Ngày sinh: " + DTNgaySinh);
            Console.WriteLine("Cân nặng: " + FCannang);
            Console.WriteLine("Chiều cao: " + FChieuCao);

        }
        

        public float BMI()
        {
            float varbmi = FCannang / (FChieuCao * FChieuCao);
            return varbmi;
        }
        public int tinhtuoi()
        {
            // lấy thời gian hiện tại
            DateTime DTngayhientai = DateTime.Now;

            int Inamhientai = DTngayhientai.Year;
            //int Ithanghientai = DTngayhientai.Month;
            //int Ingayhientai = DTngayhientai.Day;


            //// lấy ngày tháng năm
            //DateTime DTNTN = DTngayhientai.Date;


            int Inamngaysinh = this.DTNgaySinh.Year;
            return Inamhientai - Inamngaysinh;
        }   
    }

}
