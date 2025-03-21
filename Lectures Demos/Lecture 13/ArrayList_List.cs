using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13
{
    class ArrayList_List
    {
        public void AL()
        {
            ArrayList a = new ArrayList();
            a.Add("Adeen");
            a.Add("Aaeen");
            a.Add("B");

            ArrayList a1 = new ArrayList();
            a1.Add("G");
            a1.Add("Y");
            a1.Add("D");

            //////////////////////////////////////////////
            //All Collections
            
            //AddRange
            a.AddRange(a1);
            
            //Reverse
            //a.Reverse();

            //Sort (Not in LinkedList)
            a.Sort();
          
            foreach (string v in a)
            {
                Console.WriteLine(v);
            }
        }

        public void L()
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(7);
            
            int size=l.Count();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(l[i]);
            }

            foreach (int v in l)
            {
                Console.WriteLine(v);
            }

        }

    }
}
