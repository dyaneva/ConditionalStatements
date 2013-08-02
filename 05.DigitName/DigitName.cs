// Write program that asks for a digit and depending on the input shows the name of that digit (in English) 
// using a switch statement.

using System;

class DigitName
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case 0:
                Console.WriteLine("Name of digit 0 is Zero"); break;
            case 1:
                Console.WriteLine("Name of digit 1 is One"); break;
            case 2:
                Console.WriteLine("Name of digit 2 is Two"); break;
            case 3:
                Console.WriteLine("Name of digit 3 is Three"); break;
            case 4:
                Console.WriteLine("Name of digit 4 is Four"); break;
            case 5:
                Console.WriteLine("Name of digit 5 is Five"); break;
            case 6:
                Console.WriteLine("Name of digit 6 is Six"); break;
            case 7:
                Console.WriteLine("Name of digit 7 is Seven"); break;
            case 8:
                Console.WriteLine("Name of digit 8 is Eight"); break;
            case 9:
                Console.WriteLine("Name of digit 9 is Nine"); break;
            default:
                Console.WriteLine("Invalid input!"); break;
        }
    }
}
    


