import java.util.Scanner;

public class Calculator2JNI {
    static {
        System.loadLibrary("Calculator2");
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        while (true) {
            System.out.print("Number 1: ");
            int num1 = sc.nextInt();
            System.out.print("Number 2: ");
            int num2 = sc.nextInt();
            System.out.println("Menu:");
            System.out.println("1 -> Add");
            System.out.println("2 -> Subtract");
            System.out.println("3 -> Multiply");
            System.out.println("4 -> Divide");
            System.out.println("99 -> Exit");
            System.out.print("Option: ");
            int option = sc.nextInt();
            var calculator = new Calculator2JNI();
            int res;
            switch (option) {
                case 1 -> res = calculator.add(num1, num2);
                case 2 -> res = calculator.subtract(num1, num2);
                case 3 -> res = calculator.multiply(num1, num2);
                case 4 -> res = calculator.divide(num1, num2);
                case 99 -> {
                    sc.close();
                    return;
                }
                default -> {
                    System.out.println("Invalid option.");
                    continue;
                }
            }
            System.out.println("Result: " + res);
        }
    }

    private native int add(int num1, int num2);

    private native int subtract(int num1, int num2);

    private native int multiply(int num1, int num2);

    private native int divide(int num1, int num2);
}