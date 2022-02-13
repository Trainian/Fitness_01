using Fitness.Entityes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<BlogEntity> BlogEntities {get;set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
