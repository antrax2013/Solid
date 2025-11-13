using Sdk;

namespace DependencyInjectionPrinciple;

public class TaxedTotalCalculator(decimal Rate) : ITotalCalculator
{
    private readonly decimal _rate = Rate;

    public decimal GetTotal(IEnumerable<Item> items) => items.Sum(i => i.UnitPrice * _rate);
}
