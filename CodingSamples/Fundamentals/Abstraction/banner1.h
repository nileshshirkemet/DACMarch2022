class Banner
{
public: //members declared in this (access-control) block are also visible outside of this class

	//Constructor is a special member function which is called immediately after a
	//new instance of the class is placed into the memory for initializing the values
	//of the member variables for this instance. It is declared without any return type
	//and with a name that matches with the name of the class.
	Banner()
	{
		width = 20;
		height = 5;
	}

	//member function
	bool Resize(float w, float h)  //bool Banner::Resize(Banner* this, float w, float h)
	{
		if(w >= h)
		{
			width = w; //this->width = w;
			height = h; //this->height = h;
			return true;
		}
		return false;
	}

	double Area() const //double Banner::Area(const Banner* this)
	{
		return width * height; //return this->width * this->height
	}

private: //members declared in this block are only visible in this class
	//member variable
	float width; 
	float height;
};

