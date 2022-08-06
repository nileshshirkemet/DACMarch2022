class Banner
{
public:
	Banner()
	{
		width = 20;
		height = 5;
	}

	bool Resize(float w, float h) 
	{
		if(w >= h)
		{
			width = w;
			height = h;
			return true;
		}
		return false;
	}

	//virtual function supports dynamic-binding in which the invocation of
	//the member function is indirected through (v-table of class addressed by)
	//the instance of its class
	virtual double Area() const
	{
		return width * height;
	}

private:
	float width; 

protected: //members declared in this block are visible in a derived class
	float height;
};


//CurvedBanner is a subclass of Banner (base class).
//It (publicly) inherits all the members of Banner
class CurvedBanner : public Banner
{
public:
	//derived class constructor must call base class constructor
	CurvedBanner() : Banner()
	{
		radius = 0.1;
	}

	bool Reshape(float r)
	{
		if(r < height / 2)
		{
			radius = r;
			return true;
		}
		return false;
	}

	//overloading member function is defining a function in a class whose name matches
	//with the name of another function in the current class but has different
	//list of parameter types
	void Reshape()
	{
		radius = height < 10 ? 0.1 : 0.2;
	}

	//overriding member function is defining a function in a class whose declaration
	//matches with the declaration of a virtual function defined in the base class
	double Area() const
	{
		//calling same function from base class
		return Banner::Area() - 0.86 * radius * radius;
	}
private:
	float radius;
};

