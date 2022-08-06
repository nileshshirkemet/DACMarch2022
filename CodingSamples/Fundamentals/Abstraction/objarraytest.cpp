#include "banner3.h"
#include <cstdio>

int main(void)
{
	int n;
	printf("Number of Banners: ");
	scanf("%d", &n);

	if(n == 1)
	{
		//explicitly allocating memory (on heap) for a new instance and 
		//initializing this instance using parameterized constructor
		Banner* a = new Banner(Elliptical);
		a->Resize(15, 4);
		printf("Area of Banner: %.2lf\n", a->Area());
		//deallocate the explicitly allocated memory for the instance
		//after calling its destructor
		delete a;
	}
	else
	{
		//explicitly allocating memory (on heap) for an array of n instances and
		//initializing those instances using default contsructor
		Banner* list = new Banner[n];
		for(int i = 0; i < n; ++i)
		{
			list[i].Resize(i + 15, i + 4);
			printf("Area of Banner %d is %.2lf\n", i + 1, list[i].Area());
		}
		//deallocating the explicitly allocated memory for an array of instances
		//after calling destructor on each of those instances
		delete[] list;

	}
	
}

