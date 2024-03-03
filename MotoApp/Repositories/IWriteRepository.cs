using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public interface IWriteRepository<in  TEntity> where TEntity : class, IEntity // Kontrawariancja (in) - konwersja z typu bardziej ogólnego do bardziej precyzyjnego
    {
        void Add(TEntity item);
        void Remove(TEntity item);
        void Save();
    }
}
