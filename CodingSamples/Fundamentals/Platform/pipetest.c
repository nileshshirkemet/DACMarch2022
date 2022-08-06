#include "worker.h"
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/wait.h>


void HandleJob(int jno)
{
	printf("Process<%d> has accepted job<%d>\n", getpid(), jno);
	DoWork(10 * jno, 0);
	printf("Process<%d> has finished job<%d>\n", getpid(), jno);
}

int main(void)
{
	pid_t child;
	int channel[2];
	double value;

	pipe(channel); //create descriptors for pipe identified by channel[0] (read-only) and channel[1] (write-only)
	child = fork();

	if(child == 0)
	{
		HandleJob(1);

		read(channel[0], &value, sizeof(value));
		printf("Result produced by child<%d>: %lf\n", getpid(), value * value);
	}
	else
	{

		HandleJob(2);

		printf("Input value for parent<%d>: ", getpid());
		scanf("%lf", &value);
		write(channel[1], &value, sizeof(value));

		waitpid(child, NULL, 0);
	}

	close(channel[0]);
	close(channel[1]);
}

