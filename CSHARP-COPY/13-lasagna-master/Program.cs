using System;
using System.Collections.Generic;
using System.Linq;

class Programa
{
    static void Main()
    {
        // Task 1
        Console.WriteLine(CookingStatus(""));

        // Task 2
        PreparationTime(new List<string> { "sauce", "noodles", "sauce", "meat", "mozzarella", "noodles" }, 3);

        // Task 3
        Quantities(new List<string> { "sauce", "noodles", "sauce", "meat", "mozzarella", "noodles" });

        // Task 4
        var friendsList = new List<string> { "noodles", "sauce", "mozzarella", "kampot pepper" };
        var myList = new List<string> { "noodles", "meat", "sauce", "mozzarella" };
        AddSecretIngredient(friendsList, myList);

        // Task 5
        var recipe = new Dictionary<string, double>
        {
            { "noodles", 200 },
            { "sauce", 0.5 },
            { "mozzarella", 1 },
            { "meat", 100 }
        };
        ScaleRecipe(recipe, 4);
    }

    // Task 1
    static string CookingStatus(object status)
    {
        if (status == null || status.ToString() == "")
        {
            Console.WriteLine("You forgot to set the timer.");
            return "You forgot to set the timer.";
        }
        else if (status.Equals(0))
        {
            Console.WriteLine("Lasagna is done.");
            return "Lasagna is done.";
        }
        else
        {
            Console.WriteLine("Not done, please wait.");
            return "Not done, please wait.";
        }
    }

    // Task 2
    static int PreparationTime(List<string> layers, int average = 2)
    {
        int contador = layers.Count;
        Console.WriteLine(contador * average);
        return contador * average;
    }

    // Task 3
    static Dictionary<string, double> Quantities(List<string> layers)
    {
        int contadorNoodles = 0;
        int contadorSauce = 0;
        foreach (var layer in layers)
        {
            if (layer == "noodles") contadorNoodles++;
            if (layer == "sauce") contadorSauce++;
        }

        var result = new Dictionary<string, double>
        {
            { "noodles", contadorNoodles * 50 },
            { "sauce", contadorSauce * 0.2 }
        };
        Console.WriteLine($"{{ noodles: {result["noodles"]}, sauce: {result["sauce"]} }}");
        return result;
    }

    // Task 4
    static void AddSecretIngredient(List<string> friendsList, List<string> myList)
    {
        var lastIngredient = friendsList.Last();
        myList.Add(lastIngredient);
        Console.WriteLine(string.Join(", ", myList));
    }

    // Task 5
    static void ScaleRecipe(Dictionary<string, double> recipe, int portions)
    {
        var recipeForOne = recipe.ToDictionary(entry => entry.Key, entry => entry.Value / 2);
        Console.WriteLine(string.Join(", ", recipeForOne.Select(entry => $"{entry.Key}: {entry.Value}")));

        var recipeCurrent = recipeForOne.ToDictionary(entry => entry.Key, entry => entry.Value * portions);
        Console.WriteLine(string.Join(", ", recipeCurrent.Select(entry => $"{entry.Key}: {entry.Value}")));
    }
}
