using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethua
{
     class android : dienthoai
    {
        public string hedieuhanh { get; set; }
        public string phienban { set; get; }

        // override :  nạp chồng phương thức infor từ class dienthoai
        public override void infor()
        {
            nhap();
        }
        public void nhap()
        {


            Console.WriteLine("nhập vào giá điện thoại android: ");
            gia = (int)Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("nhập vào năm sx: ");
            namsx = (DateTime)Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("nhập vào hệ điều hành: ");
            hedieuhanh = Console.ReadLine();
        }
    }
}
