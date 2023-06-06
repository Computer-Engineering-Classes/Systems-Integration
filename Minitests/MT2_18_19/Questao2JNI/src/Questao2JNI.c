#include "Questao2JNI.h"
#include <stdlib.h>
#include <string.h>

JNIEXPORT jstring JNICALL Java_Questao2JNI_removeVowels(JNIEnv *env, jobject obj, jstring str) {
    const char *strC = (*env)->GetStringUTFChars(env, str, 0);
    const size_t len = strlen(strC);
    char *strC2 = malloc(sizeof(char) * (len + 1));
    size_t i, j = 0;
    for (i = 0; i < len; i++) {
        if (strC[i] != 'a' && strC[i] != 'e' && strC[i] != 'i' && strC[i] != 'o' && strC[i] != 'u' && strC[i] != 'A' &&
            strC[i] != 'E' && strC[i] != 'I' && strC[i] != 'O' && strC[i] != 'U') {
            strC2[j] = strC[i];
            j++;
        }
    }
    strC2[j] = '\0';
    (*env)->ReleaseStringUTFChars(env, str, strC);
    return (*env)->NewStringUTF(env, strC2);
}