import java.util.Arrays;

public class Main12 {

    public static void main(String[] args) {
        twoSum(new int[] { 1, 2, 3 }, new int[] { 0, 7 });
        luckyNumber(524425);
        errorMessage(null);
    }

    public static int twoSum(int[] array1, int[] array2) {
        StringBuilder somaUm = new StringBuilder();
        StringBuilder somaDois = new StringBuilder();

        for (int element : array1) {
            somaUm.append(element);
        }

        for (int element : array2) {
            somaDois.append(element);
        }

        int somaTotal = Integer.parseInt(somaUm.toString()) + Integer.parseInt(somaDois.toString());
        System.out.println(somaTotal);
        return somaTotal;
    }

    // Task 2
    public static boolean luckyNumber(int value) {
        String valorOriginalString = Integer.toString(value);
        String valorInvertido = new StringBuilder(valorOriginalString).reverse().toString();

        System.out.println(valorInvertido);
        System.out.println(valorOriginalString);

        boolean isLucky = valorOriginalString.equals(valorInvertido);
        System.out.println(isLucky ? "True" : "False");
        return isLucky;
    }

    // Task 3
    public static String errorMessage(Object input) {
        if (input == null || input.toString().trim().isEmpty()) {
            System.out.println("Required field");
            return "Required field";
        }

        try {
            double parsedNumber = Double.parseDouble(input.toString());
            if (parsedNumber == 0) {
                System.out.println("Must be a number besides 0");
                return "Must be a number besides 0";
            }
        } catch (NumberFormatException e) {
            System.out.println("Must be a number");
            return "Must be a number";
        }

        System.out.println("Empty");
        return "";
    }
}
