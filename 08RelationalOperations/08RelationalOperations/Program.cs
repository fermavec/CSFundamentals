using System;

namespace _08RelationalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 15;
            int value2 = 22;
            int value3 = 35;

            var result1 = value1 == value2;
            var result2 = value1 != value2;
            var result3 = value1 >= value2;
            var result4 = value1 <= value2;
            var result5 = value1 > value2;
            var result6 = value1 < value2;

            Console.WriteLine(result1 + " " +
                result2 + " " + result3 + " " +
                result4 + " " + result5 + " " +
                result6 );
        }
    }
}
