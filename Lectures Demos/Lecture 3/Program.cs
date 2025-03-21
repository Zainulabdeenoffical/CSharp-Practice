using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 1, b = 2;
            Console.WriteLine("Values " + a + " " + b);
       
            //Second Way
            Console.WriteLine("Values {0} {1}",a,b);

            int c;
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c);

            double d;
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(d);

            char f;
            f = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(f);*/


            string s1="ABC";
            string s2="ABC";
            string s3;

            //Concatenation
            s3 = s1 + s2;

            if (s1.Equals(s2))
            {
                Console.WriteLine(s3);
            }
            Console.ReadKey();
        }
    }
}
