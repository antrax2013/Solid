namespace InterfaceSegregationPrinciple
{
    public interface IInvoice
    {
        decimal GetTaxedTotal();
        decimal GetTotal();
    }
}