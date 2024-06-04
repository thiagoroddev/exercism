/* 

Introduction
The for loop is one of the most commonly used statements to repeatedly execute some logic. In JavaScript, it consists of the for keyword, a header wrapped in round brackets and a code block that contains the body of the loop wrapped in curly brackets.

for (initialization; condition; step) {
  // code that is executed repeatedly as long as the condition is true
}
The initialization usually sets up a counter variable, the condition checks whether the loop should be continued or stopped and the step increments the counter at the end of each repetition. The individual parts of the header are separated by semicolons.

const list = ['a', 'b', 'c'];
for (let i = 0; i < list.length; i++) {
  // code that should be executed for each item list[i]
}
Defining the step is often done using JavaScript's increment or decrement operator as shown in the example above. These operators modify a variable in place. ++ adds one to a number, -- subtracts one from a number.

let i = 3;
i++;
// i is now 4

let j = 0;
j--;
// j is now -1
Instructions
You are an avid bird watcher that keeps track of how many birds have visited your garden. Usually, you use a tally in a notebook to count the birds but you want to better work with your data. You already digitalized the bird counts per day for the past weeks that you kept in the notebook.

Now you want to determine the total number of birds that you counted, calculate the bird count for a specific week and correct a counting mistake.

Note
To practice, use a for loop to solve each of the tasks below.

1. Determine the total number of birds that you counted so far
Let us start analyzing the data by getting a high-level view. Find out how many birds you counted in total since you started your logs.

Implement a function totalBirdCount that accepts an array that contains the bird count per day. It should return the total number of birds that you counted.

birdsPerDay = [2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1];
totalBirdCount(birdsPerDay);
// => 34
2. Calculate the number of visiting birds in a specific week
Now that you got a general feel for your bird count numbers, you want to make a more fine-grained analysis.

Implement a function birdsInWeek that accepts an array of bird counts per day and a week number. It returns the total number of birds that you counted in that specific week. You can assume weeks are always tracked completely.

birdsPerDay = [2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1];
birdsInWeek(birdsPerDay, 2);
// => 12
3. Fix a counting mistake
You realized that all the time you were trying to keep track of the birds, there was one hiding in a far corner of the garden. You figured out that this bird always spent every second day in your garden. You do not know exactly where it was in between those days but definitely not in your garden. Your bird watcher intuition also tells you that the bird was in your garden on the first day that you tracked in your list.

Given this new information, write a function fixBirdCountLog that takes an array of birds counted per day as an argument. It should correct the counting mistake and return the modified array.

birdsPerDay = [2, 5, 0, 7, 4, 1];
fixBirdCountLog(birdsPerDay);
// => [3, 5, 1, 7, 5, 1]
*/ 

using System;

public class Program
{
    // Task 1
    public static int TotalBirdCount(int[] birdsPerDay)
    {
        int totalBirds = 0;
        foreach (int count in birdsPerDay)
        {
            totalBirds += count;
        }
        return totalBirds;
    }

    // Task 2
    public static int BirdsInWeek(int[] birdsPerDay, int week)
    {
        int[][] weeks = new int[birdsPerDay.Length / 7][];
        int[] currentWeek = new int[7];
        int currentWeekIndex = 0;
        
        foreach (int count in birdsPerDay)
        {
            currentWeek[currentWeekIndex++] = count;
            if (currentWeekIndex == 7)
            {
                weeks[--week] = currentWeek;
                currentWeek = new int[7];
                currentWeekIndex = 0;
            }
        }
        
        int sum = 0;
        foreach (int count in weeks[week])
        {
            sum += count;
        }
        return sum;
    }

    // Task 3
    public static int[] FixBirdCountLog(int[] birdsPerDay)
    {
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (i % 2 == 0)
            {
                birdsPerDay[i]++;
            }
        }
        return birdsPerDay;
    }

    public static void Main(string[] args)
    {
        // Task 1
        int[] birdsPerDay = {2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1};
        Console.WriteLine("Total Bird Count: " + TotalBirdCount(birdsPerDay));

        // Task 2
        Console.WriteLine("Birds in Week 2: " + BirdsInWeek(birdsPerDay, 2));

        // Task 3
        int[] correctedCounts = FixBirdCountLog(birdsPerDay);
        Console.Write("Corrected Bird Counts: ");
        foreach (int count in correctedCounts)
        {
            Console.Write(count + " ");
        }
    }
}
