
namespace BookClub.Repository;

public interface IRepository<T>
{
    public T InsertEntity(T entity);
    public T? DeleteEntity(Guid id);
    public T? GetEntity(Guid id);
    public T? EditEntity(T entity);
}
