using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace lecture5
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random z = new Random();
            Console.WriteLine(z.Next(0, 100));
            

            try
            {
                int a = 5, b = 0, c;
                c = a / b;
                
            }
             
            catch(DivideByZeroException e )
                {
                Console.WriteLine("Error " + e.Message);
            }
            try
            {
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
                Console.WriteLine(arr[10]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            /*int age = 18;
            if (age<20)
            {
                throw new Exception("Sorry !  this is not for you");
            }
            else
            {
                Console.WriteLine("you are done! Welcome");
            }
            try
            {
                Console.WriteLine("try");
            }
            catch(Exception e)
            {
                Console.WriteLine("Catch");
            }
            finally
            {
                Console.WriteLine("Finally");
            } */
            while (true)
            {
                try
                {
                    int a;
                    Console.WriteLine("Enter an integer value:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your Entered value is " + a);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            }

        }
}
