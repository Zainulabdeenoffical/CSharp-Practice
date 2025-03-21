using System;
using System.Collections.Generic;

namespace lecture12
{
    struct person
    {
        public string name;
        public int age;
        public char section;
    }

    class program
    {
        public static void Main(string[] arg)
        {
            Stack<string> z = new Stack<string>();
            z.Push("Z");
            z.Push("A");
            z.Push("I");
            z.Push("N");
            Console.WriteLine(z.Count);
            int a = z.Count;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(z.Pop());
            }

            LinkedList<person> l = new LinkedList<person>();

            person z2 = new person();
            z2.name = "Zain";
            z2.age = 20;
            z2.section = 'B';

            person z3 = new person();
            z3.name = "Abdullah";
            z3.age = 16;
            z3.section = 'C';

            l.AddFirst(z2);
            l.AddFirst(z3);

            foreach (person s in l)
            {
                Console.WriteLine(s.name);
                Console.WriteLine(s.age);
                Console.WriteLine(s.section);
            }
            
        }

        public void fun()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Adeen");
            d.Add(2, "Bilal");
            d.Add(3, "Nadeem");

            Console.WriteLine("Enter Value to get its key:");
            int inn = Convert.ToInt32(Console.ReadLine());

            if (d.TryGetValue(inn, out string v))
            {
                Console.WriteLine("Your Key is: " + v);
            }
            else
            {
                Console.WriteLine("Key not found.");
            }

            foreach (KeyValuePair<int, string> p in d)
            {
                Console.WriteLine(p.Key);
                Console.WriteLine(p.Value);
            }
        }
    }
}
