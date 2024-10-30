using System;

public class Program
{
public static void Main()
{
    Console.WriteLine("Input a number between 0-10.");
    NumberIdentifier();
}

public static void NumberIdentifier()
{
    string numberInput = Console.ReadLine();
    int number = int.Parse(numberInput);
    switch (number)
    {
        case 0:
            Console.WriteLine("Your number is 0.");
            break;
        case 1:
            Console.WriteLine("Your number is 1.");
            break;
        case 2: 
            Console.WriteLine("Your number is 2.");
            break;
        case 3: 
            Console.WriteLine("Your number is 3.");
            break;
        case 4:
            Console.WriteLine("Your number is 4.");
            break;
        case 5:
            Console.WriteLine("Your number is 5.");
            break;
        case 6: 
            Console.WriteLine("Your number is 6.");
            break;
        case 7:
            Console.WriteLine("Your number is 7.");
            break;
        case 8:
            Console.WriteLine("Your number is 8.");
            break;
        case 9:
            Console.WriteLine("Your number is 9.");
            break;
        case 10:
            Console.WriteLine("Your number is 10.");
            break;
        default:
            Console.WriteLine("Your number is not in range.");
            break;
    }
}
}