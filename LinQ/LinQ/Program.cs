using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Sinhvien sv1 = new Sinhvien();
            sv1.tensv = " nguyễn văn A";
            sv1.ngaysinh = new DateTime(2001,05,03);
            sv1.diemtb = 6;
            //sv1.tensv = " nguyễn văn A1";
            //sv1.tensv = " nguyễn văn A2";
            //sv1.tensv = " nguyễn văn A3";
            //sv1.tensv = " nguyễn văn A4";

            Sinhvien sv2 = new Sinhvien();
            sv2.tensv = " nguyên văn B";
            sv2.ngaysinh = new DateTime(2002,07,03);
            sv2.diemtb = 7;
            //sv1.tensv = " nguyễn văn b1";
            //sv1.tensv = " nguyễn văn b2";
            //sv1.tensv = " nguyễn văn B3";
            //sv1.tensv = " nguyễn văn B4";
            //sv1.tensv = " nguyễn văn B5";


            List<Sinhvien> listdanhsach  = new List<Sinhvien>();

            listdanhsach.Add(sv1);
            listdanhsach.Add(sv2);

            List<Sinhvien> listsinhvien = new List<Sinhvien>();
            listsinhvien.AddRange(listdanhsach);

            //foreach (Sinhvien sv in listdanhsach)
            //{
            //    Console.WriteLine("tên: "+ sv.tensv);
            //}    

            //for(int i = 0; i < listsinhvien.Count; i++)
            //{
            //    Console.WriteLine("tên: " + listsinhvien[i].tensv);

            //}
            // 1. đếm số lượng
            //int soluong = (from sv in listdanhsach select sv).Count();
            //Console.WriteLine("số lương: "+ soluong);

            //int soluong1 = listdanhsach.Count();

            //Console.WriteLine(soluong1);

            //2.đếm có điều kiện
            //int soluong2 = (from sv in listdanhsach where sv.tensv.Contains("nguyễn văn A") == true select sv).Count();
            //Console.WriteLine(soluong2);

            //int soluong3 = listdanhsach.Count(item => item.tensv.Contains("nguyễn") == true);

            // 3. lựa chọn danh sách đối tượng trong danh sách nguồn.
            //List<Sinhvien> ketqua = (from sv in listdanhsach where sv.tensv.Contains("nguyễn văn A") == true select sv).ToList();
            //Console.WriteLine(ketqua.Count);


            //4 . sắp xếp kết quả lệnh select : order by

            //List<Sinhvien> ketqua = (from sv in listdanhsach 
            //                         where sv.tensv.Contains("nguyễn văn A") == true 
            //                         orderby sv.ngaysinh descending
            //                         select sv).ToList();
            //Console.WriteLine(ketqua.Count);

            //5. lấy max min
            //DateTime maxngaysinh = listdanhsach.Max(m => m.ngaysinh);
            //Console.WriteLine("ngày sinh: "+ maxngaysinh);

            //double diemtb1 = listdanhsach.Average(item => item.diemtb);
            //Console.Write(diemtb1);

            //6 lấy first or last
            var svfirst = listdanhsach.OrderBy(m=>m.tensv).First();


            // 7. tìm kiếm theo trường khóa

            var sv = listdanhsach.Find(m => m.tensv=="nguyễn văn A");

            //




        }
    }
}
