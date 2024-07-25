using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Task 1
    /*
    Elyse will summon the first card in the deck without using the array[index] or .shift(). It's just like magic.
    */
    static int GetFirstCard(List<int> deck)
    {
        var firstCard = deck.First();
        Console.WriteLine(firstCard);
        return firstCard;
    }

    // Task 2
    /*
    Elyse performs sleight of hand and summons the second card in the deck without using the array[index].
    */
    static int GetSecondCard(List<int> deck)
    {
        var secondCard = deck.Skip(1).First();
        Console.WriteLine(secondCard);
        return secondCard;
    }

    // Task 3
    /*
    Elyse will make the top two cards of the deck switch places. She doesn't need to call a single function.
    */
    static List<int> SwapTopTwoCards(List<int> deck)
    {
        var swappedDeck = new List<int>(deck);
        (swappedDeck[0], swappedDeck[1]) = (swappedDeck[1], swappedDeck[0]);
        Console.WriteLine(string.Join(", ", swappedDeck));
        return swappedDeck;
    }

    // Task 4
    /*
    Elyse will separate the deck into two piles. The first pile will contain only the top card of the original deck, while the second pile will contain all the other cards.
    */
    static (int, List<int>) DiscardTopCard(List<int> deck)
    {
        var topCard = deck.First();
        var remainingDeck = deck.Skip(1).ToList();
        Console.WriteLine($"Top card: {topCard}, Remaining deck: {string.Join(", ", remainingDeck)}");
        return (topCard, remainingDeck);
    }

    // Task 5
    /*
    Elyse will insert a set of face cards (i.e. jack, queen, and king) into her deck such that they become the second, third, and fourth cards, respectively.
    */
    static List<object> InsertFaceCards(List<int> deck)
    {
        var newDeck = new List<object> { deck[0], "jack", "queen", "king" };
        newDeck.AddRange(deck.Skip(1).Cast<object>());
        Console.WriteLine(string.Join(", ", newDeck));
        return newDeck;
    }

    static void Main(string[] args)
    {
        GetFirstCard(new List<int> { 1, 2, 3, 5, 8 });
        GetSecondCard(new List<int> { 3, 2, 10, 6, 7 });
        SwapTopTwoCards(new List<int> { 10, 7, 3, 8, 5 });
        DiscardTopCard(new List<int> { 2, 5, 4, 9, 3 });
        InsertFaceCards(new List<int> { 5, 4, 7, 10 });
    }
}
