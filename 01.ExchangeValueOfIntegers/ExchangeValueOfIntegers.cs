// Write an if statement that examines two integer variables and exchanges their values 
// if the first one is greater than the second one.

using System;

class ExchangeValueOfIntegers
{
    static void Main()
    {
        Console.Write("Enter the first number:  ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("The first number is greater than the second number and the new values are:\nfirst number:  {0}\nsecond number: {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("The second number is greater than the first one - incorrect condition!");
        }
    }
}    

