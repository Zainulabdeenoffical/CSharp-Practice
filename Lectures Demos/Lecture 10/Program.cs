using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10
{
    class Program
    {
        public void Fun<T>(T a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            /////////////////////////
            //Generic Class
            Generic <string>g = new Generic<string>("ABC");
            g.Display();
            Generic <int>g2 = new Generic<int>(2);
            g2.Display();

            Multi_Generic<string, int> g3 = new Multi_Generic<string, int>();
            g3.Insert("Adeen",3);
            g3.Display();

            ///////////////////////
            //Generic Method
            Program p = new Program();
            p.Fun<string>("A");


            Console.ReadKey();
        }
    }
}
