#include "Questao1JNI.h"
#include <jni.h>

JNIEXPORT jdouble JNICALL Java_Questao1JNI_calculateRhythm(JNIEnv *env, jobject obj, jintArray times, jintArray distances, jint size) {
    jint *timesArray = (*env)->GetIntArrayElements(env, times, NULL);
    jint *distancesArray = (*env)->GetIntArrayElements(env, distances, NULL);
    jdouble sum = 0;
    for (jint i = 0; i < size; i++) {
        sum += (double) timesArray[i] / (double) distancesArray[i];
    }
    (*env)->ReleaseIntArrayElements(env, times, timesArray, 0);
    (*env)->ReleaseIntArrayElements(env, distances, distancesArray, 0);
    return sum / size;
}