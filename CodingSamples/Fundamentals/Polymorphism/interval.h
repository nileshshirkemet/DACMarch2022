#include <iostream>

class Interval
{
public:
	Interval(int min, int sec)
	{
		minutes = min + sec / 60;
		seconds = sec % 60;
		++count;
	}

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

	Interval operator+(const Interval& other) const
	{
		int m = minutes + other.minutes;
		int s = seconds + other.seconds;
		return Interval(m, s);
	}

	bool operator<(const Interval& other) const
	{
		int t1 = 60 * minutes + seconds;
		int t2 = 60 * other.minutes + other.seconds;
		return t1 < t2;
	}

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
	static long count;

//a non-member function declared with friend qualifier in a class
//has access to private members of that class (because it is defined
//by author of that class)
friend std::ostream& operator<<(std::ostream&, const Interval&);
};

long Interval::count = 0; 

std::ostream& operator<<(std::ostream& out, const Interval& value)
{
	if(value.seconds < 10)
		out << value.minutes << ":0" << value.seconds;
	else
		out << value.minutes << ":" << value.seconds;
	return out;
}


