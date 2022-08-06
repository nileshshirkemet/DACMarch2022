#include "worker.h"
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>

long collection = 0;

void* ProcessDonation(void* name)
{
	//a local variable declared with static qualifier is initialized once 
	//and its single value is shared across all the calls of the function
	static pthread_mutex_t monitor = PTHREAD_MUTEX_INITIALIZER;
	int notes = rand() % 5 + 1;

	printf("Receiving %d hundred from %s...\n", notes, (char*)name);
	
	//only one thread can lock the mutex and resume execution while other threads 
	//must wait for this thread to unlock that mutex
	pthread_mutex_lock(&monitor);
	collection = DoWork(notes, collection);
	pthread_mutex_unlock(&monitor);
}

int main(void)
{
	char* donors[] = {"Jack", "Jill", "John", "Jane", "Jeff"};
	pthread_t child[5];
	int i;

	srand(time(NULL));
	for(i = 0; i < 5; ++i)
	{
		//ProcessDonation(donors[i]);
		pthread_create(&child[i], NULL, ProcessDonation, donors[i]);
	}

	for(i = 0; i < 5; ++i)
	{
		pthread_join(child[i], NULL);
	}

	printf("Total collection is %ld\n", 100 * collection);
}

