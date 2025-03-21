using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        String name;
        int age;
        public Class1(String name,int age)
        {
            this.name = name;
            this.age=age;

            Console.WriteLine("My name is {0}. My age is {1}.",name,age);
            S.id = 4;
            Console.WriteLine("Static Variable: "+S.id);
        }
    }
}
