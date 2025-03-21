using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// //////////////
    /// Static Class
    /// </summary>
    static class S
    {
        public static int id = 1;
        public static void FunS()
        {
            Console.WriteLine("FunS");
        }
    }

    /// <summary>
    /// //Abstract Class
    /// </summary>
    /// 
    abstract class A
    {
        public abstract void FunA();
    }

    class B : A
    {
        public override void FunA()
        {
            Console.WriteLine("FunA");
        }
    }

    sealed class Se
    {
 
    }

    class Program
    {
        static void Main(string[] args)
        {
            //////////////////
            //Static Class
            //S.FunS();
           
            /////////////////
            //Constructor
            //Class1 c1 = new Class1("Adeen",18);

            ////////////
            //Abstract Class
            /*A a = new B();
            a.FunA();*/

            /////////////
            //String Fun
            Str s = new Str();
            s.Fun();


            Console.ReadKey();
        }
    }
}
