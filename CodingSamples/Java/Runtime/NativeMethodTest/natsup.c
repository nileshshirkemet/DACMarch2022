#include "Program.h"
#include <stdlib.h>

JNIEXPORT jlong JNICALL Java_Program_gcd(JNIEnv* env, jclass cls, jlong first, jlong second)
{
	while(first != second)
	{
		if(first > second)
			first -= second;
		else
			second -= first;
	}

	return first;
}

JNIEXPORT void JNICALL Java_Program_square(JNIEnv* env, jclass cls, jdoubleArray values)
{
	jint n = (*env)->GetArrayLength(env, values);
	jdouble* items = malloc(n * sizeof(jdouble));
	register jint i;

	(*env)->GetDoubleArrayRegion(env, values, 0, n, items);
	for(i = 0; i < n; ++i)
		items[i] *= items[i];
	(*env)->SetDoubleArrayRegion(env, values, 0, n, items);
	free(items);
}

JNIEXPORT jstring JNICALL Java_Program_reverse(JNIEnv* env, jclass cls, jstring text)
{
	jint n = (*env)->GetStringLength(env, text);
	jchar* buffer = malloc(n * sizeof(jchar));
	jstring result;
	register jint i, j;

	(*env)->GetStringRegion(env, text, 0, n, buffer);
	for(i = 0, j = n -1; i < j; ++i, --j)
	{
		jchar ic = buffer[i];
		jchar jc = buffer[j];
		buffer[i] = jc;
		buffer[j] = ic;
	}
	result = (*env)->NewString(env, buffer, n);
	free(buffer);

	return result;
}

