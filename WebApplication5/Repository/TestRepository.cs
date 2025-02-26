using Microsoft.EntityFrameworkCore;
using MyProject.Infrastructure.Model;
using WebApplication5;
using WebApplication5.DTO;

public class TestRepository : ITestRepository
{
    private readonly AppDb _context;

    public TestRepository(AppDb context)
    {
        _context = context;
    }

    public async Task<Test?> CreateAsync(Test? item)
    {
        _context.TestItems.Add(item);       // E.g. DbSet<TestItem> in AppDbContext
        await _context.SaveChangesAsync();
        return item;
    }

    public async Task<Test?> GetByIdAsync(int id)
    {
        return await _context.TestItems
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task DeleteAsync(Test? item)
    {
        _context.TestItems.Remove(item);
        await _context.SaveChangesAsync();
    }
}