#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/wait.h>

long sum = 0;

int main(void)
{
	pid_t cpid;

	printf("Hello from process<%d/%d>\n", getpid(), getppid());
	//each call to fork creates a child process with its own address space mapped
	//to a copy of the memory image of its caller (parent) process
	cpid = fork();
	//any code that follows a call to fork will be executed in the caller's process
	//(in which fork returns child pid) as well as in the child process (in which
	//fork returns zero)
	//printf("Fork returned %d in process<%d/%d>\n", cpid, getpid(), getppid()); 
	if(cpid == 0)
	{
		//this code will be executed only by child process
		//execute command line by replacing the current process image
		execl("./greeter", "Greeter", "Mother", "Father", "Others", NULL);
	}
	else
	{
		//this code will be executed only by parent process
		waitpid(cpid, NULL, 0); //wait for child process to exit and then release its resources
		printf("Goodbye from parent process<%d/%d>\n", getpid(), getppid());
	}

}

