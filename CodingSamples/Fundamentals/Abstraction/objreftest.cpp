#include "banner3.h"
#include <cstdio>

//A function should accept a class type argument by reference to avoid creation
//of a copy of the instance passed for that argument and if this function treats
//that argument as read-only then the corresponding parameter should be declared
//with const qualifier
double BannerPrice(const Banner& info, int copies)
{
	float rate = copies < 5 ? 0.80 : 0.75;
	return copies * rate * info.Area(); 
}

int main(void)
{
	int n;
	printf("Number of copies: ");
	scanf("%d", &n);

	if(n < 3)
	{
		Banner a;
		printf("Total price for standard banner: %.2f\n", BannerPrice(a, n));
	}//destructor will be called on instance a
	
	Banner b(Elliptical);
	b.Resize(15, 4);
	printf("Total price for elliptical banner: %.2f\n", BannerPrice(b, n));
}//destructor will be called on instance b

