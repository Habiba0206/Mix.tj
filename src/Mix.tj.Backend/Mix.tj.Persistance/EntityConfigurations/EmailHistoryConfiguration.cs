using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mix.tj.Domain.Entities.Notification;

namespace Mix.tj.Persistance.EntityConfigurations;

public class EmailHistoryConfiguration : IEntityTypeConfiguration<EmailHistory>
{
    public void Configure(EntityTypeBuilder<EmailHistory> builder)
    {
        builder.Property(template => template.SenderEmailAddress).IsRequired().HasMaxLength(256);
        builder.Property(template => template.ReceiverEmailAddress).IsRequired().HasMaxLength(256);
        builder.Property(template => template.Subject).IsRequired().HasMaxLength(256);
    }
}