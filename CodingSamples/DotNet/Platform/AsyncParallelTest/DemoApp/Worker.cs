static class Worker
{
    public static long DoWork(int count)
    {
        int t = Environment.TickCount + 100 * count;
        while(Environment.TickCount < t);
        return count * count;
    }
}