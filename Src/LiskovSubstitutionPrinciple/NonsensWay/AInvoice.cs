using Sdk;

namespace LiskovSubstitutionPrinciple.NonsensWay;

public abstract class AInvoice(IEnumerable<Item> items)
{
    protected readonly IEnumerable<Item> _items = items;

    public decimal GetTotal() => _items.Sum(i => i.UnitPrice);
}
