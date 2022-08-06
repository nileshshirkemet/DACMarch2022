#include "series.h"
#include <cstdio>

double Compute(Series::Sequence& seq, int count)
{
	return seq.Sum(count) / count;
};

int main(void)
{
	int n;
	printf("Number of Terms: ");
	scanf("%d", &n);

	Series::LinearSequence a(2, 5);
	printf("Cmputation result for linear sequence = %lf\n", Compute(a, n));

	Series::PowerSequence b(3);
	printf("Cmputation result for power sequence = %lf\n", Compute(b, n));
}

