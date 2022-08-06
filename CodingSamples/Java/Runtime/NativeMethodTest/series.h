#ifndef SERIES_H
#define SERIES_H

namespace Series
{
	class CommonSequence
	{
	public:
		CommonSequence();
		
		bool Begin(double, double, double);

		double Next(int=0);

		
	private:
		double alpha, delta, term;
	};
}

#endif

