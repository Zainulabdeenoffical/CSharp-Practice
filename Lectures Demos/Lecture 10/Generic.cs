using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10
{
    class Generic<T>
    {
        T a;
        public Generic(T a)
        {
            this.a = a;
        }

        public void Display()
        {
            Console.WriteLine(a);
        }
    }
}
