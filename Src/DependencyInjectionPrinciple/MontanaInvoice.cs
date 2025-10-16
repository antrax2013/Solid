using Sdk;

namespace DependencyInjectionPrinciple;

public sealed class MontanaInvoice(IEnumerable<Item> items) : AInvoice(items), IInvoice
{
    public decimal GetTotal() => _items.Sum(i => i.UnitPrice);
}
