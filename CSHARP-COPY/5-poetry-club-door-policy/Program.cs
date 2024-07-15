/*
Introduction
A string is the JavaScript data type to store text data.

Creating a String
You create a string by wrapping the text in single quotes or double quotes. On Exercism, single quotes are used.

'Hello, World!'
"Hello, World!"
Strings as Lists of Characters
A string can be treated as a list of characters where the first character has index 0. You can access an individual character of the string using square brackets and the index of the letter you want to retrieve.

'cat'[1];
//=> 'a'
You can determine the number of characters in a string by accessing the length property.

'cat'.length;
//=> 3
Concatenation and Methods
The simplest way to concatenate strings is to use the addition operator +.

'I like' + ' ' + 'cats.';
//=> "I like cats."
Strings provide a lot of helper methods, see MDN Docs on String Methods for a full list. The following list shows some commonly used helpers.

toUpperCase and toLowerCase -change the case of all characters
trim -remove whitespace at the beginning and end
includes, startsWith and endsWith -determine whether another string is part of the given string
slice -extract a section of the string
Strings are immutable in JavaScript. So a "modification", e.g. by some of the methods above, will always create a new string instead.

Instructions
A new poetry club has opened in town, and you're thinking of attending. Because there have been incidents in the past, the club has a very specific door policy which you'll need to master, before attempting entry.

There are two doors at the poetry club, a front and a back door, and both are guarded. To gain entry, you'll need to work out the password of the day.

The password is always based on a poem and can be derived in a two-step process.

The guard will recite the poem, one line at a time and you have to respond with an appropriate letter of that line.
The guard will now tell you all the letters you responded with at once, and you need to write them down on a piece of paper in a specific format.
The details of the process depend on which door you are trying to enter.

To determine the letters for the front door password, you need to respond with the first letter of the line of the poem, that the guard recites to you.

To end up with a nice password, the members of the poetry club like to use acrostic poems. This means that the first letter of each sentence forms a word. Here is an example by one of their favorite writers Michael Lockwood.

Stands so high
Huge hooves too
Impatiently waits for
Reins and harness
Eager to leave
So when the guard recites Stands so high, you'll respond S, when the guard recites Huge hooves too, you'll respond H.

Implement the function frontDoorResponse that takes a line of the poem as an argument and returns the first letter of that line.

frontDoorResponse('Stands so high');
//=> "S"

Stuck? Reveal Hints
Opens in a modal
Now that you have all the correct letters, all you need to do to get the password for the front door is to correctly capitalize the word.

Implement the function frontDoorPassword that accepts a string (the combined letters you found in task 1) and returns it correctly capitalized.

frontDoorPassword('SHIRE');
//=> "Shire"

frontDoorPassword('shire');
//=> "Shire"

Stuck? Reveal Hints
Opens in a modal
To determine letters for the back door password, you need to respond with the last letter of the line of the poem that the guard recites to you.

The members of the poetry club are really clever. The poem mentioned before is also telestich, which means that the last letter of each sentence also forms a word:

Stands so high
Huge hooves too
Impatiently waits for
Reins and harness
Eager to leave
When the guard recites Stands so high, you'll respond h, when the guard recites Huge hooves too, you'll respond o.

Note that sometimes the guard does stylistic pauses (in the form of whitespace) at the beginning or at the end of a line. You will need to ignore those pauses to derive the correct letter.

Implement the function backDoorResponse that takes a line of the poem as an argument and returns the last letter of that line that is not a whitespace character.

backDoorResponse('Stands so high');
//=> "h"

backDoorResponse('Stands so high   ');
//=> "h"

Stuck? Reveal Hints
Opens in a modal
To enter the poetry club via the back door, you need to be extra polite. So to derive the password, this time you need to correctly capitalize the word and add ', please' at the end.

Implement the function backDoorPassword that accepts a string (the combined letters you found in task 3) and returns the polite version of the capitalized password.

backDoorPassword('horse');
//=> "Horse, please"
*/

using System;

public class Program
{
    // Task 1
    public static char FrontDoorResponse(string line)
    {
        return char.ToUpper(line[0]);
    }

    // Task 2
    public static string FrontDoorPassword(string word)
    {
        return char.ToUpper(word[0]) + word.Substring(1).ToLower();
    }

    // Task 3
    public static char BackDoorResponse(string line)
    {
        string trimmedLine = line.Trim();
        return trimmedLine[trimmedLine.Length - 1];
    }

    // Task 4
    public static string BackDoorPassword(string word)
    {
        string capitalizedWord = char.ToUpper(word[0]) + word.Substring(1).ToLower();
        return capitalizedWord + ", please";
    }

    public static void Main(string[] args)
    {
        string line = "Stands so high";

        // Task 1
        Console.WriteLine("Front Door Response: " + FrontDoorResponse(line));

        // Task 2
        string frontDoorPassword = "SHIRE";
        Console.WriteLine("Front Door Password: " + FrontDoorPassword(frontDoorPassword));

        // Task 3
        Console.WriteLine("Back Door Response: " + BackDoorResponse(line));

        // Task 4
        string backDoorPassword = "horse";
        Console.WriteLine("Back Door Password: " + BackDoorPassword(backDoorPassword));
    }
}
