namespace InterfaceSegregationPrinciple;

public sealed class Sales(IEnumerable<ATaxedInvoice> invoices)
{
    private readonly IEnumerable<ATaxedInvoice> _invoices = invoices;

    public decimal GetTaxedSales() => _invoices.Sum(i => i.GetTaxedTotal());
}
