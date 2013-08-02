// Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestInteger
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine("The bigest number is {0}", firstNumber);
        }
        else 
        {
            if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine("The bigest number is {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("The bigest number is {0}", thirdNumber);                
            }
        }
    }
}

