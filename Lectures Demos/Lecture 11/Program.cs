using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            //LinkedList 
            /*Collect l = new Collect();
            l.LL();*/

            /////////////////////
            //Stack
            /*Collect c = new Collect();
            c.S();*/

            ////////////////////
            //more than one variable in for loop

            /*int i,j;
            for(i=1,j=10;i<10;i++,j--)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
            }*/

            //////////////////////////
            //Queue
            Collect c = new Collect();
            c.Q();

            /////////////////////////
            //Var Datatype
            /*var a=1;
            var b = "ABC";
            Console.WriteLine(a + " " + b);*/


            Console.ReadKey();
        }
    }
}
