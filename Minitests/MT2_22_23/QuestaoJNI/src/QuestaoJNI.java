public class QuestaoJNI {
    static {
        System.loadLibrary("Questao");
    }

    public native int add(int a, int b);
    public native int subtract(int a, int b);

    public static void main(String[] args) {
        QuestaoJNI jni = new QuestaoJNI();
        System.out.println("Soma: " + jni.add(10, 20));
        System.out.println("Subtração: " + jni.subtract(10, 20));
    }
}
