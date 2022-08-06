//static qualified symbol is not published from the module
static int CheckForPrime(long n)
{
	register long i;

	if(n <= 1)
		return 0;
	
	if(n == 2 || n == 3)
		return 1;

	if(n % 2 == 0 || n % 3 == 0)
		return 0;

	/*
	for(i = 5; i < n; i += 2)
	{
		if(n % i == 0)
			return 0;
	}
	*/

	for(i = 5; i * i <= n; i += 6)
	{
		register long j = i + 2;
		if(n % i == 0 || n % j == 0)
			return 0;
	}

	return 1;
}

int CountPrimes(long first, long last)
{
	register int count = 0;
	register long i;

	for(i = first; i <= last; ++i)
	{
		count += CheckForPrime(i);
	}

	return count;
}

