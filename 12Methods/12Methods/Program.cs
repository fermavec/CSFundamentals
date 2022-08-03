using System;

namespace _12Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine($"{rnd.Next(1, 56)} es tu primer número de la suerte");
            Console.WriteLine($"{rnd.Next(1, 56)} es tu segundo número de la suerte");
            Console.WriteLine($"{rnd.Next(1, 56)} es tu tercer número de la suerte");
            Console.WriteLine($"{rnd.Next(1, 56)} es tu cuarto número de la suerte");
            Console.WriteLine($"{rnd.Next(1, 56)} es tu quinto número de la suerte");
            Console.WriteLine($"{rnd.Next(1, 56)} es tu sexto número de la suerte");

            string ClassTopic = "Métodos de strings";
            string School = "Platzi";
            Console.WriteLine("Estoy aprendiendo de " + ClassTopic + " en " + School + ".");

            string SchoolClone = School.Clone().ToString();
            Console.WriteLine(SchoolClone);

            Console.WriteLine(ClassTopic.CompareTo(School));
            Console.WriteLine(School.CompareTo(SchoolClone));

            Console.WriteLine(School.Contains("Pla"));

            Console.WriteLine(School.EndsWith("zi"));

            Console.WriteLine(School.StartsWith("Pl"));

            Console.WriteLine(School.Equals(SchoolClone));

            Console.WriteLine(School.IndexOf("a"));

            Console.WriteLine(ClassTopic.ToLower());
            Console.WriteLine(ClassTopic.ToUpper());

            Console.WriteLine(School.Insert(6, " es educación online efectiva"));

            Console.WriteLine(ClassTopic.LastIndexOf("s"));

            Console.WriteLine(ClassTopic.Remove(6));

            Console.WriteLine(ClassTopic.Replace("s", "z"));

            string[] split = ClassTopic.Split(new char[] { 's' });

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(ClassTopic.Substring(2, 10));

            School.ToCharArray();

            string TextWithSpaces = "  hola, había espacios al principio y al final ";
            Console.WriteLine(TextWithSpaces.Trim());


        }
    }
}
