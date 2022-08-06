#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <signal.h>

void End(void)
{
	puts("Releasing resources...");
}

void Begin(void)
{
	puts("Acquiring resources...");
	atexit(End);
}

void Run(void)
{
	int table[] = {0, 1, 4, 9, 16, 25, 36};
	int index;

	puts("Consuming resources...");
	printf("Index [1-6]: ");
	scanf("%d", &index);
	printf("Result = %d\n", 7200 / table[index]);
	
}

void MainHandler(int signo)
{
	switch(signo)
	{
		case SIGFPE: //8
			puts("ERROR: Invalid arithmetic operation!");
			break;
		case SIGSEGV: //11
			puts("ERROR: Illegal memory access!");
			break;
		default:
			puts("");
	}

	exit(signo);
}


int main(void)
{	
	struct sigaction act = {MainHandler};

	sigaction(SIGFPE, &act, NULL);
	sigaction(SIGSEGV, &act, NULL);
	sigaction(SIGINT, &act, NULL);

	Begin();
	Run();
}

