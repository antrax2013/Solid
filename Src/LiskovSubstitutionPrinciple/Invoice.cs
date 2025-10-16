using Sdk;

namespace LiskovSubstitutionPrinciple;

public abstract class Invoice(IEnumerable<Item> items)
{
    protected readonly IEnumerable<Item> _items = items;

    public decimal GetTotal() => _items.Sum(i => i.UnitPrice);
    public abstract decimal GetTaxedTotal();
}
