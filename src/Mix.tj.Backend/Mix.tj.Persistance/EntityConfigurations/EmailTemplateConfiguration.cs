using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mix.tj.Domain.Entities.Notification;

namespace Mix.tj.Persistance.EntityConfigurations;

public class EmailTemplateConfiguration : IEntityTypeConfiguration<EmailTemplate>
{
    public void Configure(EntityTypeBuilder<EmailTemplate> builder)
    {
        builder.Property(template => template.Subject).IsRequired().HasMaxLength(256);
    }
}