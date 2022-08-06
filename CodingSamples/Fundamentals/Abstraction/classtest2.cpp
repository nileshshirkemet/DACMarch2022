#include "banner2.h"
#include <cstdio>

double BannerPrice(Banner info, int copies)
{
	float rate = copies < 5 ? 0.80 : 0.75;
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

	Banner a; //initialization using default constructor
	a.Resize(x, y);
	printf("Total payment for regular banner: %.2lf\n", BannerPrice(a, n));

	Banner b;
	b.Resize(x + 1, y + 1); 
	printf("Total payment for bordered banner: %.2lf\n", BannerPrice(b, n));

	Banner c(Elliptical); //initialization using parameterized constructor
	c.Resize(x, y);
	printf("Total payment for elliptical banner: %.2lf\n", BannerPrice(c, n));
}

