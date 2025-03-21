using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13
{
    class HashT
    {
        public void Fun()
        {
            Hashtable ht = new Hashtable();
            //ht[6] = "A";
            //ht[2] = "B";
            //ht[1] = "V";

            int loc=hasFun(21);
            ht[loc] = "G";

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value);
            }
        }

        int hasFun(int key)
        {
            return key % 10;
        }
    }
}
