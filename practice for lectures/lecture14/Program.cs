using System.IO;
namespace lecture14

{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter s = new StreamWriter ("zain.txt"))
            {
                s.WriteLine("hello my name is zain");
            }
            // for not overright file again 
            using (StreamWriter s = File.AppendText("zain.txt"))
            {
                s.WriteLine("hello my name is zain");
            }
            // for Allline array save on file 
            string[] z = { "cat", "dog" };
            File.WriteAllLines("s.txt", z);

            Console.WriteLine("data saved");
            // read data from file 

            using (StreamReader r = new StreamReader ("zain.txt"))
            {
                string line;
                while((line= r.ReadLine())!=null)

                  {
                    Console.WriteLine(line);

                }

            }


            // for read all txt in file 
            string file = File.ReadAllText("C:\\Users\\ADMIN\\Documents\\.net\\C# Lectures-20240714T094013Z-001\\C# Lectures\\practice for lectures\\lecture14\\bin\\Debug\\net8.0\\zain.txt");
            Console.WriteLine(file);
            // read all line in txt and place them into a array 
            string[] m = File.ReadAllLines("zain.txt");
            foreach (string s in m)
            {
                Console.WriteLine(s);
            }

            int line_count = File.ReadAllLines("zain.txt").Length;
            Console.WriteLine(line_count);






           

        }
    }
}
