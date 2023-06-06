#include "QuestaoJNI.h"
#include <stdio.h>
#include <stdlib.h>

JNIEXPORT jint JNICALL Java_QuestaoJNI_add(JNIEnv *env, jobject obj, jint a, jint b){
    return a + b;
}

JNIEXPORT jint JNICALL Java_QuestaoJNI_subtract(JNIEnv *env, jobject obj, jint a, jint b){
    return a - b;
}