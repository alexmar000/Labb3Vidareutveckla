namespace Lab3Coffee;

public interface IWarmDrinkFactory
{
    IWarmDrink Prepare(int total);
}
