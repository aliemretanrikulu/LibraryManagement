using LibraryManagement.ConsoleUI.Models;
using TodoList2.Repository;

namespace LibraryManagement.ConsoleUI.Repository;

public interface ICategoryRepository : IRepository<Category, int>
{

}