import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main9 {
    // Task 1: timeToMixJuice
    public static double timeToMixJuice(String name) {
        switch (name) {
            case "Pure Strawberry Joy":
                return 0.5;

            case "Energizer":
            case "Green Garden":
                return 1.5;

            case "Tropical Island":
                return 3.0;

            case "All or Nothing":
                return 5.0;

            default:
                return 2.5;
        }
    }

    // Task 2: limesToCut
    public static int limesToCut(int wedgesNeeded, List<String> limes) {
        int accumulator = 0;
        int wedgesLimes = 0;

        while (wedgesLimes < wedgesNeeded && accumulator < limes.size()) {
            switch (limes.get(accumulator)) {
                case "small":
                    wedgesLimes += 6;
                    System.out.println("+6 fatias");
                    break;

                case "medium":
                    wedgesLimes += 8;
                    System.out.println("+8 fatias");
                    break;

                case "large":
                    wedgesLimes += 10;
                    System.out.println("+10 fatias");
                    break;
            }
            accumulator++;
        }
        return accumulator;
    }

    // Task 3: remainingOrders
    public static List<String> remainingOrders(double timeLeft, List<String> orders) {
        List<String> juicesMissings = new ArrayList<>(orders);

        double time = 0.0;

        for (String suco : orders) {
            System.out.println(suco);
            System.out.println(time);

            if (time < timeLeft) {
                switch (suco) {
                    case "Pure Strawberry Joy":
                        time += 0.5;
                        juicesMissings.remove(0);
                        System.out.println("add 0.5");
                        break;

                    case "Energizer":
                    case "Green Garden":
                        time += 1.5;
                        juicesMissings.remove(0);
                        System.out.println("add 1.5");
                        break;

                    case "Tropical Island":
                        time += 3.0;
                        juicesMissings.remove(0);
                        System.out.println("add 3");
                        break;

                    case "All or Nothing":
                        time += 5.0;
                        juicesMissings.remove(0);
                        System.out.println("add 5");
                        break;

                    default:
                        time += 2.5;
                        juicesMissings.remove(0);
                        System.out.println("add 2.5");
                        break;
                }
            }
        }

        return juicesMissings;
    }

    public static void main(String[] args) {
        // Testando as funções individualmente
        System.out.println("Tempo para misturar 'Pure Strawberry Joy': " + timeToMixJuice("Pure Strawberry Joy"));

        int limesCut = limesToCut(25, Arrays.asList("small", "small", "large", "medium", "small"));
        System.out.println("Limas cortadas: " + limesCut);

        List<String> remaining = remainingOrders(10.0,
                Arrays.asList("Pure Strawberry Joy", "Energizer", "Tropical Island"));
        System.out.println("Pedidos restantes: " + remaining);
    }
}
