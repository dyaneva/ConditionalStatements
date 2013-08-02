/* Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement.*/

using System;

class UserChoiceType
{
    static void Main()
    {
        Console.Write("Enter a number or word: ");
        string word = Console.ReadLine();
        int numberInt, check;
        double numberDouble;
        if (int.TryParse(word, out numberInt))
        {
            check = 0;
        }
        else
        {
            check = 2;
        }
        if (double.TryParse(word, out numberDouble))
        {
            check = 1;
        }        
        switch (check)
        {
            case 0:
                numberInt++;
                Console.WriteLine(numberInt);
                break;
            case 1:
                numberDouble++;
                Console.WriteLine(numberDouble);
                break;
            case 2:
                word = word + "*";
                Console.WriteLine(word);
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
        /* Variant 2
        Console.Write("Enter a number or word: ");
        string word = Console.ReadLine();
        double number;
        if (double.TryParse(word, out number))
        {
            number++;
            Console.WriteLine(number);
        }
        else
        {
            word = word + "*";
            Console.WriteLine(word);
        }*/
    }
}

