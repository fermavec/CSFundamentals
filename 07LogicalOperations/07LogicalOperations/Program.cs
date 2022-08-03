using System;

namespace _07LogicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value1 = true;
            bool value2 = false;

            bool result = value1 && value2;
            Console.WriteLine("The result of value1 && value 2 is: " + result);

            bool result2 = value1 || value2;
            Console.WriteLine("The result of value1 || value2 is " + result2);

            bool result3 = value1 != value2;
            Console.WriteLine("The result of value1 ! value2 is " + result3);



        }
    }
}
