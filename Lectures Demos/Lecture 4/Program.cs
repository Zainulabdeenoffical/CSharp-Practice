using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////
            /*while (true)
            {
                Console.WriteLine("Infinite While");
            }

            for (; ; )
            {
                Console.WriteLine("Infinite For");
            }*/

            ///////////////////////////////
            //swith cases
            /*int a=1;
            switch (a)
            { 
                case 1:
                Console.WriteLine(1);
                break;
                default:
                Console.WriteLine("None");
                break;
            }*/

            ///////////////////////////////
            //Foreach Loop
            /*int[] arr = {1,2,3,4,5};
            Console.WriteLine("Length: "+arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
                foreach (int v in arr)
                {
                    Console.WriteLine(v);
                }*/
            
            ////////////////////////////////////
            //Escape Sequence
            Console.WriteLine("A\tB\nC\bD");

            Console.ReadKey();
        }

    }
}
