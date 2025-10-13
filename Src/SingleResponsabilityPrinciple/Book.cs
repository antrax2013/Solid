using Sdk;
using System.Text.Json;

namespace SingleResponsabilityPrinciple;

public sealed class Book(string title, string author, string isbn, int pages, DateTime publicationDate)
{
    public string Title { get; } = title;
    public string Author { get; } = author;
    public string Isbn { get; } = isbn;
    public int Pages { get; } = pages;
    public DateTime PublicationDate { get; } = publicationDate;

    public async Task<Result> SaveToFile(string rootPath)
    {
        try
        {
            await File.WriteAllTextAsync(Path.Combine(rootPath, $"{this.Title}.json"), JsonSerializer.Serialize(this));
            return Result.Ok();
        }
        catch (Exception e)
        {
            return Result.Fail(e.Message);
        }
    }

    public async Task<Result<Book>> LoadFromFile(string rootPath)
    {
        try
        {
            string buffer = await File.ReadAllTextAsync(Path.Combine(rootPath, $"{this.Title}.json"));
            return Result<Book>.Ok(JsonSerializer.Deserialize<Book>(buffer) ?? throw new Exception("The buffer not contains a book."));
        }
        catch (Exception e)
        {
            return Result<Book>.Fail(e.Message);
        }
    }
}
