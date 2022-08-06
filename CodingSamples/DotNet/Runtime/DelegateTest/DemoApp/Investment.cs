delegate float Interest(int years);

class Investment
{
    public double Payment { get; }

    public int Count { get; }

    public Investment(double payment, int count)
    {
        Payment = payment;
        Count = count;
    }

    public double FutureValue(Interest rate)
    {
        float i = rate.Invoke(Count);
        return (Payment / i) * (Math.Pow(1 + i, Count) - 1);
    }
}