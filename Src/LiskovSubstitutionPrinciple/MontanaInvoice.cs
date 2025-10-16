using Sdk;

namespace LiskovSubstitutionPrinciple;

public sealed class MontanaInvoice(IEnumerable<Item> items) : AInvoice(items)
{
    public override decimal GetTaxedTotal()
    {
        throw new NotImplementedException();
    }
}
