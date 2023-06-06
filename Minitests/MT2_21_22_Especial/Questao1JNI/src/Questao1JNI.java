public class Questao1JNI {
    static {
        System.loadLibrary("Questao1");
    }

    public static void main(String[] args) {
        Questao1JNI q1 = new Questao1JNI();
        int n = q1.randomInt(1, 100);
        System.out.println("Generated number: " + n);
        System.out.println("Is prime? " + q1.isPrime(n));
    }

    private native int randomInt(int min, int max);

    private native boolean isPrime(int n);
}
