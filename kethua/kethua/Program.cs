using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kethua.intterface;
using kethua.loptruutuong;

namespace kethua
{
  
     class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //android ad = new android();
            // ad.infor();

            //abstract
            //phong p = new phong();
            //p.thongtin();

            // interface
            Hinhchunhat h = new Hinhchunhat(4, 5);
            Console.WriteLine($"chu vi: {h.tinhchuvi()} , diện tích: {h.tinhdientich()}");
        }
    }
}
