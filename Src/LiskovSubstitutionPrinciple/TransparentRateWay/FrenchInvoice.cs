using Sdk;

namespace LiskovSubstitutionPrinciple.TransparentRateWay;

public sealed class FrenchInvoice(IEnumerable<Item> items) : AInvoice(items, 1.2m)
{ }
