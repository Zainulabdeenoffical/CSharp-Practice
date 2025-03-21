using System.Collections.Generic;
using System.Collections;
namespace lecture13
{
    public class program
    {
        public static void Main(string[] arg)
        {
            ArrayList a = new ArrayList();
            a.Add("Adeen");
            a.Add("Aaeen");
            a.Add("B");

            ArrayList a1 = new ArrayList();
            a1.Add("G");
            a1.Add("Y");
            a1.Add("D");
            ArrayList a2 = new ArrayList();
            a2.Add("zain");
            a2.Add("Ahmad");
            a2.Add("E");
            a.AddRange(a1);
            a.Reverse();
            a.Sort();

            foreach (var itme in a)
            {
                Console.WriteLine(itme);

            }

           
                 


      
        }
        public void l()
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(3);
            l.Add(10);

            int size = l.Count;
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