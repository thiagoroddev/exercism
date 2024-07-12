import java.util.ArrayList;
import java.util.List;

public class Main6 {
    // Task 1
    public static int getItem(List<Integer> cards, int position) {
        return cards.get(position);
    }

    // Task 2
    public static List<Integer> setItem(List<Integer> cards, int position, int replacementCard) {
        List<Integer> updatedCards = new ArrayList<>(cards);
        updatedCards.set(position, replacementCard);
        return updatedCards;
    }

    // Task 3
    public static List<Integer> insertItemAtTop(List<Integer> cards, int newCard) {
        List<Integer> updatedCards = new ArrayList<>(cards);
        updatedCards.add(newCard);
        return updatedCards;
    }

    // Task 4
    public static List<Integer> removeItem(List<Integer> cards, int position) {
        List<Integer> updatedCards = new ArrayList<>(cards);
        updatedCards.remove(position);
        return updatedCards;
    }

    // Task 5
    public static List<Integer> removeItemFromTop(List<Integer> cards) {
        List<Integer> updatedCards = new ArrayList<>(cards);
        updatedCards.remove(updatedCards.size() - 1);
        return updatedCards;
    }

    // Task 6
    public static List<Integer> insertItemAtBottom(List<Integer> cards, int newCard) {
        List<Integer> updatedCards = new ArrayList<>(cards);
        updatedCards.add(0, newCard);
        return updatedCards;
    }

    // Task 7
    public static List<Integer> removeItemAtBottom(List<Integer> cards) {
        List<Integer> updatedCards = new ArrayList<>(cards);
        updatedCards.remove(0);
        return updatedCards;
    }

    // Task 8
    public static boolean checkSizeOfStack(List<Integer> cards, int stackSize) {
        return cards.size() == stackSize;
    }

    public static void main(String[] args) {
        List<Integer> cards1 = List.of(1, 2, 4, 1);
        System.out.println("Get Item: " + getItem(cards1, 2));

        List<Integer> cards2 = new ArrayList<>(List.of(1, 2, 4, 1));
        System.out.println("Set Item: " + setItem(cards2, 2, 6));

        List<Integer> cards3 = new ArrayList<>(List.of(5, 9, 7, 1));
        System.out.println("Insert Item at Top: " + insertItemAtTop(cards3, 8));

        List<Integer> cards4 = new ArrayList<>(List.of(3, 2, 6, 4, 8));
        System.out.println("Remove Item: " + removeItem(cards4, 2));

        List<Integer> cards5 = new ArrayList<>(List.of(3, 2, 6, 4, 8));
        System.out.println("Remove Item from Top: " + removeItemFromTop(cards5));

        List<Integer> cards6 = new ArrayList<>(List.of(5, 9, 7, 1));
        System.out.println("Insert Item at Bottom: " + insertItemAtBottom(cards6, 8));

        List<Integer> cards7 = new ArrayList<>(List.of(8, 5, 9, 7, 1));
        System.out.println("Remove Item at Bottom: " + removeItemAtBottom(cards7));

        List<Integer> cards8 = new ArrayList<>(List.of(3, 2, 6, 4, 8));
        System.out.println("Check Size of Stack: " + checkSizeOfStack(cards8, 4));
    }
}
