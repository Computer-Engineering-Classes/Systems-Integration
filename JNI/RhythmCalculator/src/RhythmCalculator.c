#include <jni.h>    // JNI header provided by JDK
#include "RhythmCalculator.h"   // Generated

// Implementation of the native method getRhythm(float[], float[])
JNIEXPORT jfloat JNICALL Java_RhythmCalculator_getRhythm(JNIEnv *env, jobject thisObj, jfloatArray jTimes, jfloatArray jDistances) {
    // Get the pointers to the arrays
    jfloat *times = (*env)->GetFloatArrayElements(env, jTimes, 0);
    jfloat *distances = (*env)->GetFloatArrayElements(env, jDistances, 0);
    // Get the length of the arrays
    jsize times_length = (*env)->GetArrayLength(env, jTimes);
    jsize distances_length = (*env)->GetArrayLength(env, jDistances);
    // Check if the arrays are the same length
    if (times_length != distances_length) {
        return -1;
    }
    // Calculate the rhythm
    jfloat sum = 0;
    for (int i = 0; i < times_length; i++) {
        sum += times[i] / distances[i];
    }
    // Release the arrays
    (*env)->ReleaseFloatArrayElements(env, jTimes, times, 0);
    (*env)->ReleaseFloatArrayElements(env, jDistances, distances, 0);
    // Return the average rhythm
    return sum / times_length;
}