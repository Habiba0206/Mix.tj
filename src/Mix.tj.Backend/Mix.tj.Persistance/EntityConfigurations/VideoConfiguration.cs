using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mix.tj.Domain.Entities.Infrastructure;

namespace Mix.tj.Persistance.EntityConfigurations;

public class VideoConfiguration : IEntityTypeConfiguration<Video>
{
    public void Configure(EntityTypeBuilder<Video> builder)
    {
        builder
            .Property(v => v.Title)
            .IsRequired();

        builder
            .Property(v => v.Description)
            .HasMaxLength(200)
            .IsRequired();

        builder
            .Property(v => v.Url)
            .IsRequired();

        builder
            .Property(v => v.VideoType)
            .IsRequired();

        builder.HasOne(b => b.User)
            .WithMany()
            .HasForeignKey(b => b.UserId);
    }
}
