using System;

namespace _06SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float sideA = 12.5f;
            int sideB = 1;
            sideB++;
            sideB++;
            sideB++;
            sideB--;

            float area = sideA * sideB;
           
            Console.WriteLine("The rectangle area is: " + area);
        }
    }
}
