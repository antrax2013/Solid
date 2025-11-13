using Sdk;

namespace InterfaceSegregationPrinciple;

public sealed class FrenchInvoice(IEnumerable<Item> items) : IInvoice, ITaxedInvoice

{
    public IEnumerable<Item> Items => items;

    public decimal GetTaxedTotal() => ITaxedInvoice.ComputeTaxedTotal(Items, 1.2m);

    public decimal GetTotal() => IInvoice.ComputeTotal(Items);
}
