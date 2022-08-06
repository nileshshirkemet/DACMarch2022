#include <stdio.h>

int main(void)
{
	int lower = 0, upper = 0;
	int total = 0;

	printf("Lower and Upper Limit: ");
	scanf("%d%d", &lower, &upper); //&x <=> offset x

	if(lower < upper)
	{
		total = upper * (upper + 1) / 2 - (lower - 1) * lower / 2;
		printf("Sum of Integers = %d\n", total);
	}
	else
	{
		printf("Bad input!\n");
	}
	printf("Goodbye.\n");
}


