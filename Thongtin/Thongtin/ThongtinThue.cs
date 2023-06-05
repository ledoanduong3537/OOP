using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thongtin
{
      class ThongtinThue
    {
      public  int loaithue { set; get; }
       public string tenthue { set; get; }
       public double mucdong { set; get; }
       public double giatrixe { set; get; }

        public double giatrithue()
        {
            return giatrixe * mucdong;
        }
    }
}
