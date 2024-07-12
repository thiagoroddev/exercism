public class Main4 {
    public static double dayRate(double ratePerHour) {
        return ratePerHour * 8;
    }

    public static int daysInBudget(double budget, double ratePerHour) {
        return (int) Math.floor(budget / (ratePerHour * 8));
    }

    public static int priceWithMonthlyDiscount(double ratePerHour, int numDays, double discount) {
        double monthRate = ratePerHour * 8 * 22;
        double monthlyDiscount = discount * monthRate;
        int daysRemaining = numDays % 22;

        int monthsWork = numDays / 22;
        double discountedMonthlyRate = monthRate - monthlyDiscount;
        double costDaysRemaining = daysRemaining * ratePerHour * 8;

        System.out.println(
                "\n Cost per month: " + monthRate +
                        "\n Discount per month: " + monthlyDiscount +
                        "\n Cost per month with discount: " + discountedMonthlyRate +
                        "\n Months worked: " + monthsWork +
                        "\n Days remaining: " + daysRemaining +
                        "\n Cost of the days remaining: " + costDaysRemaining);

        return (int) Math.ceil(discountedMonthlyRate * monthsWork + costDaysRemaining);
    }

    public static void main(String[] args) {
        System.out.println("Rate per day worked: " + dayRate(29.654321));

        System.out.println("Days working: " + daysInBudget(20000, 89));

        System.out.println("\nTotal cost with discount: " + priceWithMonthlyDiscount(29.654321, 220, 0.112));
    }
}
