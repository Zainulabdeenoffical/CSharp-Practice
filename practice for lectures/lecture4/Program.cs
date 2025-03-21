using System.Runtime.Serialization.Formatters;

namespace lecture4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("arry leng" + arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            foreach (int v in arr)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("A\tB\nC\bD");

        }
    }
}
