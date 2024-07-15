import java.util.*;

public class Main13 {
    public static void main(String[] args) {
        // Task 1
        System.out.println(cookingStatus(null));

        // Task 2
        preparationTime(Arrays.asList("sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"), 3);

        // Task 3
        quantities(Arrays.asList("sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"));

        // Task 4
        List<String> friendsList = Arrays.asList("noodles", "sauce", "mozzarella", "kampot pepper");
        List<String> myList = new ArrayList<>(Arrays.asList("noodles", "meat", "sauce", "mozzarella"));
        addSecretIngredient(friendsList, myList);

        // Task 5
        Map<String, Double> recipe = new HashMap<>();
        recipe.put("noodles", 200.0);
        recipe.put("sauce", 0.5);
        recipe.put("mozzarella", 1.0);
        recipe.put("meat", 100.0);
        scaleRecipe(recipe, 4);
    }

    // Task 1
    public static String cookingStatus(Object status) {
        if (status == null || status.equals("")) {
            System.out.println("You forgot to set the timer.");
            return "You forgot to set the timer.";
        } else if (status.equals(0)) {
            System.out.println("Lasagna is done.");
            return "Lasagna is done.";
        } else {
            System.out.println("Not done, please wait.");
            return "Not done, please wait.";
        }
    }

    // Task 2
    public static int preparationTime(List<String> layers, int average) {
        int contador = layers.size();
        System.out.println(contador * average);
        return contador * average;
    }

    // Task 3
    public static Map<String, Double> quantities(List<String> layers) {
        int contadorNoodles = 0;
        int contadorSauce = 0;
        for (String layer : layers) {
            if (layer.equals("noodles")) {
                contadorNoodles++;
            }
            if (layer.equals("sauce")) {
                contadorSauce++;
            }
        }

        Map<String, Double> result = new HashMap<>();
        result.put("noodles", contadorNoodles * 50.0);
        result.put("sauce", contadorSauce * 0.2);
        System.out.println(result);
        return result;
    }

    // Task 4
    public static void addSecretIngredient(List<String> friendsList, List<String> myList) {
        String lastIngredient = friendsList.get(friendsList.size() - 1);
        myList.add(lastIngredient);
        System.out.println(myList);
    }

    // Task 5
    public static void scaleRecipe(Map<String, Double> recipe, int portions) {
        Map<String, Double> recipeForOne = new HashMap<>();
        for (Map.Entry<String, Double> entry : recipe.entrySet()) {
            recipeForOne.put(entry.getKey(), entry.getValue() / 2);
        }
        System.out.println(recipeForOne);

        Map<String, Double> recipeCurrent = new HashMap<>();
        for (Map.Entry<String, Double> entry : recipeForOne.entrySet()) {
            recipeCurrent.put(entry.getKey(), entry.getValue() * portions);
        }
        System.out.println(recipeCurrent);
    }
}
