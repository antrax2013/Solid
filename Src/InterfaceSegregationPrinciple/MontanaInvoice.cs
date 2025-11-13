using Sdk;

namespace InterfaceSegregationPrinciple;

public sealed class MontanaInvoice(IEnumerable<Item> items) : IInvoice
{
    public IEnumerable<Item> Items => items;

    public decimal GetTotal() => IInvoice.ComputeTotal(Items);
}
