using System;

namespace _09ReadDataEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un flotante");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine(valor1);
        }
    }
}
