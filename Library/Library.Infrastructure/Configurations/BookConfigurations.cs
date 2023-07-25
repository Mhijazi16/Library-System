using Library.Domain.Book.Aggregate;
using Library.Domain.Common.Transaction.Aggregate;
using Library.Domain.Patrion.Aggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Configurations;

public class BookConfigurations : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        ConfigureTable(builder);
        ConfigureReviews(builder);
        ConfigureTransactions(builder);
    }

    private void ConfigureTransactions(EntityTypeBuilder<Book> builder)
    {
        builder.HasMany(book => book.BookTransactions)
            .WithOne()
            .HasForeignKey(tr => tr.BookId);
    }

    private void ConfigureReviews(EntityTypeBuilder<Book> builder)
    {
        builder.OwnsMany(book => book.BookReviews, sp =>
        {
            sp.Property(a => a.Rating).HasPrecision(3, 1);
            sp.Property(a => a.Descriptoin).HasMaxLength(500);
        });
    }

    private void ConfigureTable(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books")
            .HasKey(book => book.Id);
        builder.Property(book => book.Id)
            .ValueGeneratedNever();
        builder.Property(book => book.Title)
            .HasMaxLength(100);
        builder.Property(book => book.Description)
           .HasMaxLength(500);
        builder.Property(book => book.Genre)
            .HasConversion<string>();
        builder.Property(book => book.Status)
            .HasConversion<string>();
    }
}