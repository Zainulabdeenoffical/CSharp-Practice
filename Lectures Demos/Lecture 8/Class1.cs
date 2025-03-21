using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1:Interface1,Interface2
    {
        public void C1Fun()
        {
            Console.WriteLine("C1Fun");
        }

        void Interface1.I1Fun()
        {
            Console.WriteLine("I1Fun");
        }

        void Interface2.I2Fun()
        {
            Console.WriteLine("I2Fun");
        }
    }
}
