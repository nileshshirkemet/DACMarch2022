#include "banner2.h"
#include <stdio.h>

int main(void)
{
	Banner ad = {0, 0};
	int n;

	printf("Banner width and height: ");
	scanf("%f%f", &ad.width, &ad.height);
	printf("Number of copies: ");
	scanf("%d", &n);
	printf("Total Payment for rectangular banner: %.2lf\n", BannerPrice(ad, n));
	ad.shape = Elliptical;
	printf("Total Payment for elliptical banner: %.2lf\n", BannerPrice(ad, n));

	return sizeof(ad);
}

