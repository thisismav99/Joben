namespace Joben_DAL.Repositories.GenericRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(int id);
        Task<T?> Get(int id);
        Task<List<T>?> GetAll();
    }
}
