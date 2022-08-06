#include "series.h"

namespace Series
{

	//implementing Sum member function declared in Sequence class
	double Sequence::Sum(int count)
	{
		double total = 0;

		for(int i = 1; i <= count; ++i)
			total += Next();

		return total;
	}

	LinearSequence::LinearSequence(double start, float difference)
	{
		current = start;
		step = difference;
	}

	double LinearSequence::Next()
	{
		double term = current;
		current += step;
		return term;
	}

	double LinearSequence::Seek(int position)
	{
		current += step * (position - 1);
		return current;
	}

	PowerSequence::PowerSequence(float ratio)
	{
		current = 1;
		base = ratio;
	}

	double PowerSequence::Next()
	{
		double term = current;
		current *= base;
		return term;
	}
}

