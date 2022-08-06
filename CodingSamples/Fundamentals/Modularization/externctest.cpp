#include <cstdio>

//declaring function defined in external module implemented in C (no name-mangling)
extern "C" int CountPrimes(long, long);

int main(void)
{
	long lower, upper;
	printf("Lower and Upper Limit: ");
	scanf("%ld%ld", &lower, &upper);

	printf("Number of Primes = %d\n", CountPrimes(lower, upper));
}

