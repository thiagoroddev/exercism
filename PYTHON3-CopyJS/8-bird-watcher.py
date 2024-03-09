"""
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



// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Calculates the total bird count.
 *
 * @param {number[]} birdsPerDay
 * @returns {number} total bird count
"""

def total_bird_count(birds_per_day):
    total_birds = 0
    for count in birds_per_day:
        total_birds += count
    return total_birds

# Example usage:
birds_per_day_list = [10, 5, 8, 12, 7]
result = total_bird_count(birds_per_day_list)
print(result)



"""/**
  * Calculates the total number of birds seen in a specific week.
  *
  * @param {number[]} birdsPerDay
  * @param {number} week
  * @returns {number} birds counted in the given week
""" 

def birds_in_week(birds_per_day, week):
    matrix = []
    week_list = []

    for count in birds_per_day:
        week_list.append(count)

        if len(week_list) == 7:
            matrix.append(week_list)
            week_list = []

    chosen_week = matrix[week - 1]
    sum_chosen_week = sum(chosen_week)

    return sum_chosen_week

# Example usage:
birds_per_day_list = [2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1]
chosen_week_number = 2
result = birds_in_week(birds_per_day_list, chosen_week_number)
print(result)
  
"""/**
  * Fixes the counting mistake by increasing the bird count
  * by one for every second day.
  *
  * @param {number[]} birdsPerDay
  * @returns {number[]} corrected bird count data
  """"

def fix_bird_count_log(birds_per_day):
    for index in range(len(birds_per_day)):
        if index % 2 == 0:
            birds_per_day[index] += 1

    return birds_per_day

# Example usage:
birds_per_day_list = [2, 5, 0, 7, 4, 1]
result = fix_bird_count_log(birds_per_day_list)
print(result)

