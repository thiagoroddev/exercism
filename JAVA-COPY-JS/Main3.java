public class Main3 {

    public static boolean canExecuteFastAttack(boolean knightIsAwake) {
        return !knightIsAwake;
    }

    public static boolean canSpy(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake) {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static boolean canSignalPrisoner(boolean archerIsAwake, boolean prisonerIsAwake) {
        return !archerIsAwake && prisonerIsAwake;
    }

    public static boolean canFreePrisoner(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake,
            boolean petDogIsPresent) {
        if (petDogIsPresent) {
            return !archerIsAwake && !knightIsAwake || !archerIsAwake && knightIsAwake;
        } else {
            return prisonerIsAwake && !archerIsAwake && !knightIsAwake;
        }
    }

    public static void main(String[] args) {
        System.out.println(canExecuteFastAttack(false)); // Exemplo de uso
        System.out.println(canSpy(false, true, false)); // Exemplo de uso
        System.out.println(canSignalPrisoner(false, true)); // Exemplo de uso
        System.out.println(canFreePrisoner(false, false, true, true)); // Exemplo de uso
    }
}
