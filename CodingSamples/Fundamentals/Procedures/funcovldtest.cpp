#include <cstdio>
#include <cmath>

int Compute(int count) //_Z7Computei
{
	printf("Performing basic computations...\n");
	return count * (count + 1) / 2;
}


//function overloading is defining multiple functions with same name
//but different list of parameter types
double Compute(int count, float level) //_Z7Computeif
{
	double result = 0;

	printf("Performing advanced computations...\n");
	for(int i = 1; i <= count; ++i)
	{
		result += pow(i, level);
	}

	return result;
}


int main(void)
{
	int n;
	printf("Computation Count: ");
	scanf("%d", &n);
	printf("First computation result = %d\n", Compute(n));

	float p;
	printf("Computation Level: ");
	scanf("%f", &p);
	printf("Second computation result = %lf\n", Compute(n, p));
}

