using System;
class lecture2
{
    public static void Main ()
    {
        Console.WriteLine("Enter your name ");
        string name;
        name = Console.ReadLine();
        Console.WriteLine("your name is "+name);
        Console.WriteLine("Enter Your age");
        int age;
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("your age is "+age);
        Console.WriteLine("Enter your CGPA");
        float CGPA;
        CGPA = float.Parse(Console.ReadLine());
        Console.WriteLine("your CGPA is "+CGPA);
        Console.Read();
    }
}
