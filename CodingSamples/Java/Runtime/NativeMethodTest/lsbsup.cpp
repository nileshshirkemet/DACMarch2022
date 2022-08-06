#include "series.h"
#include "LegacySequenceBridge.h"

JNIEXPORT jdouble JNICALL Java_LegacySequenceBridge_compute(JNIEnv* env, jobject thisObj, jint count, jdouble identity, jobject ruleObj)
{
	jclass thisCls = env->GetObjectClass(thisObj);
	jfieldID idFirst = env->GetFieldID(thisCls, "first", "D");
	jdouble a = env->GetDoubleField(thisObj, idFirst);
	jfieldID idSecond = env->GetFieldID(thisCls, "second", "D");
	jdouble b = env->GetDoubleField(thisObj, idSecond);
	jfieldID idThird = env->GetFieldID(thisCls, "third", "D");
	jdouble c = env->GetDoubleField(thisObj, idThird);

	Series::CommonSequence seq;
	if(seq.Begin(a, b, c))
	{
		jclass ruleCls = env->GetObjectClass(ruleObj);
		jmethodID idCombine = env->GetMethodID(ruleCls, "combine", "(DD)D");
		jdouble result = identity;
		for(jint i = 0; i < count; ++i)
		{
			jdouble value = seq.Next();
			result = env->CallDoubleMethod(ruleObj, idCombine, result, value);
			
		}
		return result;
	}

	return 0;
}

