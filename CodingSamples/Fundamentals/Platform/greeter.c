#include <stdio.h>
#include <unistd.h>

int main(int argc, char* argv[])
{
	int i;

	printf("Running %s process<%d/%d>\n", argv[0], getpid(), getppid());

	for(i = 1; i < argc; ++i)
		printf("Hello %s\n", argv[i]);

}

