using System;

namespace MethodPractice
{
    class MyMethods
    {
        public float square(float n1)
        {
            float result = n1 * n1;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethods myProgram = new MyMethods();

            Console.WriteLine("escribe el numero que deseas elevar al cuadrado:");
            float Number = float.Parse(Console.ReadLine());
            float resultado = myProgram.square(Number);
            Console.WriteLine("el cuadrado de " + Number + " es: " + resultado);
        }
    }
}
