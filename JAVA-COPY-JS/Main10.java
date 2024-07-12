import java.util.HashMap;
import java.util.Map;
import java.util.function.Function;

public class Main10 {

    // Tarefa 2: addPlayer
    public static Map<String, Integer> addPlayer(Map<String, Integer> scoreBoard, String player, int score) {
        scoreBoard.put(player, score);
        return scoreBoard;
    }

    public static void main(String[] args) {
        // Testando a função addPlayer
        Map<String, Integer> scoreBoard = new HashMap<>();
        addPlayer(scoreBoard, "Dave Thomas", 2);
        addPlayer(scoreBoard, "José Valim", 4);
        System.out.println(scoreBoard);

        // Testando as demais funções conforme necessário
        // Descomente e adapte conforme desejar
        // System.out.println(removePlayer(scoreBoard, "Dave Thomas"));
        // System.out.println(removePlayer(scoreBoard, "Rose Fanaras"));
        // System.out.println(updateScore(scoreBoard, "Freyja Ćirić", 73));
        // System.out.println(applyMondayBonus(scoreBoard));
        // System.out.println(normalizeScore(params));
    }

    // Tarefa 3: removePlayer
    public static Map<String, Integer> removePlayer(Map<String, Integer> scoreBoard, String player) {
        scoreBoard.remove(player);
        return scoreBoard;
    }

    // Tarefa 4: updateScore
    public static Map<String, Integer> updateScore(Map<String, Integer> scoreBoard, String player, int points) {
        if (scoreBoard.containsKey(player)) {
            scoreBoard.put(player, scoreBoard.get(player) + points);
        } else {
            scoreBoard.put(player, points);
        }
        return scoreBoard;
    }

    // Tarefa 5: applyMondayBonus
    public static Map<String, Integer> applyMondayBonus(Map<String, Integer> scoreBoard) {
        for (String player : scoreBoard.keySet()) {
            scoreBoard.put(player, scoreBoard.get(player) + 100);
        }
        return scoreBoard;
    }

    // Tarefa 6: normalizeScore
    public static int normalizeScore(int score, Function<Integer, Integer> normalizeFunction) {
        return normalizeFunction.apply(score);
    }

    // Função de normalização (exemplo)
    public static int normalize(int score) {
        return 2 * score + 10;
    }
}
