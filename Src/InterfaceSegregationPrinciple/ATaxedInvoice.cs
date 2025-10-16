using Sdk;

namespace InterfaceSegregationPrinciple;

public abstract class ATaxedInvoice(IEnumerable<Item> items) : AInvoice(items)
{
    public abstract decimal GetTaxedTotal();
}
