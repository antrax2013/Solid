using Sdk;

namespace DependencyInjectionPrinciple;

public abstract class AInvoice(IEnumerable<Item> items)
{
    protected readonly IEnumerable<Item> _items = items;
}
