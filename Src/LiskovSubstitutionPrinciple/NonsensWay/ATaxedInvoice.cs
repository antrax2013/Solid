using Sdk;

namespace LiskovSubstitutionPrinciple.NonsensWay
{
    public abstract class ATaxedInvoice(IEnumerable<Item> items) : AInvoice(items)
    {
        public abstract decimal GetTaxedTotal();
    }
}
