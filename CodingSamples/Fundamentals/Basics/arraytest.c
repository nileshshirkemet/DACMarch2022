#include "console.h"   //Standard C/ Ansi 

long long int month = 0; //global variable (allocated in data-segment)

//defining an array 
long long int year[] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

int main(void)
{
	long long int days = 0; //local variable (allocated in stack-frame)

	month = GetInt("Month[1-12]: ");
	days = year[month - 1];        //     [year + (8 * month-1))]  [7000 + (8 * 4)]  [7032] 
	PutInt("Number of Days = ", days);
}


