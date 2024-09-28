namespace LibraryManagement.ConsoleUI.Models;

public class Category : Entity<int>
{
    public Category()
    {

    }

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }


    public override string ToString()
    {
        return $"Id : {Id}, Name: {Name}";
    }

    public record Book
    (
        int Id,
        int CategotyId,
        int AuthorId,
        string AuthorName,
        string Title,
        string Description,
        int PageSize,
        string PublishDate,
        string ISBN

    );
}