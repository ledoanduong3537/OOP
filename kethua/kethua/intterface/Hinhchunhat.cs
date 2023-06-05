using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethua.intterface
{
    class Hinhchunhat : Hinhhoc
    {
        public float a { set; get; }
        public float b { set; get; }
        public Hinhchunhat(float c, float d)
        {
            a = c;
            b = d;
        }
        public float tinhchuvi()
        {
            return 2 * (a * b);
        }

        public float tinhdientich()
        {
            return a* b;
        }

    }
}
