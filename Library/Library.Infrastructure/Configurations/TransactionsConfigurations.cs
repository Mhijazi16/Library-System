using Library.Domain.Common.Transaction.Aggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Configurations;

public class TransactionsConfigurations : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transactions").HasKey(tr => tr.Id);
        
        builder.Property(tr => tr.Id).ValueGeneratedNever();
        
        builder.Property(tr => tr.Status).HasConversion<string>();
        
        builder.OwnsOne(tr => tr.Span, sp =>
        {
            sp.Property(a => a.DueDate).HasColumnName("Due Date");
            sp.Property(a => a.IssueDate).HasColumnName("Issue Date");
        });
    }
}