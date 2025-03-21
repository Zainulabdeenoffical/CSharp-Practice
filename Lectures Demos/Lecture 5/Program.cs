using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////
            //Math Functions
            //Console.WriteLine(Math.PI);

            /////////////////
            //Random
            /*Random r = new Random();
            Console.WriteLine(r.Next(1, 11));*/

            /////////////////
            //Exception

            ///////////////
            //Case 1
            /*try
            {
                int a = 5, b = 0, c;
                c = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: "+e.Message);
            }*/

            //////////////////
            //Case 2
            /*try
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/

            //////////////////
            //Case 3
            /*int age = 17;
            if (age < 18)
            {
                throw new Exception("Sorry, You age is less than 18");
            }
            else
            {
                Console.WriteLine("Yes your Vote is elligible");
            }*/

            //////////////////
            //Finally
            /*try
            {

                Console.WriteLine("try");
            }
            catch (Exception e)
            {
                Console.WriteLine("catch");
            }
            finally
            {
                Console.WriteLine("Finally");
            }*/

            ////////////////////////
            //More than one Catch blocks
            /*try
            {

            }
            catch (NullReferenceException e)
            {
     
            }
            catch (IndexOutOfRangeException e)
            {

            }
            catch (Exception e)
            {

            }*/

            ///////////////
            //Infinite Loop
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

            Console.ReadKey();
         }
    }
}
