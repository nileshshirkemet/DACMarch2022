enum Geometry {Rectangular, Triangular, Elliptical};

class Banner
{
public:	
	
	//A constructor defined without any non-optional parameter is called a default constructor
	//and it is implicitly defined (by compiled) for a class which does not explicitly define any constructor
	Banner()
	{
		region = 100;
		shape = Rectangular;
	}
	
	//parameterized constructor
	Banner(Geometry g)
	{
		region = 100;
		shape = g;
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

private:
	double region;
	Geometry shape;
};

