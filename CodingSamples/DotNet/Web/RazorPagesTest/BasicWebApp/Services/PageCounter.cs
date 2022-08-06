namespace BasicWebApp.Services;

public class PageCounter : IHitCounter
{
    private Dictionary<string, int> _counters = new();

    public int CountNext(string name)
    {
        lock(_counters)
        {
            _counters.TryGetValue(name, out int count);
            _counters[name] = ++count;
            return count;
        }
    }
}