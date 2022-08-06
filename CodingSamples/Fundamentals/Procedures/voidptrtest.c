#include <stdio.h>

/*
void SwapInt(int* first, int* second)
{
	int third = *first;

	*first = *second;
	*second = third;
}

void SwapDouble(double* first, double* second)
{
	double third = *first;

	*first = *second;
	*second = third;
}
*/

//void pointer can address data of any (non-specific) type
//but it does not support indirection (dereferencing)
void SwapAny(void* first, void* second, int count)
{
	char* f = first;
	char* s = second;
	register int i;

	for(i = 0; i < count; ++i)
	{
		char t = f[i];
		f[i] = s[i];
		s[i] = t;
	}
}

//macro for substituting one expression with another
#define Swap(X, Y) SwapAny(&X, &Y, sizeof(X))

int main(void)
{
	int ix = 23, iy = 32;	
	printf("Original int values = %d, %d\n", ix, iy);
	//SwapInt(&ix, &iy);
	Swap(ix, iy); //SwapAny(&ix, &iy, 4);
	printf("Swapped int values = %d, %d\n", ix, iy);
	
	double dx = 4.56, dy = 5.43;
	printf("Original double values = %lf, %lf\n", dx, dy);
	//SwapDouble(&dx, &dy);
	Swap(dx, dy); //SwapAny(&dx, &dy, 8);
	printf("Swapped double values = %lf, %lf\n", dx, dy);
}

