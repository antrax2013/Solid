using Sdk;

namespace SOLIDPrinciples
{
    public sealed class ItalianCategoryMapper : ICategoryMapper
    {
        public decimal GetTaxeRate(Category? category) => 1.22m;
    }
}
