#include "interval.h"
#include <iostream>

/*
int SwapAndChoose(int& first, int& second)
{
	int third = first;

	first = second;
	second = third;

	return first < second ? second : first;
}

double SwapAndChoose(double& first, double& second)
{
	double third = first;

	first = second;
	second = third;

	return first < second ? second : first;
}
*/


//Defining a function template which can be used by the compiler to generate
//actual function by substituting type-argument T with the usage type.
template<typename T>
T SwapAndChoose(T& first, T& second)
{
	T third = first;

	first = second;
	second = third;

	return first < second ? second : first;
}

int main(void)
{
	int ip = 23, iq = 32;
	std::cout << "Original int values = " << ip << ", " << iq << std::endl;
	int ir = SwapAndChoose<int>(ip, iq); //calling function generated from corresponding template with T=int
	std::cout << "Swapped int values = " << ip << ", " << iq << std::endl;
	std::cout << "Chosen int value = " << ir << std::endl;

	double dp = 5.43, dq = 3.45;
	std::cout << "Original double values = " << dp << ", " << dq << std::endl;
	double dr = SwapAndChoose(dp, dq); //deducing typename T from argument types
	std::cout << "Swapped double values = " << dp << ", " << dq << std::endl;
	std::cout << "Chosen double value = " << dr << std::endl;

	//SwapAndChoose(ip, dp);

	Interval tp(2, 30), tq(3, 5);
	std::cout << "Original Interval values = " << tp << ", " << tq << std::endl;
	Interval tr = SwapAndChoose(tp, tq);
	std::cout << "Swapped Interval values = " << tp << ", " << tq << std::endl;
	std::cout << "Chosen Interval value = " << tr << std::endl;
}

