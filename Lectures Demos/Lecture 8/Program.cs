using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum Day
    {
        MONDAY,TUESDAY,WEDNESDAY
    }

    struct Person
    {
        public String name;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////////////////
            //Multiple Inheritance
           /* Interface1 i1 = new Class1();
            i1.I1Fun();

            Interface2 i2 = new Class1();
            i2.I2Fun();*/

            //////////////
            //Composition
            /*Class2 c2 = new Class2();
            c2.C2Fun();*/

            /////////////
            //Enum
            Console.WriteLine(Day.MONDAY);
            Console.WriteLine((int)Day.MONDAY);

            /////////////
            //Structure
            Person p1 = new Person();
            p1.name = "Adeen";
            p1.age = 22;
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);

            Console.ReadKey();
        }
    }
}
