#include "interval.h"
#include <cstdio>

int main(void)
{
	Interval a(4, 105);
	printf("First Interval = ");
	a.Print();
	
	Interval b(3, 20);
	printf("Second Interval = ");
	b.Print();

	Interval c = b; //Interval c(b)
	printf("Third Interval = ");
	c.Print();

	Interval d = a + b; //a.operator+(b)
	printf("Fourth Interval = ");
	d.Print();

	printf("Number of Intervals = %d\n", Interval::CountInstances());

}

