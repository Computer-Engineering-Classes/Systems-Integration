public class Questao1JNI {
    static {
        System.loadLibrary("Questao1");
    }

    public static void main(String[] args) {
        var questao1JNI = new Questao1JNI();
        System.out.println("Rectangle area: " + questao1JNI.rectangleArea(10, 20));
        System.out.println("Triangle area: " + questao1JNI.triangleArea(10, 20));
    }

    private native float rectangleArea(float width, float height);

    private native float triangleArea(float base, float height);
}