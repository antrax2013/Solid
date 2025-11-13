using Sdk;

namespace InterfaceSegregationPrinciple;

public sealed class ItalianInvoice(IEnumerable<Item> items) : IInvoice, ITaxedInvoice
{
    private static decimal GetRate { get => 1.22m; }

    public IEnumerable<Item> Items => items;

    public decimal GetTaxedTotal() => ITaxedInvoice.ComputeTaxedTotal(Items, GetRate);

    public decimal GetTotal() => IInvoice.Get(Items);
}
