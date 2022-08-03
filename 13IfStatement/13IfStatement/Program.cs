using System;

namespace _13IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 12);
            int userValue = 6;
            
            if (userValue == randomNumber)
            {
                Console.WriteLine("Great! you are a master");
            }
            else if (userValue == randomNumber*2)
            {
                Console.WriteLine($"You are the double");
            }
            else 
            {
                Console.WriteLine($"Come on!!!, the answer is {randomNumber}");
            }
            
        }
    }
}
