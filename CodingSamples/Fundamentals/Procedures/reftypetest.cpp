#include <cstdio>

double Average(double first, double second, double& deviation)
{
	//automatic indirection to data addressed by deviation
	deviation = first > second ? (first - second) / 2 : (second - first) / 2;
	return (first + second) / 2;
}

int main(void)
{
	double a, b, c, d;

	printf("Two Real Values: ");
	scanf("%lf%lf", &b, &c);

	//d = 1.23;
	a = Average(b, c, d); //automatic addressing of data identified by d
	printf("Average is %lf with a deviation of %lf\n", a, d);
}

