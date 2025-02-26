using Microsoft.EntityFrameworkCore;
using MyProject.Infrastructure.Model;

namespace WebApplication5;

public class AppDb : DbContext
{
    // Pass DbContextOptions to the base constructor
    public AppDb(DbContextOptions<AppDb> options) : base(options)
    {
    }

    public DbSet<Test> TestItems { get; set; }
}