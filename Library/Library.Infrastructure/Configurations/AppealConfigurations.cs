using Library.Domain.Book.Aggregate;
using Library.Domain.LibrarianPanel.Value_Object;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Configurations;

public class AppealConfigurations : IEntityTypeConfiguration<Appeal>
{
    public void Configure(EntityTypeBuilder<Appeal> builder)
    {
        builder.ToTable("Appeals")
            .HasKey(appeal => appeal.Id);

        builder.HasOne(appeal => appeal.Book)
            .WithOne().HasForeignKey<Appeal>(appeal => appeal.BookId);

        builder.HasOne(appeal => appeal.Patrion)
            .WithOne().HasForeignKey<Appeal>(appeal => appeal.PatrionId);
    }
}