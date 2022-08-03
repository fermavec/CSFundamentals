using System;

namespace _15ForCicle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 0; i < 10 && j > -10; i++, j--)
            {
                Console.WriteLine("i: " + i + " j: " + j);
            }
        }
    }
}
