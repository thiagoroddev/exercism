public class Main5 {
    // Task 1
    public static String frontDoorResponse(String line) {
        char firstLetter = Character.toUpperCase(line.charAt(0));
        return String.valueOf(firstLetter);
    }

    // Task 2
    public static String frontDoorPassword(String word) {
        char firstLetter = Character.toUpperCase(word.charAt(0));
        String remainingLetters = word.substring(1).toLowerCase();
        return firstLetter + remainingLetters;
    }

    // Task 3
    public static String backDoorResponse(String line) {
        String trimmedLine = line.trim();
        char lastLetter = trimmedLine.charAt(trimmedLine.length() - 1);
        return String.valueOf(lastLetter);
    }

    // Task 4
    public static String backDoorPassword(String word) {
        char firstLetter = Character.toUpperCase(word.charAt(0));
        String remainingWord = word.substring(1);
        return firstLetter + remainingWord + ", please";
    }

    public static void main(String[] args) {
        System.out.println(frontDoorResponse("Stands so high"));
        System.out.println(frontDoorPassword("SHIRE"));
        System.out.println(backDoorResponse("Stands so high"));
        System.out.println(backDoorPassword("horse"));
    }
}
