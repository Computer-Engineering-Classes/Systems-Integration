#include "Questao1JNI.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

JNIEXPORT jint JNICALL Java_Questao1JNI_randomInt(JNIEnv *env, jobject obj, jint min, jint max) {
    srand(time(NULL));
    return (rand() % (max - min + 1)) + min;
}

// isPrime
JNIEXPORT jboolean JNICALL Java_Questao1JNI_isPrime(JNIEnv *env, jobject obj, jint n) {
    if (n <= 1) return JNI_FALSE;
    if (n <= 3) return JNI_TRUE;
    if (n % 2 == 0 || n % 3 == 0) return JNI_FALSE;
    for (int i = 5; i * i <= n; i = i + 6) {
        if (n % i == 0 || n % (i + 2) == 0) return JNI_FALSE;
    }
    return JNI_TRUE;
}