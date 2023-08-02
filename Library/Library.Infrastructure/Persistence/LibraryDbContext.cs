using Library.Domain.Book.Aggregate;
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
   public DbSet<Transaction> Transactions { get; set; }
   
   public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
   {
      
   }

   public LibraryDbContext()
   {
   }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer(
         "Server=localhost; Database=Library; User=sa; Password=Hijazi123; TrustServerCertificate=True"); 

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfigurationsFromAssembly
         (typeof(LibraryDbContext).Assembly);
   }
}