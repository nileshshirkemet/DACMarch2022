using System.Runtime.CompilerServices;

namespace Finance;


public class HomeLoan
{
    public float Common(double amount, int period) => period < 5 ? 9.0f : 8.5f;

    [MaxDuration(12)] //custom attribute
    public float Woman(double amount, int period) => Common(amount, period) - 1;

    [MethodImpl(MethodImplOptions.Synchronized)] //pseudo attribute
    public float Soldier(double amount, int period) => Common(amount, period) - 4;

}
