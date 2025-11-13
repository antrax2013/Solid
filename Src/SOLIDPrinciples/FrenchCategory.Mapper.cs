using Sdk;

namespace SOLIDPrinciples
{
    public sealed class FrenchCategoryMapper : ICategoryMapper
    {
        public decimal GetTaxeRate(Category? category)
        {
            return category switch
            {
                Category.Food => 1.05m,
                _ => 1.2m
            };
        }
    }
}
