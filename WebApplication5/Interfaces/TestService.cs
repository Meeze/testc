using MyProject.Infrastructure.Model;

public class TestService : ITestService
{
    private readonly ITestRepository _testRepository;

    public TestService(ITestRepository testRepository)
    {
        _testRepository = testRepository;
    }

    // CREATE
    public async Task<int> CreateAsync(string name)
    {
        var newItem = new Test { Name = name };
        var created = await _testRepository.CreateAsync(newItem);
        return created.Id;
    }

    // GET
    public async Task<Test> GetAsync(int id)
    {
        var item = await _testRepository.GetByIdAsync(id);
        return item; // null if not found
    }

    // DELETE
    public async Task<bool> DeleteAsync(int id)
    {
        // Look up the item
        var existing = await _testRepository.GetByIdAsync(id);
        if (existing == null) return false;

        // Remove it
        await _testRepository.DeleteAsync(existing);
        return true;
    }
}