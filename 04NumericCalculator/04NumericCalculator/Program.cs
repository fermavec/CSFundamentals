﻿using System;

namespace _04NumericCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            //Explicit Casting
            Console.WriteLine("Input the first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2;
            Console.WriteLine("The result is: " + result);

        }
    }
}
