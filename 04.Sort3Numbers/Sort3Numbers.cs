// Sort 3 real values in descending order using nested if statements.

using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number:  ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("In descending order the numbers are as follows: {0}, {1}, {2}",
                        firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("In descending order the numbers are as follows: {0}, {1}, {2}",
                        firstNumber, thirdNumber, secondNumber);
                }
            }
            else
            {
                Console.WriteLine("In descending order the numbers are as follows: {0}, {1}, {2}",
                        thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("In descending order the numbers are as follows: {0}, {1}, {2}",
                secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("In descending order the numbers are as follows: {0}, {1}, {2}",
                secondNumber, thirdNumber, firstNumber);
            }
        }
        else 
        {           
                Console.WriteLine("In descending order the numbers are as follows: {0}, {1}, {2}",
                thirdNumber, secondNumber, firstNumber);           
        }
    }
}    

