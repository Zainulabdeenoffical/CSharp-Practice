using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12
{
    class DD
    {
        public void fun()
        {   Dictionary<int,string> d=new Dictionary<int,string>();
            d.Add(1,"Adeen");
            d.Add(2,"Bilal");
            d.Add(3, "Nadeem");

            ////////////////////////////
            /*Console.WriteLine("Enter Value to get its key:");
            int inn=Convert.ToInt32(Console.ReadLine());

            string v = d[inn];
            Console.WriteLine("Your Key is: "+v);*/

            ////////////////////////////
            /*foreach (KeyValuePair<int, string> p in d)
            {
                Console.WriteLine(p.Key);
                Console.WriteLine(p.Value);
            }*/
 
        }
    }
}
