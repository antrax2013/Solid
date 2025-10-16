namespace LiskovSubstitutionPrinciple;

public sealed class Sales(IEnumerable<Invoice> invoices)
{
    private readonly IEnumerable<Invoice> _invoices = invoices;

    public decimal GetTaxedSales() => _invoices.Sum(i => i.GetTaxedTotal());
}
