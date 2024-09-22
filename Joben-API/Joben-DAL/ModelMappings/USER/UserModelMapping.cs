using Joben_DAL.Models.USER;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Joben_DAL.ModelMappings.USER
{
    public class UserModelMapping : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.MiddleName).HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(30);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(30);
            builder.Property(x => x.GenderID).IsRequired();
            builder.Property(x => x.CivilStatusID).IsRequired();
            builder.Property(x => x.PositionID).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.UpdatedBy);
            builder.Property(x => x.UpdatedOn);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();

            builder.HasOne(x => x.Gender).WithMany().HasForeignKey(f => f.GenderID);
            builder.HasOne(x => x.CivilStatus).WithMany().HasForeignKey(f => f.CivilStatusID);
            builder.HasOne(x => x.Position).WithMany().HasForeignKey(f => f.PositionID);

            builder.ToTable("Users");
        }
    }
}
