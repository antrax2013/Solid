using Sdk;

namespace DependencyInjectionPrinciple;

public class TotalCalculator : ITotalCalculator
{
    public decimal GetTotal(IEnumerable<Item> items) => items.Sum(i => i.UnitPrice);
}
