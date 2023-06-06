import java.util.Scanner;

public class Questao2JNI {
    static {
        System.loadLibrary("Questao2");
    }

    public static void main(String[] args) {
        Questao2JNI q2 = new Questao2JNI();
        System.out.print("String: ");
        try (Scanner sc = new Scanner(System.in)) {
            String str = sc.nextLine();
            System.out.println("String without vowels: " + q2.removeVowels(str));
        }
    }

    private native String removeVowels(String str);
}