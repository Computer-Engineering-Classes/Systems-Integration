import java.util.Scanner;

public class ShapeAreaJNI {
    static {
        System.loadLibrary("ShapeArea");
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        while (true) {
            System.out.println("Enter the shape (rectangle, triangle, or quit):");
            String shape = sc.nextLine();
            if (shape.equals("quit")) {
                break;
            }
            System.out.println("Enter the length:");
            float length = sc.nextFloat();
            System.out.println("Enter the height:");
            float height = sc.nextFloat();
            sc.nextLine();
            ShapeAreaJNI shapeAreaJNI = new ShapeAreaJNI();
            if (shape.equals("rectangle")) {
                System.out.println("The area of the rectangle is " + shapeAreaJNI.rectangleArea(length, height));
            } else if (shape.equals("triangle")) {
                System.out.println("The area of the triangle is " + shapeAreaJNI.triangleArea(length, height));
            } else {
                System.out.println("Invalid shape.");
            }
        }
        sc.close();
    }

    private native float rectangleArea(float length, float height);

    private native float triangleArea(float base, float height);
}