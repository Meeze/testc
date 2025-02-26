using MyProject.Infrastructure.Model;

public interface ITestService
{
    Task<int> CreateAsync(string name);
    Task<Test> GetAsync(int id);
    Task<bool> DeleteAsync(int id);
}