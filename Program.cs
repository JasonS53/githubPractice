using System;

namespace bootcampday1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageF = int.Parse(age);
            Console.WriteLine("What is your favourite colour?");
            string colour = Console.ReadLine();

            Console.WriteLine(name + " your age is "+ ageF + " and your favourite colour is "  + colour + ".");

        }
    }
}
