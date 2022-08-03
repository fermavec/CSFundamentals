using System;

namespace _03Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? Please write your fullname");
            string fullUserName = Console.ReadLine();

            Console.WriteLine("Hello " + fullUserName + ", Welcome to my program");
        }
    }
}
