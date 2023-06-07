#include "Questao1JNI.h"

JNIEXPORT jfloat JNICALL Java_Questao1JNI_convertEurosToUSD(JNIEnv *env, jobject obj, jfloat euros)
{
    return euros * 1.20;
}