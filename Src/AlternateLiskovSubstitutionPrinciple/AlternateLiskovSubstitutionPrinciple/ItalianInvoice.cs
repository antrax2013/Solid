using Sdk;

namespace AlternateLiskovSubstitutionPrinciple;

public sealed class ItalianInvoice(IEnumerable<Item> items) : ATaxedInvoice(items, 1.22m)
{ }
