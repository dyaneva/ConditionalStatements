// Write a program that converts a number in the range [0...999] to a text corresponding 
// to its English pronunciation. 

using System;

class ConvertNumberToText
{
    public static string ConvertToText(int number)
    {
        string result;
        if (number == 0)
        {
            result = "Zero";
        }
        else
        {
            result = NumberToText(number);
        }
        return result;
    }
    private static string NumberToText(int n)
    {
        string[] onesAndTeens = new string[] {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                                              "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = new string[] {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        if (n == 0)
            return "";
        else if (n <= 19)
            return onesAndTeens[n - 1] + " ";
        else if (n <= 99)
            return tens[n / 10 - 2] + " " + NumberToText(n % 10);
        else
            return NumberToText(n / 100) + "Hundred " + NumberToText(n % 100);
    }

    static void Main()
    {
        int number;
        Console.Write("Enter a number in range [0...999]: ");
        while (int.TryParse(Console.ReadLine(), out number) && (number < 0 ^ number > 999))
        {
            Console.WriteLine("Invalid input! Enter again: ");
        }
        Console.WriteLine(ConvertToText(number));
    }
}

