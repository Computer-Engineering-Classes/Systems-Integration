#include "Questao1JNI.h" // Generated

JNIEXPORT jfloat JNICALL Java_Questao1JNI_rectangleArea(JNIEnv *env, jobject obj, jfloat width, jfloat height){
    return width * height;
}

JNIEXPORT jfloat JNICALL Java_Questao1JNI_triangleArea(JNIEnv *env, jobject obj, jfloat base, jfloat height){
    return (base * height) / 2;
}