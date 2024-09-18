namespace Joben_DAL.Repositories.GenericRepository
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        void Update(T entity);
        Task Delete(int id);
        Task<T?> Get(int id);
        Task<List<T>?> GetAll();
    }
}
