using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCO.Domain.Entities;
namespace PCO.Data.EntitiesConfiguration
{
    public class MinistryUserConfiguration : IEntityTypeConfiguration<MinistryUser>
    {
        public void Configure(EntityTypeBuilder<MinistryUser> builder)
        {
            builder.HasKey(mu => new { mu.UserId, mu.MinistryId });

            builder.HasOne(m => m.Ministry)
                   .WithMany(m => m.MinistriesUsers)
                   .HasForeignKey(m => m.MinistryId);
            
            builder.HasOne(u => u.User)
                   .WithMany(u => u.MinistriesUsers)
                   .HasForeignKey(u => u.UserId);
        }
    }
}
