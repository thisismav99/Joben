using Joben_DAL.Models.USER.MISC;
using Microsoft.EntityFrameworkCore;

namespace Joben_DAL.Seeds
{
    public static class UserSeeds
    {
        public static void UserDbSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CivilStatusModel>().HasData(
                new CivilStatusModel()
                {
                    ID = 1,
                    CivilStatus = "SINGLE",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new CivilStatusModel()
                {
                    ID = 2,
                    CivilStatus = "MARRIED",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new CivilStatusModel()
                {
                    ID = 3,
                    CivilStatus = "ANNULLED",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new CivilStatusModel()
                {
                    ID = 4,
                    CivilStatus = "DIVORCED",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                }
            );

            modelBuilder.Entity<GenderModel>().HasData(
                new GenderModel()
                {
                    ID = 1,
                    Gender = "MALE",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new GenderModel()
                {
                    ID = 2,
                    Gender = "FEMALE",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new GenderModel()
                {
                    ID = 3,
                    Gender = "GAY",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new GenderModel()
                {
                    ID = 4,
                    Gender = "LESBIAN",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                }
            );

            modelBuilder.Entity<PositionModel>().HasData(
                new PositionModel()
                {
                    ID = 1,
                    Position = "RIDER",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new PositionModel()
                {
                    ID = 2,
                    Position = "DRIVER",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new PositionModel()
                {
                    ID = 3,
                    Position = "HOUSEKEEPER",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new PositionModel()
                {
                    ID = 4,
                    Position = "COOK",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new PositionModel()
                {
                    ID = 5,
                    Position = "GARDENER",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new PositionModel()
                {
                    ID = 6,
                    Position = "BABY SITTER",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new PositionModel()
                {
                    ID = 7,
                    Position = "DELIVERY MAN",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                },
                new PositionModel()
                {
                    ID = 8,
                    Position = "LAUNDRY",
                    IsActive = true,
                    CreatedOn = DateTime.UtcNow,
                    CreatedBy = "SEEDER"
                }
            );
        }
    }
}
