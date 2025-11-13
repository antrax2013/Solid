namespace OpenClosedPrinciple;

public sealed class Sales(IEnumerable<IInvoice> invoices)
{
    private readonly IEnumerable<IInvoice> _invoices = invoices;

    public decimal GetTaxedSales()
    {
        decimal total = 0;

        foreach (IInvoice i in _invoices)
            total += i.GetTaxedTotal();

        return total;
    }
}
