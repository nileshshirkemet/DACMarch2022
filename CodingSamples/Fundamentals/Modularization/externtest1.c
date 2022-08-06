#include <stdio.h>

//declaring a function defined in an external module which will be passed to the linker
extern long GCD(long, long);

int main(void)
{
	long m, n;
	printf("Two Positive Integers: ");
	scanf("%ld%ld", &m, &n);

	if(m < 0)
		m = -m;
	if(n < 0)
		n = -n;

	printf("G.C.D = %ld\n", GCD(m, n));

}

