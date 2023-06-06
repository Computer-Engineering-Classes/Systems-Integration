#include "Questao2JNI.h"

JNIEXPORT jdouble JNICALL Java_Questao2JNI_addVAT(JNIEnv *env, jobject obj, jdouble price) {
    jdouble vat = 0.23;
    return price + (price * vat);
}