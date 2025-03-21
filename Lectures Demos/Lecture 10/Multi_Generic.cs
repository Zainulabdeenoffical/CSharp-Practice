using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10
{
    class Multi_Generic<T1,T2>
    {
        T1 a;
        T2 b;

        public void Insert(T1 a,T2 b)
        {
            this.a = a;
            this.b = b;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}
