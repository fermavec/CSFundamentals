using System;
using System.Collections.Generic;

namespace _11Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tacoShoppingList = new List<string>();

            tacoShoppingList.Add("4 tacos de suadero");
            tacoShoppingList.Add("3 tacos de bistec");
            tacoShoppingList.Add("5 tacos de pastos");
            tacoShoppingList.Add("2 coca-cola light");

            for (int i=0; i<tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }

            tacoShoppingList.Remove("4 tacos de suadero");
            tacoShoppingList.RemoveAt(0);

            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine("Nueva Lista" + tacoShoppingList[i]);
            }
        }
    }
}
