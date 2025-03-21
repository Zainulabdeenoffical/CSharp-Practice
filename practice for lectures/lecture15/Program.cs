using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture15
{
    class Program
    {
        //Delegate
        public delegate void Mydel();
        public delegate int Mydel2(int a);

        public void Fun1()
        {
            Console.WriteLine("Fun1");
        }
        public int Fun2(int a)
        {
            return a;
        }

        //Thread1 Method
        public static void FunT1()
        {
            Console.WriteLine("FunT1");
        }

        public static void FunT2()
        {
            Console.WriteLine("FunT2");
        }
        static void Main(string[] args)
        {
            ///////////////////////////////
            //Accepting All Upper or Lowe Letters
            string s;
            s = Console.ReadLine();
            s = s.ToLower();

            if (s == "adeen")
            {
                Console.WriteLine(s);
            }

            //////////////////////////////
            //Delegates
            Program p = new Program();
            Mydel md1 = new Mydel(p.Fun1);
            md1();

            Mydel2 md2 = new Mydel2(p.Fun2);
            Console.WriteLine(md2(6));

            /////////////////////////////
            //Threading
            //Main Thread
            Thread th = Thread.CurrentThread;
            th.Name = "Main Thread";
            Console.WriteLine(th.Name);

            //Thread Properties
            Console.WriteLine(th.IsAlive);
            Console.WriteLine(th.CurrentCulture);
            Console.WriteLine(th.IsThreadPoolThread);
            Console.WriteLine(th.ManagedThreadId);
            Console.WriteLine(th.ThreadState);
            Thread t1 = new Thread(FunT1);
            t1.Start();

            Thread t2 = new Thread(FunT2);
            t2.Start();

            Console.ReadKey();
        }
    }
}
