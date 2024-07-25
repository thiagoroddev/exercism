import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main14 {

    // Task 1
    public static int getFirstCard(List<Integer> deck) {
        int one = deck.remove(0);
        System.out.println(one);
        return one;
    }

    // Task 2
    public static int getSecondCard(List<Integer> deck) {
        deck.remove(0); // Remove o primeiro elemento
        int two = deck.remove(0);
        System.out.println(two);
        return two;
    }

    // Task 3
    public static List<Integer> swapTopTwoCards(List<Integer> deck) {
        int one = deck.remove(0);
        int two = deck.remove(0);
        deck.add(0, two);
        deck.add(0, one);
        System.out.println(deck);
        return deck;
    }

    // Task 4
    public static List<Object> discardTopCard(List<Integer> deck) {
        int one = deck.remove(0);
        List<Object> twoPiles = new ArrayList<>();
        twoPiles.add(one);
        twoPiles.add(deck);
        System.out.println(twoPiles);
        return twoPiles;
    }

    // Task 5
    public static List<Object> insertFaceCards(List<Integer> deck) {
        int one = deck.remove(0);
        List<Object> newDeck = new ArrayList<>();
        newDeck.add(one);
        newDeck.add("jack");
        newDeck.add("queen");
        newDeck.add("king");
        newDeck.addAll(deck);
        System.out.println(newDeck);
        return newDeck;
    }

    public static void main(String[] args) {
        // Exemplos de uso
        List<Integer> deck1 = Arrays.asList(1, 2, 3, 5, 8);
        getFirstCard(deck1);

        List<Integer> deck2 = Arrays.asList(3, 2, 10, 6, 7);
        getSecondCard(deck2);

        List<Integer> deck3 = Arrays.asList(10, 7, 3, 8, 5);
        swapTopTwoCards(deck3);

        List<Integer> deck4 = Arrays.asList(2, 5, 4, 9, 3);
        discardTopCard(deck4);

        List<Integer> deck5 = Arrays.asList(5, 4, 7, 10);
        insertFaceCards(deck5);
    }
}