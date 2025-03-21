using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class2:Class1
    {
      public void C2Fun()
      {
            base.C1Fun();
            Console.WriteLine("C2Fun");
      }

      public override void C1FunV()
      {
          Console.WriteLine("C1FunV");
      }

    }
}
