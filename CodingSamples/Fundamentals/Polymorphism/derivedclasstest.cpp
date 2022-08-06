#include "banner.h"
#include <cstdio>

double BannerPrice(const Banner& info, int copies)
{
	float rate = copies < 5 ? 0.80 : 0.75;
	//dynamic binding is used when a virtual member function (Area) is called
	//on a pointer/reference(info) of a class (Banner) type
	return copies * rate * info.Area(); 
}

int main(void)
{
	float x, y;
	int n;
	printf("Banner width and height: ");
	scanf("%f%f", &x, &y);
	printf("Number of copies: ");
	scanf("%d", &n);

	Banner a;
	a.Resize(x, y);
	printf("Total payment for regular banner: %.2lf\n", BannerPrice(a, n));

	CurvedBanner b;
	b.Resize(x, y);
	b.Reshape(1);
	printf("Total payment for curved banner: %.2lf\n", BannerPrice(b, n));


}

