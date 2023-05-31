# Array Methods in JNI

## Introduction

This document describes the JNI methods that can be used to access and manipulate arrays in the native code of a Java program. The JNI methods are grouped into the following categories:

## Methods

In more detail, the method GetArrayLength is a JNI function that takes two arguments: a pointer to the JNI environment (env), which is a reference to the JNI interface pointer passed to the native method, and a reference to the array whose length is to be determined (original).The function returns the length of the array as a jsize value, which is an integer type used in JNI to represent sizes of arrays and other collections.

```c
(*env)->GetArrayLength(env, original)
```

This JNI method retrieves a pointer to the elements of a primitive integer array in the native code of a Java program. The function returns a pointer to the first element of the integer array as a jint* value, which is a pointer to a block of memory that contains the elements of the array in consecutive order. This pointer can be used to access and modify the elements of the array directly in native code.

```c
(*env)->GetIntArrayElements(env, original, NULL);
```

This JNI method releases the pointer to the elements of a primitive integer array that was obtained by a previous call to GetIntArrayElements() or NewIntArray() in the native code of a Java program. In more detail, the method ReleaseIntArrayElements is a JNI function that takes four arguments: a pointer to the JNI environment (env), which is a reference to the JNI interface pointer passed to the native method, a reference to the integer array whose elements are to be released (original), a pointer to the block of memory containing the modified elements of the array (arr), and a flag (mode) that specifies whether the changes made to the elements of the array should be copied back to the Java array or discarded.

```c
(*env)->ReleaseIntArrayElements(env, original, arr, 0);
```

This JNI method retrieves a pointer to the characters of a Java string in the UTF-8 encoding format, which can be accessed directly in the native code of a Java program.
The function returns a pointer to the UTF-8 encoded characters of the Java string as a const char* value, which is a pointer to a block of memory that contains the characters in consecutive order. This pointer can be used to access and manipulate the characters of the string directly in native code.

```c
(*env)->GetStringUTFChars(env,original,NULL);
```

This JNI method retrieves the length of a Java string in terms of the number of UTF-8 encoded characters it contains. The function returns the length of the Java string in terms of the number of UTF-8 encoded characters it contains, as a jsize value, which is an integer type used in JNI to represent sizes of arrays and other collections.

```c
(*env)->GetStringUTFLength(env,original);
```