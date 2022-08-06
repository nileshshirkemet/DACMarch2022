namespace Finance;

public class PersonalLoan
{
    [MaxDuration(Limit = 6)]
    public float Common(double amount, int period) => 10 + 0.5f * period;

    public float Employee(double amount, int period) => amount < 600000 ? Common(amount, period) / 2 : 8;
}
