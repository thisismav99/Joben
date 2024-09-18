using Joben_DAL.Models.USER.MISC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Joben_DAL.ModelMappings.USER.MISC
{
    public class PositionModelMapping : IEntityTypeConfiguration<PositionModel>
    {
        public void Configure(EntityTypeBuilder<PositionModel> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Position).IsRequired().HasMaxLength(30);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.UpdatedBy);
            builder.Property(x => x.UpdatedOn);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();

            builder.ToTable("Position");
        }
    }
}
