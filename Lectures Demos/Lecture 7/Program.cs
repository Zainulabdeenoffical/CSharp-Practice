using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////
            //Inheritance
            /*Class2 c2 = new Class2();
            c2.C1Fun();*/

            ////////////////////////
            //c2.C2Fun();
            //Console.ReadKey();

            //////////////////////
            //Ploymorphism  
            Class1 c1 = new Class1();
            c1.C1FunV();
            c1 = new Class2();
            c1.C1FunV();

            Console.ReadKey();
        }
    }
}
