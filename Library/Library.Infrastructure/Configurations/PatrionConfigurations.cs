using Library.Domain.Patrion.Aggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Configurations;

public class PatrionConfigurations : IEntityTypeConfiguration<Patrion>
{
    public void Configure(EntityTypeBuilder<Patrion> builder)
    {
        ConfigureTable(builder);
        ConfigureBorrowedBooks(builder);
        ConfigureTransactions(builder);
    }

    private void ConfigureTransactions(EntityTypeBuilder<Patrion> builder)
    {
        builder.HasMany(patrion => patrion.TransactionHistory)
            .WithOne(tr => tr.Patrion)
            .HasForeignKey(tr => tr.PatrionId);
    }

    private void ConfigureBorrowedBooks(EntityTypeBuilder<Patrion> builder)
    {
        builder.OwnsMany(patrion => patrion.BookSet, sp =>
        {
            sp.ToTable("BorrowedBook").HasKey(a => a.Id);
            sp.Property(a => a.Id).ValueGeneratedNever();
            sp.Property(a => a.Description).HasMaxLength(500);
            sp.Property(a => a.Title).HasMaxLength(50);
        });
    }

    private void ConfigureTable(EntityTypeBuilder<Patrion> builder)
    {
        builder.ToTable("Patrion")
            .HasKey(patrion => patrion.Id);
        builder.Property(patrion => patrion.Id)
            .ValueGeneratedNever();
        
        builder.HasIndex(patrion => patrion.Email)
            .IsUnique();
        builder.Property(patrion => patrion.FirstName)
            .HasMaxLength(50);
        builder.Property(patrion => patrion.LastName)
            .HasMaxLength(50);
        builder.Property(patrion => patrion.Email)
            .HasMaxLength(100);
    }
}