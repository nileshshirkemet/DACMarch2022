int Transform(char data[], int count)
{
	register int i, j;

	for(i = 0, j = count - 1; i < j; ++i, --j)
	{
		char ib = data[i];
		char jb = data[j];

		data[i] = jb;
		data[j] = ib;
	}

	return count;
}

