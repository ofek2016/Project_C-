using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofek1
{
    class Student
    {
        public string Name { get; set; }
        static int num = 0;
        //contrucor
        public Student()
        {
            Name = "default "+(++num);
        }
    }
}
