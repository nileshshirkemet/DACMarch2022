namespace Taxation;

public interface ITaxPayer
{
    private static int count;

    double AnnualIncome();

    double IncomeTax()
    {
        double i = AnnualIncome();
        ++count;
        return i > 120000 ? 0.15 * (i - 120000) : 0;
    }
}
