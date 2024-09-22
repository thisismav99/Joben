using Joben_DAL.Models.RATING;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Joben_DAL.ModelMappings.RATING
{
    public class RatingModelMapping : IEntityTypeConfiguration<RatingModel>
    {
        public void Configure(EntityTypeBuilder<RatingModel> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.Remark).HasMaxLength(2000);
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.UpdatedBy);
            builder.Property(x => x.UpdatedOn);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();

            builder.HasOne(x => x.User).WithMany().HasForeignKey(f => f.UserID).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Ratings");
        }
    }
}
