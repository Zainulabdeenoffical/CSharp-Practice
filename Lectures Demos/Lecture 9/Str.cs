using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Str
    {
        public void Fun()
        {
            string s1="My name is Adeen";
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            string s2 = s1.Substring(1, 3);
            Console.WriteLine(s2);

            Console.WriteLine(s1.Contains("is"));
            char[] arr = s1.ToCharArray();

            string[] arr1 = {"ABC","BCD","EFT"};
            string s3 = String.Join("TYU",arr1);
            Console.WriteLine(s3);

            string s4 = "  Adeen Bin Waheed   ";
            Console.WriteLine(s4.Trim());

            string s5;
            s5 = Console.ReadLine();
            Console.WriteLine(s4.Replace(" ","\b"));
        }
    }
}
