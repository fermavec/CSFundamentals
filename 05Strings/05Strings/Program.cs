using System;

namespace _05Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 175;
            int age = 35;
            string name = "Fernando";
            string info = "The requested information is:\nusername: " 
                + name + "\nAge: " + age + " años\nHeight: " 
                + height + "cms";
            Console.WriteLine(info);
        }
    }
}
