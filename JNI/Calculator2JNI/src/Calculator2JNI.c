#include <jni.h>        // JNI header provided by JDK
#include <stdio.h>      // C Standard IO Header
#include "Calculator2JNI.h"   // Generated

JNIEXPORT jint JNICALL Java_Calculator2JNI_add(JNIEnv *env, jobject thisObj, jint num1, jint num2) {
   return num1 + num2;
}

JNIEXPORT jint JNICALL Java_Calculator2JNI_subtract(JNIEnv *env, jobject thisObj, jint num1, jint num2) {
   return num1 - num2;
}

JNIEXPORT jint JNICALL Java_Calculator2JNI_multiply(JNIEnv *env, jobject thisObj, jint num1, jint num2) {
    return num1 * num2;
}

JNIEXPORT jint JNICALL Java_Calculator2JNI_divide(JNIEnv *env, jobject thisObj, jint num1, jint num2) {
   return num1 / num2;
}