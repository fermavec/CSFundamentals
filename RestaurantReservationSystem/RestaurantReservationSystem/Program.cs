using System;

/*
1. User register validation
2. Welcome to a registered user
3. Cicle until 10 reservations are registered
 */

namespace RestaurantReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10]
            { "", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 0;
            bool userType;
            
            Console.WriteLine("Welcome to the most exclusive restaurant in the world");
            
            while (true)
            {
                if (arrayCurrentIndex == 10)
                {
                    Console.WriteLine("The restaurant is currently full, try next month");
                    Console.WriteLine("These are the reservations: ");
                    int auxIndex = 0;
                    foreach(string element in userNames)
                    {
                        Console.WriteLine("{0} name {1}", auxIndex+1, userNames[auxIndex].ToUpper());
                        auxIndex++;
                    }
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Are you a registered user write true or false if you are not");
                    userType = Convert.ToBoolean(Console.ReadLine().ToLower());

                    if (userType == true)
                    {
                        Console.WriteLine("Please enter your Username: ");
                        string userToSearch = Console.ReadLine().ToLower();
                        int index = Array.IndexOf(userNames, userToSearch);
                        if (index == -1)
                        {
                            Console.WriteLine("User not found, please try again");
                        }
                        else
                        {
                            Console.WriteLine("Welcome {0} it is a pleasure to serve you.", userNames[index].ToUpper());
                        }

                    }
                    else if (userType == false)
                    {
                        Console.WriteLine("Please write and remember your user name");
                        userNames[arrayCurrentIndex] = Console.ReadLine().ToLower();
                        Console.WriteLine("{0} has been saved succesfully", userNames[arrayCurrentIndex].ToUpper());
                        arrayCurrentIndex++;
                    }
                }
            }
        }
    }
}
