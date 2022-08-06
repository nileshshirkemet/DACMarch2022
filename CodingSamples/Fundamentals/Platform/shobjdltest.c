#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <dlfcn.h>

int main(int argc, char* argv[])
{
	void* lib;

	if(argc < 2)
		return printf("USAGE: %s library-to-use\n", argv[0]);
	
	lib = dlopen(argv[1], RTLD_NOW); //RTLD_LAZY
	if(lib)
	{
		int (*fn)(char[], int);

		fn = dlsym(lib, "Transform");
		if(fn)
		{
			char text[80];

			printf("Text to process: ");
			scanf("%79[^\n]s", text); //array is already an address (of its element)
			fn(text, strlen(text));
			printf("Processed text: %s\n", text);
		}
		else
			printf("ERROR: Invalid library\n");

		dlclose(lib);
	}
	else
		printf("ERROR: Cannot load %s\n", argv[1]);
}

