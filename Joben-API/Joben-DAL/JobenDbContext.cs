using Joben_DAL.ModelMappings.USER;
using Joben_DAL.ModelMappings.USER.MISC;
using Joben_DAL.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Joben_DAL
{
    public class JobenDbContext : DbContext
    {
        #region Constructor
        public JobenDbContext(DbContextOptions<JobenDbContext> options) : base(options)
        {
            
        }
        #endregion

        #region Method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserModelMapping());
            modelBuilder.ApplyConfiguration(new AddressModelMapping());
            modelBuilder.ApplyConfiguration(new RatingModelMapping());
            modelBuilder.ApplyConfiguration(new GenderModelMapping());
            modelBuilder.ApplyConfiguration(new CivilStatusModelMapping());
            modelBuilder.ApplyConfiguration(new PositionModelMapping());

            UserSeeds.UserDbSeed(modelBuilder);
        }
        #endregion
    }
}
