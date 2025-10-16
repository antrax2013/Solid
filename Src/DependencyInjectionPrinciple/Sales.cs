namespace DependencyInjectionPrinciple;

public sealed class Sales(IEnumerable<ITaxedInvoice> invoices)
{
    private readonly IEnumerable<ITaxedInvoice> _invoices = invoices;

    public decimal GetTaxedSales() => _invoices.Sum(i => i.GetTaxedTotal());
}
