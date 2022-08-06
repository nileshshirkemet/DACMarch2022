#include <stdio.h>

#ifdef LINUX_X64

void Delay(int ts) //delay execution using system-call interface
{
	long interval[] = {ts, 0};

	asm("syscall" :: "D"(interval), "a"(35));
	/*
	mov	rax, 35
	mov	rdi, interval
	syscall
	*/
}

#endif

#ifdef UNIX_ANY

#include <unistd.h>

void Delay(int ts) //delay execution using platform interface (POSIX)
{
	usleep(1000000 * ts);
}

#endif

#ifdef OS_ANY

#include <time.h> //delay execution using C runtime library (LIBC)

void Delay(int ts)
{
	clock_t future = clock() + ts * CLOCKS_PER_SEC;

	while(clock() < future);
}

#endif

int main(int argc, char* argv[])
{
	register int i;

	for(i = 1; i < argc; ++i)
	{
		printf("Hello %s\n", argv[i]);
		Delay(i);
	}

	puts("Goodbye.");
}

