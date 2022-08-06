#include "worker.h"
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <semaphore.h>
#include <sys/wait.h>
#include <sys/mman.h>

sem_t* guard;

void HandleJob(int jno)
{
	//if current value of semaphore is greater than zero, decrement the value and resume
	//execution otherwise wait for this value to be incremented
	sem_wait(guard);

	printf("Process<%d> has accepted job<%d>\n", getpid(), jno);
	DoWork(10 * jno, 0);
	printf("Process<%d> has finished job<%d>\n", getpid(), jno);

	sem_post(guard); //increment current value of semaphore
}

int main(void)
{
	register int i;

	//mapping an anonymous (fileless) block of virtual memory to share it with children processes
	guard = mmap(NULL, sizeof(sem_t), PROT_READ | PROT_WRITE, MAP_SHARED | MAP_ANONYMOUS, -1, 0);
	//initializing a semaphore (first argument) in shared-memory to limit the concurrency of 
	//children processes (non-zero second argument) to a specified value (third argument)
	sem_init(guard, 1, 3);

	for(i = 1; i <= 5; ++i)
	{
		if(fork() == 0)
		{
			HandleJob(i);
			exit(i);
		}
	}

	while(wait(NULL) > 0);

	//finalize semaphore
	sem_destroy(guard);
	//release shared-memory block
	munmap(guard, sizeof(sem_t));

}

