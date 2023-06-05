using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_huongdoituong.TinhDongGoi
{
     class Person
    {
        public int Id { get; }
        private string name; // không theertruy cập từ bên ngoài
        
        private int age = 20;
        public string diachi { get; set; }

        public int getage()
        {
            return this.age;
        }
        public int setage()
        {
            return this.age;
        }


       
    }
   
}
