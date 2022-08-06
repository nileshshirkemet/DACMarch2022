#include <time.h>

long DoWork(int count, long seed)
{
	clock_t t = clock() + CLOCKS_PER_SEC * count / 10;

	while(clock() < t);

	return count + seed;
}

