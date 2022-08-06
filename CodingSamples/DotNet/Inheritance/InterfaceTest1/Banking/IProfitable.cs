namespace Banking;

public interface IProfitable
{
    double AddInterest(int months);
    
    const float MinRate = 4;

}