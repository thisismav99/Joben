
using Microsoft.EntityFrameworkCore.Storage;

namespace Joben_DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables
        private readonly JobenDbContext _dbContext;
        private IDbContextTransaction? _dbTransaction;
        #endregion

        #region Constructor
        public UnitOfWork(JobenDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Methods
        public async Task BeginTransaction()
        {
            _dbTransaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransaction()
        {
            if(_dbTransaction is not null)
            {
                await _dbTransaction.CommitAsync();
                _dbTransaction.Dispose();
            }
        }

        public void Dispose()
        {
            _dbTransaction?.Dispose();
            _dbContext.Dispose();
        }

        public async Task RollbackTransaction()
        {
            if(_dbTransaction is not null)
            {
                await _dbTransaction.RollbackAsync();
                _dbTransaction.Dispose();
            }
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
