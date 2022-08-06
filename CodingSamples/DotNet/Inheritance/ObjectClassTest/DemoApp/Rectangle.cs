struct Rectangle
{
    public float Length;

    public float Breadth;

    public double Area()
    {
        return Length * Breadth;
    }

    public override string ToString()
    {
        return string.Format("{0} x {1}", Length, Breadth);
    }
}