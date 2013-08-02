// Write a program that finds the greatest of given 5 variables.

using System;
using System.Linq;

class GreatestNumber
{
    static void Main()
    {
        double[] numbers = new double[5];        
        for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = double.Parse(Console.ReadLine());                
            }
        double greatestNumber = numbers.Max();
        Console.WriteLine("The biggest number is {0}", greatestNumber);
    }
}

