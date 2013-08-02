// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
// Use a sequence of if statements.

using System;

class ShowSign
{
    static void Main()
    {
        Console.Write("Enter the first number:  ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber == 0 ^ secondNumber == 0 ^ thirdNumber == 0)
        {
            Console.WriteLine("The product of the numbers is 0");
        }
        else
        {
            if (firstNumber < 0 ^ secondNumber < 0 ^ thirdNumber < 0)
            {
                Console.WriteLine("The product of the numbers has a sign -");
            }
            else if (firstNumber > 0 ^ secondNumber > 0 ^ thirdNumber > 0)
            {
                Console.WriteLine("The product of the numbers has a sign +");
            }
        }
    }
}    

