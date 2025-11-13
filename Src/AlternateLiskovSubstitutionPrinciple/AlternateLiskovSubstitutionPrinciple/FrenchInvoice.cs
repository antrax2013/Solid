using Sdk;

namespace AlternateLiskovSubstitutionPrinciple;

public sealed class FrenchInvoice(IEnumerable<Item> items) : ATaxedInvoice(items, 1.2m)
{ }
