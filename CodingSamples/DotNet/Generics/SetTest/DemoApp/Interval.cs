partial class Interval : IComparable<Interval>
{
    public int Minutes { get; }

    public int Seconds { get; }

    public Interval(int min, int sec)
    {
        Minutes = min + sec / 60;
        Seconds = sec % 60;
    }

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    public override string ToString()
    {
        if(Seconds < 10)
            return Minutes + ":0" + Seconds;
        return Minutes + ":" + Seconds;
    }

    public override int GetHashCode()
    {
        return Minutes + Seconds;
    }

    public override bool Equals(object other)
    {
        if(other is Interval that)
        {
            return (this.Minutes == that.Minutes) && (this.Seconds == that.Seconds);
        }
        return false;
    }

    public int CompareTo(Interval that)
    {
        return this.Time() - that.Time();
    }

}
