using System;
using System.Collections.Generic;
using System.Linq;


public class Programas
{
    public static void Main()
    {
        TwoSum(new int[] { 1, 2, 3 }, new int[] { 0, 7 });
        LuckyNumber(524425);
        ErrorMessage(null);
    }

    public static int TwoSum(int[] array1, int[] array2)
    {
        string somaUm = "";
        string somaDois = "";

        foreach (int element in array1)
        {
            somaUm += element.ToString();
        }

        foreach (int element in array2)
        {
            somaDois += element.ToString();
        }

        int somaTotal = int.Parse(somaUm) + int.Parse(somaDois);
        Console.WriteLine(somaTotal);
        return somaTotal;
    }

    // Task 2
    public static bool LuckyNumber(int value)
    {
        string valorOriginalString = value.ToString();
        char[] valorInvertidoArray = valorOriginalString.ToCharArray();
        Array.Reverse(valorInvertidoArray);
        string valorInvertido = new string(valorInvertidoArray);

        Console.WriteLine(valorInvertido);
        Console.WriteLine(valorOriginalString);

        bool isLucky = valorOriginalString == valorInvertido;
        Console.WriteLine(isLucky ? "True" : "False");
        return isLucky;
    }

    // Task 3
    public static string ErrorMessage(object input)
    {
        if (input == null || input.ToString().Trim() == "")
        {
            Console.WriteLine("Required field");
            return "Required field";
        }

        try
        {
            double parsedNumber = double.Parse(input.ToString());
            if (parsedNumber == 0)
            {
                Console.WriteLine("Must be a number besides 0");
                return "Must be a number besides 0";
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Must be a number");
            return "Must be a number";
        }

        Console.WriteLine("Empty");
        return "";
    }
}
