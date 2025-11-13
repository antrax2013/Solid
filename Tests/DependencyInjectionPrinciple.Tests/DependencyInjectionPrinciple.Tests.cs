using NFluent;
using Sdk;

namespace DependencyInjectionPrinciple.Tests
{
    public class DIPTests
    {
        [Test]
        public void Quand_Je_Caclue_Le_Total_D_une_Facture_Francaise_Alors_J_Obtiens_Le_Montant_Attendu()
        {
            // Given
            List<Item> items = [
                new("Chaussure", 100, ItemType.Good),
                new("Livraison", 10, ItemType.Service)
            ];
            Invoice invoice = new FrenchInvoiceFactory(items).GetInstance();

            // When
            decimal taxedTotal = invoice.GetTotal();

            // Then
            Check.That(taxedTotal).IsEqualTo(132);
        }

        [Test]
        public void Quand_Je_Caclue_Le_Total_D_une_Facture_Italienne_Alors_J_Obtiens_Le_Montant_Attendu()
        {
            // Given
            List<Item> items = [
                new("Chaussure", 100, ItemType.Good),
                new("Livraison", 10, ItemType.Service)
            ];
            Invoice invoice = new ItalianInvoiceFactory(items).GetInstance();

            // When
            decimal taxedTotal = invoice.GetTotal();

            // Then
            Check.That(taxedTotal).IsEqualTo(134.2m);
        }

        [Test]
        public void Quand_Je_Caclue_Le_Total_D_une_Facture_Du_Montana_Alors_J_Obtiens_Le_Montant_Attendu()
        {
            // Given
            List<Item> items = [
                new("Chaussure", 100, ItemType.Good),
                new("Livraison", 10, ItemType.Service)
            ];
            Invoice invoice = new MontanaInvoiceFactory(items).GetInstance();

            // When
            decimal taxedTotal = invoice.GetTotal();

            // Then
            Check.That(taxedTotal).IsEqualTo(110m);
        }

        [Test]
        public void Quand_Je_Calcule_Mon_Chiffre_D_Affaire_Alors_J_Obtiens_Le_Resultat_Attendu()
        {
            // Given
            Sales sales = new([
                new FrenchInvoiceFactory([
                    new("Chaussure", 100, ItemType.Good),
                    new("Livraison", 10, ItemType.Service)
                ]).GetInstance(),
                new ItalianInvoiceFactory([
                    new("Chaussure", 100, ItemType.Good),
                    new("Livraison", 10, ItemType.Service)
                ]).GetInstance()
            ]);

            // When
            decimal taxedTotal = sales.GetTaxedSales();

            // Then
            Check.That(taxedTotal).IsEqualTo(266.2m);
        }
    }
}
