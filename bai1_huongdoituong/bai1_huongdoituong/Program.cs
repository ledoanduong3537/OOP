using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai1_huongdoituong.Data;
using bai1_huongdoituong.TinhDongGoi;

namespace bai1_huongdoituong
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //SinhVien sv1 = new SinhVien();
            //sv1.tensinhvien = " dương";
            //sv1.namsinh = 2001;
            //sv1.email = "duong@gmail.com";
            //sv1.hienthi();



            // tính đóng gói 
            Console.WriteLine("tính đóng gói");
            Person ps = new Person();
            //ps.Id = "2"; // không thể nhập vào dữ liệu vì không có hàm set trong thuộc tính ID
            Console.Write(ps.Id); // chỉ có thể lấy ra vì có hàm get

            Console.WriteLine("tuổi " + ps.getage()); // phạm vị truy cập của age là private nên phải lấy thông qua hàm getage





            NhanVien nv1 = new NhanVien();
            nv1.nhap();
            nv1.hienthi();
            Console.WriteLine("BMI: "+ nv1.BMI().ToString());
            Console.WriteLine("tuổi: " +  nv1.tinhtuoi().ToString());
        }
    }
}
