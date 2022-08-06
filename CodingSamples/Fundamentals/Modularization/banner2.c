#include "banner2.h"
#define PI 3.1416

//A function which treats the aggregate type data identified by its argument as read-only
//should accept this argument by address (reference) using a const qualified parameter
//to avoid expensive copying of data.
static double BannerArea(const Banner* info)
{
	switch((*info).shape)
	{
		case Triangular:
			return info->width * info->height / 2;
		case Elliptical:
			return PI * info->width * info->height / 4;
		default:
			return info->width * info->height;
	}
}

double BannerPrice(Banner info, int copies)
{
	float rate = copies < 5 ? 0.80 : 0.75;
	return copies * rate * BannerArea(&info);
}

