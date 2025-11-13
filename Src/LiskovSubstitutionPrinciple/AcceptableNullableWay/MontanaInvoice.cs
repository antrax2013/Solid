using Sdk;

namespace LiskovSubstitutionPrinciple.AcceptableNullableWay;

public sealed class MontanaInvoice(IEnumerable<Item> items) : AInvoice(items)
{
    public override decimal? GetTaxedTotal() => null;
}
