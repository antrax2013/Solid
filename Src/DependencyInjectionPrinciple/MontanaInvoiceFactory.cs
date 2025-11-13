using Sdk;

namespace DependencyInjectionPrinciple;

public sealed class MontanaInvoiceFactory(IEnumerable<Item> items) : IInvoiceFactory
{
    public Invoice GetInstance()
    {
        return new Invoice(items, new TotalCalculator());
    }
}

