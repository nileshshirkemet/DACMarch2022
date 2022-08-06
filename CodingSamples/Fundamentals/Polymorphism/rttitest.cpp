#include "series.h"
#include <cstdio>

//lookup for unqualified names in Series namespace (in addition to current namespace)
using namespace Series;

double Compute(Sequence* seq, int count)
{
	//using Runtime Type Indentfication (RTTI) to convert a pointer of one type to another
	RandomAccess* ra = dynamic_cast<RandomAccess*>(seq); //returns NULL(0) if instance addressed by seq is not compatible with RandomAccess
	if(ra) //if(ra != 0)
	{
		double first = ra->Seek(1);
		double last = ra->Seek(count);
		return (first + last) / 2;
	}
	return seq->Sum(count) / count;
};

int main(void)
{
	int n;
	printf("Number of Terms: ");
	scanf("%d", &n);

	LinearSequence a(2, 5);
	printf("Cmputation result for linear sequence = %lf\n", Compute(&a, n));

	PowerSequence b(3);
	printf("Cmputation result for power sequence = %lf\n", Compute(&b, n));
}

