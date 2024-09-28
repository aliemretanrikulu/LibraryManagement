
namespace LibraryManagement.ConsoleUI.Models.DTO;

public record BookDetailDto
(
        Guid Id,
        string CategoryName,
        string AuthorName,
        string Title,
        string Description,
        int PageSize,
        string PublishDate,
        string ISBN
);
