#include <stdio.h>

int main(void)
{
	short int age;
	float rate;

	printf("Age: ");
	scanf("%hd", &age);

	/*
	if(age == 16)
	{
		rate = 125;
	}
	else if(age == 18)
	{
		rate = 150;
	}
	else if(age == 21)
	{
		rate = 200;
	}
	else if(age == 50)
	{
		rate = 300;
	}
	else
	{
		rate = 100;
	}
	*/

	switch(age)
	{
		case 16:
			rate = 125;
			break;
		case 18:
			rate = 150;
			break;
		case 21:
			rate = 200;
			break;
		case 50:
			rate = 300;
			break;
		default:
			rate = 100;
	}

	printf("Gift Amount = %.2f\n", age * rate);
}

