#include "Questao1JNI.h"

JNIEXPORT jdouble JNICALL Java_Questao1JNI_finalGrade(JNIEnv *env, jobject obj, jdouble f1, jdouble f2, jdouble qa) {
    return 0.4 * f1 + 0.4 * f2 + 0.2 * qa;
}