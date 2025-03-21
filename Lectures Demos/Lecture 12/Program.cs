using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12
{
    struct Person
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////
            //Pop() all values from Stack,Queue
 
            /*Stack<string> s = new Stack<string>();
            s.Push("A");
            s.Push("B");
            s.Push("C");*/

            /*Console.WriteLine(s.Count());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());*/

            /*int size = s.Count();
            Console.WriteLine("Count: "+s.Count()); 
            for (int i = 1; i <=size; i++)
            {
                Console.WriteLine(s.Pop());
            }
            Console.WriteLine("Count: " + s.Count());*/

            //While Loop
            /*while(s.Count()>0)
            {
                Console.WriteLine(s.Pop());
            }*/

            //For Loop
            /*(for (; s.Count()>0 ;)
            {
                Console.WriteLine(s.Pop());
            }*/

            //////////////////////////////////////
            //LinkedList with multiple values
            /*LinkedList<Person> l = new LinkedList<Person>();
            Person p1=new Person();
            p1.name = "Badar";
            p1.age = 19;

            Person p2 = new Person();
            p2.name = "Hamza";
            p2.age = 18;

            l.AddFirst(p1);
            l.AddLast(p2);


            foreach(Person p in l)
            {
                Console.WriteLine(p.name);
                Console.WriteLine(p.age);
            }*/

            ///////////////////////////////////////
            //Dictonary
            //DD d = new DD();
            //d.fun();

            Console.ReadKey();
        }
    }
}
