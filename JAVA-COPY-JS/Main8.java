import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main8 {
    // Task 1
    public static int totalBirdCount(int[] birdsPerDay) {
        int totalBirds = 0;
        for (int count : birdsPerDay) {
            totalBirds += count;
        }
        return totalBirds;
    }

    // Task 2
    public static int birdsInWeek(int[] birdsPerDay, int week) {
        List<List<Integer>> matriz = new ArrayList<>();
        List<Integer> semana = new ArrayList<>();

        for (int index = 0; index < birdsPerDay.length; index++) {
            semana.add(birdsPerDay[index]);
            if (semana.size() == 7) {
                matriz.add(new ArrayList<>(semana));
                semana.clear();
            }
        }

        List<Integer> semanaEscolhida = matriz.get(week - 1);
        int somaSemanaEscolhida = semanaEscolhida.stream().mapToInt(Integer::intValue).sum();

        return somaSemanaEscolhida;
    }

    // Task 3
    public static int[] fixBirdCountLog(int[] birdsPerDay) {
        for (int index = 0; index < birdsPerDay.length; index += 2) {
            birdsPerDay[index] += 1;
        }
        return birdsPerDay;
    }

    public static void main(String[] args) {
        System.out.println(totalBirdCount(new int[] { 2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1 }));

        System.out.println(birdsInWeek(new int[] { 2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1 }, 2));

        System.out.println(Arrays.toString(fixBirdCountLog(new int[] { 2, 5, 0, 7, 4, 1 })));
    }
}
