#include "banner1.h"
#include <stdio.h>

int main(void)
{
	Banner ad = {0, 0};
	int n;

	printf("Banner width and height: ");
	scanf("%f%f", &ad.width, &ad.height);
	printf("Number of copies: ");
	scanf("%d", &n);
	printf("Total Payment: %.2lf\n", BannerPrice(ad, n));
}

