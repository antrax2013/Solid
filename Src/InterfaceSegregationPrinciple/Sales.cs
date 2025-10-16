namespace InterfaceSegregationPrinciple;

public sealed class Sales(IEnumerable<AInvoice> invoices)
{
    private readonly IEnumerable<AInvoice> _invoices = invoices;

    public decimal GetTaxedSales() => _invoices.Sum(i => i.GetTaxedTotal());
}
