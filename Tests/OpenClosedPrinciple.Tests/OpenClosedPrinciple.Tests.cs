using NFluent;
using Sdk;

namespace OpenClosedPrinciple.Tests;

public sealed class OCPTests
{
    [Test]
    public void Quand_Je_Caclue_Le_Total_D_une_Facture_Francaise_Alors_J_Obtiens_Le_Montant_Attendu()
    {
        // Given
        List<Item> items = [
            new("Chaussure", 100, ItemType.Good),
            new("Livraison", 10, ItemType.Service)
        ];
        FrenchInvoice invoice = new(items);

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
        ItalianInvoice invoice = new(items);

        // When
        decimal total = invoice.GetTaxedTotal();

        // Then
        Check.That(total).IsEqualTo(134.2m);
    }

    [Test]
    public void Quand_Je_Calcule_Mon_Chiffre_D_Affaire_Alors_J_Obtiens_Le_Resultat_Attendu()
    {
        // Given
        Sales sales = new([
            new FrenchInvoice([
                new("Chaussure", 100, ItemType.Good),
            new("Livraison", 10, ItemType.Service)
            ]),
            new ItalianInvoice([
                new("Chaussure", 100, ItemType.Good),
            new("Livraison", 10, ItemType.Service)
            ]),
        ]);

        // When
        decimal total = sales.GetTaxedSales();

        // Then
        Check.That(total).IsEqualTo(266.2m);
    }
}
