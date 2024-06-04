using System;
using System.Collections.Generic;
using System.Linq;

public class NumberGames
{
    // Task 1: Calculate the sum of two numbers represented by arrays of digits
    public static int TwoSum(int[] array1, int[] array2)
    {
        int number1 = int.Parse(string.Join("", array1));
        int number2 = int.Parse(string.Join("", array2));
        return number1 + number2;
    }

    // Task 2: Check if a number is a palindrome
    public static bool LuckyNumber(int number)
    {
        string numberString = number.ToString();
        return numberString.SequenceEqual(numberString.Reverse());
    }

    // Task 3: Validate user input
    public static string ErrorMessage(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "Required field";
        }
        else if (!int.TryParse(input, out int number))
        {
            return "Must be a number besides 0";
        }
        else
        {
            return "";
        }
    }

    public static void Main(string[] args)
    {
        // Teste das funções
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 0, 7 };

        Console.WriteLine("Two sum: " + TwoSum(array1, array2));

        Console.WriteLine("Lucky number: " + LuckyNumber(1441));
        Console.WriteLine("Lucky number: " + LuckyNumber(123));

        Console.WriteLine("Error message: " + ErrorMessage("123"));
        Console.WriteLine("Error message: " + ErrorMessage(""));
        Console.WriteLine("Error message: " + ErrorMessage("abc"));
    }
}
