#include "banner1.h"
#include <cstdio>

double BannerPrice(Banner info, int copies)
{
	float rate = copies < 5 ? 0.80 : 0.75;
	return copies * rate * info.Area(); //Banner::Area(&info)
}

int main(void)
{
	float x, y;
	int n;
	printf("Banner width and height: ");
	scanf("%f%f", &x, &y);
	printf("Number of copies: ");
	scanf("%d", &n);

	//activation with implicit memory allocation (on stack)
	Banner a;
	//binding - Banner::Resize(&a, x, y)
	a.Resize(x, y);
	printf("Total payment for regular banner: %.2lf\n", BannerPrice(a, n));

	Banner b;
	b.Resize(x + 1, y + 1); //Banner::Resize(&b, x + 1, y + )
	printf("Total payment for bordered banner: %.2lf\n", BannerPrice(b, n));
}

