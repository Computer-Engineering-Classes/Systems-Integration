import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ArrayMethodsJNI {
    static {
        System.loadLibrary("ArrayMethods");
    }

    private static void arrayMethods(ArrayMethodsJNI arrayMethodsJNI) {
        List<Integer> list = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.print("Enter a number (-1 to stop): ");
            int number = scanner.nextInt();
            if (number == -1) {
                break;
            }
            list.add(number);
        }
        scanner.close();
        int[] array = list.stream().mapToInt(i -> i).toArray();
        int max = arrayMethodsJNI.max(array);
        System.out.println("Max: " + max);
        int index = arrayMethodsJNI.getIndex(array, max);
        System.out.println("Index: " + index);
        float mean = arrayMethodsJNI.mean(array);
        System.out.println("Mean: " + mean);
    }

    public static void main(String[] args) {
        ArrayMethodsJNI arrayMethodsJNI = new ArrayMethodsJNI();
        // arrayMethods(arrayMethodsJNI);
        String string = "Hello, World!";
        System.out.println("Original: " + string);
        String reversed = arrayMethodsJNI.reverse(string);
        System.out.println("Reversed: " + reversed);
    }

    private native int max(int[] array);

    private native int getIndex(int[] array, int value);

    private native float mean(int[] array);

    private native String reverse(String string);
}