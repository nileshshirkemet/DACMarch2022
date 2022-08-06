#include <stdio.h>

float PrimarySequence(int term)
{
	return 5 * term - 3;
}


float SecondarySequence(int term)
{	
	return term * term + 1;
}

/*
double PrimarySum(int count)
{
	double total = 0;
	register int i;

	for(i = 1; i <= count; ++i)
	{
		total += PrimarySequence(i);
	}

	return total;
}

double SecondarySum(int count)
{
	double total = 0;
	register int i;

	for(i = 1; i <= count; ++i)
	{	
		total += SecondarySequence(i);
	}

	return total;
}
*/


//second parameter (sequnce) is of function pointer type which
//can address any function that accepts one int type parameter and returns float
double CommonSum(int count, float (*sequence)(int))
{
	double total = 0;
	register int i;

	for(i = 1; i <= count; ++i)
	{
		total += sequence(i); //this calls the function addressed by sequence
	}

	return total;
}

int main(void)
{
	int n;
	printf("Number of Terms: ");
	scanf("%d", &n);

	//printf("Sum of primary terms = %lf\n", PrimarySum(n));
	//printf("Sum of secondary terms = %lf\n", SecondarySum(n));
	printf("Sum of primary terms = %lf\n", CommonSum(n, PrimarySequence));
	printf("Sum of secondary terms = %lf\n", CommonSum(n, SecondarySequence));
}

