using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public interface IReadRepository<out TEntity> where TEntity : class, IEntity // Kowariancja (out) - konwersja z typu bardziej precyzyjnego do bardziej ogólnego
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
