using Sdk;
using System.Text.Json;

namespace SingleResponsabilityPrinciple;

public sealed class BookRepository(string rootPath)
{
    public string RootPath { get; } = rootPath;
    public async Task<Result> SaveToFile(Book book)
    {
        try
        {
            await File.WriteAllTextAsync(Path.Combine(RootPath, $"{book.Title}.json"), JsonSerializer.Serialize(book));
            return Result.Ok();
        }
        catch (Exception e)
        {
            return Result.Fail(e.Message);
        }
    }

    public async Task<Result<Book>> LoadFromFile(Book book)
    {
        try
        {
            string buffer = await File.ReadAllTextAsync(Path.Combine(RootPath, $"{book.Title}.json"));
            return Result<Book>.Ok(JsonSerializer.Deserialize<Book>(buffer) ?? throw new Exception("The buffer not contains a book."));
        }
        catch (Exception e)
        {
            return Result<Book>.Fail(e.Message);
        }
    }
}
