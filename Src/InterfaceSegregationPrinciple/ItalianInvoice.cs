using Sdk;

namespace InterfaceSegregationPrinciple;

public sealed class ItalianInvoice(IEnumerable<Item> items) : IInvoice, ITaxedInvoice
{
    public IEnumerable<Item> Items => items;

    public decimal GetTaxedTotal() => ITaxedInvoice.ComputeTaxedTotal(Items, 1.22m);

    public decimal GetTotal() => IInvoice.ComputeTotal(Items);
}
