using Microsoft.EntityFrameworkCore;

namespace Joben_DAL.Repositories.GenericRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Variables
        private readonly JobenDbContext _dbContext;
        #endregion

        #region Constructor
        public Repository(JobenDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Methods
        public async Task<T> Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);

            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);

            if(entity is not null)
                _dbContext.Set<T>().Remove(entity);
        }

        public async Task<T?> Get(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>?> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            _dbContext.Set<T>().Entry(entity).State = EntityState.Modified;

            return await Task.FromResult(entity);
        }
        #endregion
    }
}
