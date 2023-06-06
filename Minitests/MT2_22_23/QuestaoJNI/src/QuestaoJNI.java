import java.util.Scanner;

public class QuestaoJNI {
    static {
        System.loadLibrary("Questao");
    }

    public native int add(int a, int b);

    public native int subtract(int a, int b);

    public static void main(String[] args) {
        QuestaoJNI jni = new QuestaoJNI();
        try (Scanner scanner = new Scanner(System.in)) {
            System.out.println("Enter two numbers: ");
            int a = scanner.nextInt();
            int b = scanner.nextInt();
            System.out.println("Sum: " + jni.add(a, b));
            System.out.println("Subtraction: " + jni.subtract(a, b));
        }
    }
}
