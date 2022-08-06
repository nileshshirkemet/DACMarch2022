#include <stdio.h>

int main(void)
{
	long lower, upper;
	register long i, total = 0;

	printf("Lower and Upper Limits: ");
	scanf("%ld%ld", &lower, &upper);

	/*
	i = lower;
	while(i <= upper)
	{
		total += i * i;
		i += 1;
	}
	*/

	for(i = lower; i <= upper; ++i)
	{
		total += i * i;
	}

	printf("Sum of Squares = %ld\n", total);
}

