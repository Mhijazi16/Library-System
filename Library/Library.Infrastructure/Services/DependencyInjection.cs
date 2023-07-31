using Library.Application.Interfaces;
using Library.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Infrastructure.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence
        (this IServiceCollection services)
    {
        services.AddDbContext<LibraryDbContext>(options => 
            options.UseSqlServer("Server=localhost; Database=Library; User=sa; Password=Hijazi123; TrustServerCertificate=True"));

        services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        
        return services;
    }
}