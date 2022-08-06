//Namespace is a named scope containing related symbols grouped together to avoid
//collisions between their names and names of symbols not belonging to their group.
//A member M of namespace N is identified by its qualified name N::M outside of N.
namespace Series
{
	//Abstract Data Type (ADT) is a class which contains at least one pure virtual function.
	//It does not support creation of instances but it can be used as a reference/parameter
	//type to address an instance of its derived class which has overridden its pure virtual
	//functions.
	class Sequence
	{
	public:
		//pure virtual function is defined without any specific implementation
		virtual double Next() = 0;

		double Sum(int);
	};

	class RandomAccess
	{
	public:
		virtual double Seek(int) = 0;
	};

	//multiple inheritance
	class LinearSequence : public Sequence, public RandomAccess
	{
	public:
		LinearSequence(double, float);

		double Next();
		
		double Seek(int);
	private:
		double current;
		float step;
	};

	//single inheritance
	class PowerSequence : public Sequence
	{
	public:
		PowerSequence(float);

		double Next();
	private:
		double current;
		float base;
	};
}


