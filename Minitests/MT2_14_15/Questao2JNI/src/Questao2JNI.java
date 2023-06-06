import java.util.Scanner;

public class Questao2JNI {
    static {
        System.loadLibrary("Questao2");
    }

    public static void main(String[] args) {
        Questao2JNI jni = new Questao2JNI();
        System.out.print("Price without VAT: ");
        try (Scanner scanner = new Scanner(System.in)) {
            double price = scanner.nextDouble();
            System.out.println("Price with VAT: " + jni.addVAT(price));
        }
    }
    
    private native double addVAT(double price);
}