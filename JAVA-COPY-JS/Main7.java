public class Main7 {
    public class VehicleUtils {

        // Task 1
        public static boolean needsLicense(String kind) {
            return kind.equals("car") || kind.equals("truck");
        }

        // Task 2
        public static String chooseVehicle(String option1, String option2) {
            if (option1.compareTo(option2) > 0) {
                return option2 + " is clearly the better choice.";
            } else {
                return option1 + " is clearly the better choice.";
            }
        }

        // Task 3
        public static double calculateResellPrice(double originalPrice, int age) {
            if (age > 10) {
                return 0.5 * originalPrice;
            } else if (age < 3) {
                return 0.8 * originalPrice;
            } else {
                return 0.7 * originalPrice;
            }
        }

        public static void main(String[] args) {
            System.out.println(needsLicense("car")); // true
            System.out.println(chooseVehicle("A", "b")); // A is clearly the better choice.
            System.out.println(calculateResellPrice(1000, 15)); // 500.0
        }
    }

}
