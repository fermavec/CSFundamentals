using System;

namespace _16WhileCicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //POR DEFECTO
            bool modoPatrulla = false;
            bool modoAtaque = false;
            bool modoPersecución = false;

            //CICLO DO WHILE
            do
            {
                Console.WriteLine("No hay intrusos a la vista, 1 si ves alguno, 0 si no");

                int respuesta = int.Parse(Console.ReadLine());

                if (respuesta == 1)
                {
                    Console.WriteLine("¡INTRUSOS A LA VISTA! ¡PROCEDIENDO A ATACAR!");
                    //CICLO FOR LIMITADO DE ATAQUE
                    for (int ataque = 0; ataque <= 10; ataque++)
                    {
                        modoPatrulla = false;
                        modoAtaque = true;
                        modoPersecución = true;
                        Console.WriteLine("¡DISPARO " + ataque + "!");
                        System.Threading.Thread.Sleep(100);


                    }
                    while (modoPersecución = true)
                    {
                        //CICLO FOR INFINITO DE PERSECUCIÓN
                        for (int ataque = 0; ataque <= ataque; ataque++)
                        {
                            Console.WriteLine("¡PERSIGUIENDO AL INTRUSO # " + ataque + "!");
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
                else if (respuesta == 0)
                {
                    Console.WriteLine("Muy bien, no hay intrusos");
                    modoPatrulla = true;
                    modoAtaque = false;

                }

                else
                {
                    Console.WriteLine("¿Qué? comando inválido, intenta de nuevo");
                    modoPatrulla = true;
                    modoAtaque = false;
                }


            } while (modoPatrulla);
        }
    }
}
