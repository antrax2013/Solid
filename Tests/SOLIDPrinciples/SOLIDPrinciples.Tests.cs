using NFluent;
using Sdk;

namespace SOLIDPrinciples.Tests;

public class SOLIDTests
{
    private readonly FrenchCategoryMapper frMapper = new();
    private readonly ItalianCategoryMapper itMapper = new();
    private readonly MonatanaCategoryMapper mtMapper = new();

    [Test]
    public void Quand_Je_Caclue_Le_Total_D_une_Facture_Francaise_Alors_J_Obtiens_Le_Montant_Attendu()
    {
        // Given
        List<Item> items = [
            new("Chaussure", 100, ItemType.Good),
            new("Livraison", 10, ItemType.Service)
        ];
        Invoice invoice = new(items, frMapper);

        // When
        decimal total = invoice.GetTaxedTotal();

        // Then
        Check.That(total).IsEqualTo(132);
    }

    [Test]
    public void Quand_Je_Caclue_Le_Total_D_une_Facture_Italienne_Alors_J_Obtiens_Le_Montant_Attendu()
    {
        // Given
        List<Item> items = [
            new("Chaussure", 100, ItemType.Good),
            new("Livraison", 10, ItemType.Service)
        ];
        Invoice invoice = new(items, itMapper);

        // When
        decimal total = invoice.GetTaxedTotal();

        // Then
        Check.That(total).IsEqualTo(134.2m);
    }

    [Test]
    public void Quand_Je_Caclue_Le_Total_D_une_Facture_Du_Montana_Alors_J_Obtiens_Le_Montant_Attendu()
    {
        // Given
        List<Item> items = [
            new("Chaussure", 100, ItemType.Good),
            new("Livraison", 10, ItemType.Service)
        ];
        Invoice invoice = new(items, mtMapper);

        // When
        decimal total = invoice.GetTaxedTotal();

        // Then
        Check.That(total).IsEqualTo(110m);
    }

    [Test]
    public void Quand_Je_Calcule_Mon_Chiffre_D_Affaire_Alors_J_Obtiens_Le_Resultat_Attendu()
    {
        // Given
        Sales sales = new([
            new Invoice([
                new("Chaussure", 100, ItemType.Good),
                new("Livraison", 10, ItemType.Service),
            ], frMapper),
            new Invoice([
                new("Chaussure", 100, ItemType.Good),
                new("Livraison", 10, ItemType.Service)
            ], itMapper),
        ]);

        // When
        decimal total = sales.GetTaxedSales();

        // Then
        Check.That(total).IsEqualTo(266.2m);
    }
}
