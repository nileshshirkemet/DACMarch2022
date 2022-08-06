char salt = '#';

int Transform(char data[], int count)
{
	register int i;

	for(i = 0; i < count; ++i)
		data[i] ^= salt;

	return count;
}

/*

Only an object module containing position-independent code (which does 
not use direct memory addressing) can be included in a shared-object
for dynamic linking since such a code can be mapped anywhere in the
address-space of a process.
A C module whose functions reference global symbols must be compiled
with -fPIC to force generation of position-indepencent code in the
object module.
*/
