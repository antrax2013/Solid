using Sdk;

namespace LiskovSubstitutionPrinciple.AcceptableNullableWay;

public sealed class FrenchInvoice(IEnumerable<Item> items) : AInvoice(items, 1.2m)
{ }
