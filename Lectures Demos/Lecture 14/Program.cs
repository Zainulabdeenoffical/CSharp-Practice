using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//////////////////////
using System.IO;

namespace Lecture_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////
            //File Handling 

            //Write data in  a file.
            using(StreamWriter s=new StreamWriter("File.txt"))
            {
                s.Write("Adeen");
                s.WriteLine("Hellow World");
                s.WriteLine("Hello");

            }

            //append data in  a file. (AppendText)
            using (StreamWriter s = File.AppendText("File.txt"))
            {
                s.Write("Adeen");
                s.WriteLine("Hellow World");
                s.WriteLine("Hello");
            }

            //append all text in a file. (AppendAllTexyt)
            File.AppendAllText("File.txt","Hamza");

            //apppend all textline in a file. (AppendAllLines)
            string[] arr = {"Adeen","Ali","Badar","Hamza"};
            File.AppendAllLines("File.doc",arr);

            Console.WriteLine("Data Saved");

            //Reading data form a FILE
            using(StreamReader s=new StreamReader("File.txt"))
            {
                string line;
                while ((line = s.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }             
            }

            //Count Lines in a file
            int c = File.ReadAllLines("File.txt").Length;
            Console.WriteLine("Total Line: "+c);
            Console.ReadKey();
        }
    }
}
