using Library.Domain.Book.Aggregate;
using Library.Domain.Book.Value_Object;
using Library.Domain.Common.Transaction.Aggregate;
using Library.Domain.LibrarianPanel.Value_Object;
using Library.Domain.Patrion.Aggregate;
using Microsoft.EntityFrameworkCore;
namespace Library.Infrastructure.Persistence;

public class LibraryDbContext : DbContext 
{
   public DbSet<Book> Books { get; set; }
   public DbSet<Patrion> Patrions { get; set; }
   public DbSet<Appeal> Appeals { get; set; }

   public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
   {
       
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfigurationsFromAssembly
         (typeof(LibraryDbContext).Assembly);
   }
}