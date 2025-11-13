using Sdk;

namespace DependencyInjectionPrinciple;

public sealed class FrenchInvoiceFactory(IEnumerable<Item> items) : IInvoiceFactory
{
    public Invoice GetInstance()
    {
        return new Invoice(items, new TaxedTotalCalculator(1.2m));
    }
}
