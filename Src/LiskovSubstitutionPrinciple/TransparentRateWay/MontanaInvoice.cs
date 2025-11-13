using Sdk;

namespace LiskovSubstitutionPrinciple.TransparentRateWay;

public sealed class MontanaInvoice(IEnumerable<Item> items) : AInvoice(items)
{
    public override decimal GetTaxedTotal() => GetTotal();
}
