namespace OpenClosedPrinciple;

public sealed class Sales(IEnumerable<Object> invoices)
{
    private readonly IEnumerable<Object> _invoices = invoices;

    public decimal GetSales()
    {
        decimal total = 0;

        foreach (Object i in _invoices)
            total += (i switch
            {
                FrenchInvoice fi => fi.GetTaxedTotal(),
                ItalianInvoice ii => ii.GetTaxedTotal(),
                _ => 0
            });

        return total;
    }
}
