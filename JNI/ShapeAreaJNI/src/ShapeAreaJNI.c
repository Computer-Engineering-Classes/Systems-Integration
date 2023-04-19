#include <jni.h>        // JNI header provided by JDK
#include <stdio.h>      // C Standard IO Header
#include "ShapeAreaJNI.h"   // Generated

JNIEXPORT jfloat JNICALL Java_ShapeAreaJNI_triangleArea(JNIEnv *env, jobject thisObj, jfloat base, jfloat height) {
   return (base * height) / 2;
}

JNIEXPORT jfloat JNICALL Java_ShapeAreaJNI_rectangleArea(JNIEnv *env, jobject thisObj, jfloat length, jfloat width) {
   return length * width;
}
