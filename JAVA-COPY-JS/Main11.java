import java.util.HashMap;
import java.util.Map;

public class Main11 {

    // Task 1: createVisitor
    public static Map<String, Object> createVisitor(String name, int age, String ticketId) {
        Map<String, Object> visitor = new HashMap<>();
        visitor.put("name", name);
        visitor.put("age", age);
        visitor.put("ticketId", ticketId);
        return visitor;
    }

    // Task 2: revokeTicket
    public static void revokeTicket(Map<String, Object> visitor) {
        visitor.put("ticketId", null);
    }

    // Task 3: ticketStatus
    public static String ticketStatus(Map<String, String> tickets, String ticketId) {
        System.out.println("Verifying if " + ticketId + " is in the system");

        for (String key : tickets.keySet()) {
            System.out.println("Checking ticket: " + key);
            if (key.equals(ticketId)) {
                System.out.println(ticketId + " is in the system");
                if (tickets.get(key) == null) {
                    return "not sold";
                } else {
                    return "sold to " + tickets.get(key);
                }
            }
        }
        return "unknown ticket id";
    }

    // Task 4: simpleTicketStatus
    public static String simpleTicketStatus(Map<String, String> tickets, String ticketId) {
        if (tickets.containsKey(ticketId) && tickets.get(ticketId) != null) {
            return tickets.get(ticketId);
        }
        return "invalid ticket";
    }

    // Task 5: gtcVersion
    public static String gtcVersion(Map<String, Object> visitor) {
        if (visitor.containsKey("gtc")) {
            Map<String, Object> gtc = (Map<String, Object>) visitor.get("gtc");
            return (String) gtc.get("version");
        }
        return null;
    }

    public static void main(String[] args) {
        // Testando os métodos da classe Visitor
        Map<String, Object> visitor = createVisitor("Verena Nardi", 45, "H32AZ123");
        System.out.println(visitor);

        revokeTicket(visitor);
        System.out.println(visitor);

        Map<String, String> tickets = new HashMap<>();
        tickets.put("0H2AZ123", null);
        tickets.put("23LA9T41", "Verena Nardi");

        System.out.println(ticketStatus(tickets, "0H2AZ123"));
        System.out.println(ticketStatus(tickets, "23LA9T41"));

        System.out.println(simpleTicketStatus(tickets, "0H2AZ123"));

        Map<String, Object> visitorNew = createVisitor("Verena Nardi", 45, "H32AZ123");
        visitorNew.put("gtc", Map.of("signed", true, "version", "2.1"));
        System.out.println(gtcVersion(visitorNew));
    }
}
