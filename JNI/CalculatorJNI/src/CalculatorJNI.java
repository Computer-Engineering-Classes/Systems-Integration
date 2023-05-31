import java.util.Scanner;

public class CalculatorJNI {
    static {
        System.loadLibrary("Calculator");
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Menu:");
        System.out.println("1 -> Add");
        System.out.println("2 -> Subtract");
        System.out.println("3 -> Multiply");
        System.out.println("4 -> Divide");
        System.out.print("Option: ");
        int option = sc.nextInt();
        var calculator = new CalculatorJNI();
        switch (option) {
            case 1 -> calculator.add();
            case 2 -> calculator.subtract();
            case 3 -> calculator.multiply();
            case 4 -> calculator.divide();
            default -> System.out.println("Invalid option.");
        }
        sc.close();
    }

    private native void add();

    private native void subtract();

    private native void multiply();

    private native void divide();
}
