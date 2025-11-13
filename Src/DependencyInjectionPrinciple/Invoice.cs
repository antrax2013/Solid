using Sdk;

namespace DependencyInjectionPrinciple;

public sealed class Invoice(IEnumerable<Item> items, ITotalCalculator calculator)
{
    public IEnumerable<Item> Items { get; } = items;

    public decimal GetTotal() => calculator.GetTotal(Items);
}
