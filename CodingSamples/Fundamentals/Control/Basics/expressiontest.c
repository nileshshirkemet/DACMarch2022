#include "console.h"

//a 64-bit integer type variable with upper as its identifier
long long int upper = 0;

long long int total = 0;

int main(void)
{
	upper = GetInt("Upper Limit: ");
	total = upper * (upper + 1) / 2; //expression
	PutInt("Sum of Integers = ", total);
}

