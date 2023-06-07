import java.util.Scanner;

public class Questao3JNI {
    static {
        System.loadLibrary("Questao3");
    }

    public static void main(String[] args) {
        Questao3JNI q3 = new Questao3JNI();
        try (Scanner sc = new Scanner(System.in)) {
            while (true) {
                System.out.print("Enter a string: ");
                String str = sc.nextLine();
                if (str.equals("exit")) {
                    break;
                }
                System.out.println("Is palindrome? " + q3.isPalindrome(str));
            }
        }
    }

    private native boolean isPalindrome(String str);
}