#include <cstdio>

enum Geometry {Rectangular, Triangular, Elliptical};

class Banner
{
public:		
	
	//can be used as default constructor since its parameter is optional
	Banner(Geometry g = Rectangular)
	{
		region = 100;
		shape = g;
		puts("Banner instance created.");
	}

	bool Resize(float w, float h) 
	{
		if(w >= h)
		{
			region = w * h;
			return true;
		}
		return false;
	}

	double Area() const
	{
		switch(shape)
		{
			case Triangular:
				return region / 2;
			case Elliptical:
				return 3.14 * region / 4;
			default:
				return region;
		}
	}

	//Destructor is a special member function which is called just before an instance
	//is removed from the memory to cancel side-effect of the constructor. If memory is
	//implicitly allocated for an instance then the destructor is called immediately 
	//after the identifier of this instance goes out of scope.
	~Banner()
	{
		puts("Banner instance destroyed");
	}

private:
	double region;
	Geometry shape;
};

