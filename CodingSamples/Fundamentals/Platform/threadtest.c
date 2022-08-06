#include "worker.h"
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>

//the value of a global variable declared with volatile qualifier may updated concurrently
//and as such it should not be retained in a register across multiple instructions
volatile double value = 0;

void HandleJob(int jno)
{
	printf("Thread<%lx> has accepted job<%d>\n", pthread_self(), jno);
	DoWork(10 * jno, 0);
	printf("Thread<%lx> has finished job<%d>\n", pthread_self(), jno);
}

void* ChildRoutine(void* arg)
{
	HandleJob(1);
	while(value == 0)
		sched_yield(); //release the processor to another thread
	printf("Result produced by child<%lx>: %lf\n", pthread_self(), value * value);
}

int main(void)
{
	pthread_t child;

	//creating a new thread with its own stack to concurrently execute the specified
	//routine while sharing the address-space of its parent(creating) process.
	pthread_create(&child, NULL, ChildRoutine, NULL);

	HandleJob(2);
	
	printf("Input value for parent<%lx>: ", pthread_self());
	scanf("%lf", &value);

	pthread_join(child, NULL); //wait for child to exit
}

