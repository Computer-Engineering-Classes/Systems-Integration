import java.util.Scanner;

public class Questao1JNI {
    static {
        System.loadLibrary("Questao1");
    }

    public static void main(String[] args) {
        Questao1JNI q1 = new Questao1JNI();
        try (Scanner sc = new Scanner(System.in)) {
            System.out.print("First test grade: ");
            double f1 = sc.nextDouble();
            System.out.print("Second test grade: ");
            double f2 = sc.nextDouble();
            System.out.print("Quizzes average: ");
            double qa = sc.nextDouble();
            System.out.println("Final grade: " + q1.finalGrade(f1, f2, qa));
        }
    }

    private native double finalGrade(double f1, double f2, double qa);
}