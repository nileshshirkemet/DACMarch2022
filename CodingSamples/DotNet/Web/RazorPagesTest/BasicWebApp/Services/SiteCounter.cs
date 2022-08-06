namespace BasicWebApp.Services;

public class SiteCounter : IHitCounter
{
    private int _count;

    public int CountNext(string name)
    {
        return Interlocked.Increment(ref _count);
    }
}
