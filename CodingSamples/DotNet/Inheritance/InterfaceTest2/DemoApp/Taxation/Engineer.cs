namespace Taxation;

public struct Engineer : ITaxPayer
{
    private int projects;

    public Engineer(int count)
    {
        projects = count;
    }

    public double AnnualIncome()
    {
        return 600000 + 50000 * projects;
    }
}