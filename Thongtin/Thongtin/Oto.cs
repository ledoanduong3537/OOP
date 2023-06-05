using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thongtin
{
       class Oto
    {
        public int ID { set; get; }
       public string sokhung { set; get; }   
       public string hangsx { set; get; }
        public string somay { set; get; }
       public double giaNY { set; get; }
       public string tenxe { set; get; }
       public int namsx { set; get; }
       public bool noidia { set; get; }

       public List<ThongtinThue> DSthue { set; get;}

        public Oto(int id, string sokhung) {
            this.ID = id;
            this.sokhung = sokhung;
        }
        public Oto() { }
        public void nhap()
        {
            List<Oto> danhsachoto = new List<Oto>();
            //ô tô 1

           
            Oto oto1 = new Oto(1, "ô tô 1");

            oto1.giaNY = 100;
            List<ThongtinThue> dsthue = new List<ThongtinThue>();
            ThongtinThue thue1 = new ThongtinThue() { loaithue = 1, tenthue = "thuế tiêu thụ đặc biệt", giatrixe = oto1.giaNY, mucdong = 10 };
            ThongtinThue thue2 = new ThongtinThue() { loaithue = 2, tenthue = "thuế GTGT", giatrixe = oto1.giaNY, mucdong = 10 };
            ThongtinThue thue3 = new ThongtinThue() { loaithue = 3, tenthue = "thuế nhập khẩu", giatrixe = oto1.giaNY, mucdong = 80 };

            dsthue.Add(thue1);
            dsthue.Add(thue2);
            dsthue.Add(thue3);
            oto1.DSthue = dsthue;

            danhsachoto.Add(oto1);

            //ô tô 1
            Oto oto2 = new Oto(2, "ô tô 2");
            oto2.giaNY = 100;
            oto2.DSthue = dsthue;
            danhsachoto.Add(oto2);

            //ô tô 1
            Oto oto3 = new Oto(3, "ô tô 3");
            oto3.giaNY = 100;
            oto3.DSthue = dsthue;
            danhsachoto.Add(oto3);

            //ô tô 1
            Oto oto4 = new Oto(4, "ô tô 4");
            oto4.giaNY = 300;
            oto4.DSthue = dsthue;
            danhsachoto.Add(oto4);


            //ô tô 1
            Oto oto5 = new Oto(5, "ô tô 5");
            oto5.giaNY = 200;
            oto5.DSthue = dsthue;
            danhsachoto.Add(oto5);

            foreach (var item1 in danhsachoto)
            {
                Console.WriteLine("thông tin ô tô: " + item1.ID);
                Console.WriteLine("số khung: " + item1.sokhung);
                Console.WriteLine("giá: " + item1.giaNY);

                foreach (var itemthue in item1.DSthue)
                {
                    Console.WriteLine("thuế loại: " + itemthue.loaithue);
                }
                Console.WriteLine("tiền thuế" + item1.tinhthue());

            }
            Oto thueoto = new Oto();
            thueoto.giaNY = 0;
            thueoto.DSthue = dsthue;
            foreach (var item3 in danhsachoto)
            {
                if (item3.tinhthue() > thueoto.tinhthue())
                {
                    thueoto = item3;
                }

            }
            Console.WriteLine("tổng giá trị xe : " + danhsachoto.Sum(m => m.giaNY));
            Console.WriteLine("max : " + danhsachoto.Max(m => m.tinhthue()));



        }
        
       
        public double tinhthue()
        {
            double tong = 0;
            foreach (var thue in this.DSthue)
            {
                double tienthue = giaNY * thue.mucdong / 100;
                tong += tienthue;   
            }
             return tong;
        }
    }
}
