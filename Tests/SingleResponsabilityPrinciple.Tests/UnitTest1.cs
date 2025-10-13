using NFluent;
using Sdk;

namespace SingleResponsabilityPrinciple.Tests
{
    public class Tests
    {
        [Test]
        public async Task Quand_Je_Sauvegarde_Et_Recharge_Un_Livre_Depuis_Un_Fichier_Alors_Ses_Proprietes_Sont_Identiques()
        {
            //Given 
            Book book = new("Mon titre", "John Doe", "978-2290415634", 448, new DateTime(2025, 10, 11));

            //When
            Result saveOperation = await book.SaveToFile("./");
            Check.That(saveOperation.IsSuccess).IsTrue();

            Result<Book> readOperation = await book.LoadFromFile("./");
            Check.That(readOperation.IsSuccess).IsTrue();
            Check.That(readOperation.Value).HasFieldsWithSameValues(book);
        }
    }
}
