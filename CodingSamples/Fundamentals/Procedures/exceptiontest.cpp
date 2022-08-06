#include <cstdio>

//default arguments are the value passed implicitly (by compiler) for the
//optional parameters of the function appearing at the end of its parameter list
int Compute(int lower, int upper, short step=1)
{
	int result = 0;

	if(lower > upper)
		throw (lower - upper); //ending invocation by throwing a value of int type


	for(int i = lower; i <= upper; i += step)
	{
		result += i;
	}

	return result; //ending invocation by returning a value of int type
}

int main(void)
{
	int first, last;
	printf("Lower and Upper Limits: ");
	scanf("%d%d", &first, &last);

	try
	{
		printf("First computation result = %d\n", Compute(first, last)); //Compute(first, last, 1)
		printf("Second computation result = %d\n", Compute(first, last, 2));
	}
	catch(int r) //exception handler for int type exception ocurring in above try block
	{
		printf("Error: out of range by %d\n", r);
	}
}

