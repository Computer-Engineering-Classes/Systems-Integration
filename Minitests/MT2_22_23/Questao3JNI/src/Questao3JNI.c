#include "Questao3JNI.h"

JNIEXPORT jboolean JNICALL Java_Questao3JNI_isPalindrome(JNIEnv *env, jobject obj, jstring str)
{
    const char *strC = (*env)->GetStringUTFChars(env, str, 0);
    jsize len = (*env)->GetStringLength(env, str);
    jboolean result = JNI_TRUE;
    for (int i = 0, j = len - 1; i < len / 2; i++, j--)
    {
        if (strC[i] != strC[j])
        {
            result = JNI_FALSE;
            break;
        }
    }
    (*env)->ReleaseStringUTFChars(env, str, strC);
    return result;
}