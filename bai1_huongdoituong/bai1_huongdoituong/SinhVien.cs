using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai1_huongdoituong.ThongTin;

namespace bai1_huongdoituong
{
      class SinhVien
    {
      public  string tensinhvien;
      public  int namsinh;
      public  string email;


       public void hienthi()
        {
            Console.WriteLine("tên: " + tensinhvien + "năm sinh: " + namsinh+ "email: "+email);
        }
    }
}
