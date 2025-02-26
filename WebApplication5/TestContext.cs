using Microsoft.EntityFrameworkCore;
using MyProject.Infrastructure.Model;

namespace MyProject.Api;

public class TestDb : DbContext
{
    public TestDb(DbContextOptions<TestDb> options) : base(options)
    {
    }

    public DbSet<Test> Todos { get; set; }
}