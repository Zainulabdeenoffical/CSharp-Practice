using System;
namespace lecture3

{
    public class zain
    {
        public static void Main(string[] arg)
        {
            string z1 = "ABC";
            string z2 = "ABC";
            string z3;
            z3 = z1 + z2;
            Console.WriteLine(z3);
            if (z1.Equals(z2))
            {
                Console.WriteLine(z3);
            }
            char f;
            f = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(f);
            // best method because its handle spaces empty input etc not send execption part 

        }
    }
}