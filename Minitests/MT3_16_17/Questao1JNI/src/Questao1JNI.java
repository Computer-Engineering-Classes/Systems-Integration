import java.util.Scanner;

public class Questao1JNI {
    static {
        System.loadLibrary("Questao1");
    }

    public static void main(String[] args) {
        Questao1JNI q1 = new Questao1JNI();
        try (Scanner sc = new Scanner(System.in)) {
            System.out.println("Min: ");
            int min = sc.nextInt();
            System.out.println("Max: ");
            int max = sc.nextInt();
            System.out.println("Random: " + q1.randomInt(min, max));
        }
    }

    public native int randomInt(int min, int max);
}