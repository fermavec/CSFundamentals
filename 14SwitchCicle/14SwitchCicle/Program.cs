using System;

public class switchExample
{
    public static void Main()
    {
        Console.WriteLine("Enter the selected soda: ");
        string caseSwitch = Console.ReadLine();

        switch (caseSwitch)
        {
            case "1":
                Console.WriteLine("Cola soda - $2 USD");
                break;
            case "2":
                Console.WriteLine("Lime soda - $1 USD");
                break;
            case "3":
                Console.WriteLine("Orange soda - $1.5 USD");
                break;
            case "4":
                Console.WriteLine("Apple soda - $1 USD");
                break;
            default:
                Console.WriteLine("ERROR: You did not select a soda or you entered an incorrect value.");
                break;
        }
    }
}
