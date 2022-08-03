using System;

namespace _10Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coffeTypes;
            float[] coffeValues;

            coffeTypes = new string[] { "Expreso", "Americano", "Capuccino" };
            coffeValues = new float[] { 1.15f, 1.05f, 2.15f };

            coffeValues[1] = .50f;

            for (int i = 0; i <= coffeTypes.Length; i++)
                Console.WriteLine(coffeTypes[i] + " price: " + coffeValues[i]);
        }
    }
}
