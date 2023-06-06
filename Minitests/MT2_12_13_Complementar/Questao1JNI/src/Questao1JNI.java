import java.util.Random;

public class Questao1JNI {
    static {
        System.loadLibrary("Questao1");
    }

    public static void main(String[] args) {
        Questao1JNI questao1JNI = new Questao1JNI();
        Random random = new Random();
        int size = 4;
        int[] times = new int[size];
        int[] distances = new int[size];
        for (int i = 0; i < size; i++) {
            times[i] = random.nextInt(10);
            distances[i] = random.nextInt(10);
        }
        double rhythm = questao1JNI.calculateRhythm(times, distances, size);
        System.out.println("Rhythm: " + rhythm);
    }

    private native double calculateRhythm(int[] times, int[] distances, int size);
}