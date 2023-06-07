import java.util.Scanner;

public class Questao1JNI {
    static {
        System.loadLibrary("Questao1");
    }

    public native float convertEurosToUSD(float euros);

    public static void main(String[] args) {
        Questao1JNI jni = new Questao1JNI();
        try (Scanner scanner = new Scanner(System.in)) {
            System.out.print("Digite o valor em euros: ");
            float euros = scanner.nextFloat();
            System.out.println("O valor em dólares é: " + jni.convertEurosToUSD(euros));
        }
    }
}
