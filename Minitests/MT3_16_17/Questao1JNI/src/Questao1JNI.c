#include "Questao1JNI.h"
#include <stdlib.h>
#include <string.h>
#include <time.h>

int randint(int min, int max)
{
    srand(time(NULL));
    if (min > max)
    {
        return max + (int)((min - max + 1) * rand() / (RAND_MAX + 1.0));
    }
    else
    {
        return min + (int)((max - min + 1) * rand() / (RAND_MAX + 1.0));
    }
}

JNIEXPORT jint JNICALL Java_Questao1JNI_randomInt(JNIEnv *env, jobject obj, jint min, jint max)
{
    return randint(min, max);
}