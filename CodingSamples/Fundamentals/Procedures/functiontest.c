#include <stdio.h>

int Compute(int count)
{
	return count * (count + 1) / 2;
}

int main(void)
{
	int lower, upper, total;

	printf("Lower and Upper Limit: ");
	scanf("%d%d", &lower, &upper);

	if(upper > lower)
	{
		total = Compute(upper) - Compute(lower - 1);
		printf("Sum of Integers = %d\n", total);
	}

}

