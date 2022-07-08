using System;
namespace Lab3Coffee;

public class Program
{
    static void Main()
    {
        var machine = new WarmDrinkMachine();
        IWarmDrink drink = machine.MakeDrink();
        drink.Consume();
    }

}