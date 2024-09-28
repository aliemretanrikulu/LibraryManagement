
using LibraryManagement.ConsoleUI.Models;

namespace TodoList2.Repository;

public interface IRepository<TEntity, TId>
    where TEntity : Entity<TId>, new()
{
    List<TEntity> GetAll();
    TEntity? GetById(TId id);
    TEntity Add(TEntity item);

    TEntity Remove(TId id);
}