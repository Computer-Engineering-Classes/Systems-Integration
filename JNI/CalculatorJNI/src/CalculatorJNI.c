#include <jni.h>        // JNI header provided by JDK
#include <stdio.h>      // C Standard IO Header
#include "CalculatorJNI.h"   // Generated

JNIEXPORT void JNICALL Java_CalculatorJNI_add(JNIEnv *env, jobject thisObj) {
   int num1 = 0;
   int num2 = 0;
   printf("Number 1: ");
   scanf("%d", &num1);
   printf("Number 2: ");
   scanf("%d", &num2);
   int res = num1 + num2;
   printf("Result: %d", res);
}

JNIEXPORT void JNICALL Java_CalculatorJNI_subtract(JNIEnv *env, jobject thisObj) {
   int num1 = 0;
   int num2 = 0;
   printf("Number 1: ");
   scanf("%d", &num1);
   printf("Number 2: ");
   scanf("%d", &num2);
   int res = num1 - num2;
   printf("Result: %d", res);
}

JNIEXPORT void JNICALL Java_CalculatorJNI_multiply(JNIEnv *env, jobject thisObj) {
   int num1 = 0;
   int num2 = 0;
   printf("Number 1: ");
   scanf("%d", &num1);
   printf("Number 2: ");
   scanf("%d", &num2);
   int res = num1 * num2;
   printf("Result: %d", res);
}

JNIEXPORT void JNICALL Java_CalculatorJNI_divide(JNIEnv *env, jobject thisObj) {
   int num1 = 0;
   int num2 = 0;
   printf("Number 1: ");
   scanf("%d", &num1);
   printf("Number 2: ");
   scanf("%d", &num2);
   int res = num1 / num2;
   printf("Result: %d", res);
}