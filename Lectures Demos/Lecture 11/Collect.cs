using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11
{
    class Collect
    {
    
        public void LL()
        {
            LinkedList<string> l = new LinkedList<string>();
            l.AddFirst("Hamza");
            l.AddFirst("Badar");
            l.AddLast("Ali");

            LinkedListNode<string> n = l.Find("Badar");
            l.AddAfter(n,"Adeen");

            /////////////////////////
            l.AddBefore(l.Find("Ali"), "Gani");
            
            foreach (string v in l)
            {
                Console.WriteLine(v);
            }

        }

        public void S()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);

            s.Pop();
            //Peak
            Console.WriteLine("Peek: "+s.Peek());

            //Iterate
            foreach(int v in s)
            {
                Console.WriteLine(v);
            }

            //Pop
            Console.WriteLine("No Values in Stack: "+s.Count());
            for (int i = -1; i <= s.Count(); i++)
            {
                Console.WriteLine(s.Pop());
            }
            Console.WriteLine("No Values in Stack: " + s.Count());            
        }

        public void Q()
        {
            //Object Data Type
            Queue<Object> q=new Queue<Object>();
            q.Enqueue("ABC");
            q.Enqueue(1);
            q.Enqueue(6.7);
            q.Enqueue('r');

            //Peak
            Console.WriteLine("Peak: "+q.Peek());

            //////////////////////////////
            //Iterate
            /*foreach(Object v in q)
            {
                Console.WriteLine(v);
            }*/

            //Pop
            Console.WriteLine("No Values in Queue: " + q.Count());
            for (int i = -2; i <= q.Count(); i++)
            {
                Console.WriteLine(q.Dequeue()+"     Size: "+q.Count());
            }
            Console.WriteLine("No Values in Queue: " + q.Count());            

        }
    }
}
