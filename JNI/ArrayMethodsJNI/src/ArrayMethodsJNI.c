#include "ArrayMethodsJNI.h"   // Generated
#include <stdlib.h>
#include <string.h>

JNIEXPORT jint JNICALL Java_ArrayMethodsJNI_max(JNIEnv *env, jobject obj, jintArray arr) {
    jint *carr;
    carr = (*env)->GetIntArrayElements(env, arr, NULL);
    jint i, max = carr[0];
    jsize len = (*env)->GetArrayLength(env, arr);
    for (i = 0; i < len; i++) {
        if (carr[i] > max) {
            max = carr[i];
        }
    }
    (*env)->ReleaseIntArrayElements(env, arr, carr, 0);
    return max;
}

JNIEXPORT jint JNICALL Java_ArrayMethodsJNI_getIndex(JNIEnv *env, jobject obj, jintArray arr, jint index) {
    jint *carr;
    carr = (*env)->GetIntArrayElements(env, arr, NULL);
    jint i = -1;
    jsize len = (*env)->GetArrayLength(env, arr);
    for (i = 0; i < len; i++) {
        if (carr[i] == index) {
            break;
        }
    }
    (*env)->ReleaseIntArrayElements(env, arr, carr, 0);
    return i;
}

// mean
JNIEXPORT jfloat JNICALL Java_ArrayMethodsJNI_mean(JNIEnv *env, jobject obj, jintArray arr) {
    jint *carr = (*env)->GetIntArrayElements(env, arr, NULL);
    jfloat sum = 0;
    jsize len = (*env)->GetArrayLength(env, arr);
    for (int i = 0; i < len; i++) {
        sum += carr[i];
    }
    (*env)->ReleaseIntArrayElements(env, arr, carr, 0);
    return sum / len;
}

// reverse string
JNIEXPORT jstring JNICALL Java_ArrayMethodsJNI_reverse(JNIEnv *env, jobject obj, jstring str) {
    const char *cstr = (*env)->GetStringUTFChars(env, str, NULL);
    size_t len = strlen(cstr);
    char *rev = malloc(len + 1);
    strcpy(rev, cstr);
    for (int i = 0; i < len / 2; i++) {
        char temp = rev[i];
        rev[i] = rev[len - i - 1];
        rev[len - i - 1] = temp;
    }
    jstring result = (*env)->NewStringUTF(env, rev);
    (*env)->ReleaseStringUTFChars(env, str, cstr);
    return result;
}