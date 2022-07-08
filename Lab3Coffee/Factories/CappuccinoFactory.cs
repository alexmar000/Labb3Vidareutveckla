namespace Lab3Coffee;

internal class CappuccinoFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot water in your cup");
        return new Cappuccino();
    }
}
