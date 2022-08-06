#include "interval.h"
#include <iostream>
#include <string>

//Defining a class template which can be used by the compiler to generate 
//actual class by substituting type-argument V by usage type.
template<typename V>
class Selector
{
public:
	Selector(const V& x, const V& y) : first(x), second(y) //initializing member variable as a copy of the argument
	{
		//first = x;
		//second = y;
	}

	V Select(int index) const
	{
		if(index % 2 == 1)
			return first;
		return second;
	}
private:
	V first;
	V second;
};

int main(void)
{
	using namespace std;

	int i;
	cout << "Index: ";
	cin >> i;

	Selector<double> sd(23.4, 43.2); //generating class from corresponding template with V=double
	cout << "Selected double value = "
	     << sd.Select(i)
	     << endl;

	Selector<string> ss("Monday", "Friday");
	cout << "Selected string value = "
	     << ss.Select(i)
	     << endl;


	Interval a(4, 35), b(5, 20);
	Selector<Interval> si(a, b);
	cout << "Selected Interval value = "
	     << si.Select(i)
	     << endl;


}

