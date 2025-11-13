using Sdk;

namespace LiskovSubstitutionPrinciple
{
    public abstract class ATaxedInvoice(IEnumerable<Item> items) : AInvoice(items)
    {
        public abstract decimal GetTaxedTotal();
    }
}
