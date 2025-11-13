using Sdk;

namespace DependencyInjectionPrinciple;

public sealed class ItalianInvoiceFactory(IEnumerable<Item> items) : IInvoiceFactory
{
    public Invoice GetInstance()
    {
        return new Invoice(items, new TaxedTotalCalculator(1.22m));
    }
}
