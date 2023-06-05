using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethua
{
     class dienthoai
    {
        public int gia = 500;
        public DateTime namsx { set; get;}

        public virtual void infor()
        {
            Console.WriteLine($" giá điện thoại: {gia}");
        }
    }
}
