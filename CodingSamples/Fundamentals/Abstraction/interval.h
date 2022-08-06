#include <cstdio>

class Interval
{
public:
	Interval(int min, int sec)
	{
		minutes = min + sec / 60;
		seconds = sec % 60;
		++count;
	}

	//copy constructor is called when a new instance is initialized as a copy
	//of another instance referenced by its argument
	Interval(const Interval& source)
	{
		minutes = source.minutes;
		seconds = source.seconds;
		++count;
	}

	int Time() const
	{
		return 60 * minutes + seconds;
	}

	void Print() const
	{
		printf("%d:%02d\n", minutes, seconds);
	}

	//operator overloading
	Interval operator+(const Interval& other) const
	{
		int m = minutes + other.minutes;
		int s = seconds + other.seconds;
		return Interval(m, s);
	}

	//static member function can be called on the class (using ::)
	//it does not receive 'this' argument and as such it can only
	//refer to static members of the class
	static int CountInstances()
	{
		return count;
	}

	~Interval()
	{
		--count;
	}
private:
	int minutes;
	int seconds;
	static long count; //value of static member variable is shared by all instances
};

long Interval::count = 0; //initializing static count variable of Interval class

