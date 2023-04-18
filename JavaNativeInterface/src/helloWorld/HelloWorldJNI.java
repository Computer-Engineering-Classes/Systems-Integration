package helloWorld;

public class HelloWorldJNI {
    static {
        System.loadLibrary("HelloWorld");
    }

    public static void main(String[] args) {
        new HelloWorldJNI().sayHello();  // Create an instance and invoke the native method
    }

    private native void sayHello();
}