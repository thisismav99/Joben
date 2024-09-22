using Joben_DAL.Models.USER;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Joben_DAL.ModelMappings.USER
{
    public class AddressModelMapping : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Street).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Barangay).IsRequired().HasMaxLength(100);
            builder.Property(x => x.City).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Region).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PostalCode).HasMaxLength(10);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(100);
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.UpdatedBy);
            builder.Property(x => x.UpdatedOn);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();

            builder.HasOne(x => x.User).WithMany().HasForeignKey(f => f.UserID).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Address");
        }
    }
}
