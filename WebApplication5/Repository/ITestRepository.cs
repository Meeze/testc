using MyProject.Infrastructure.Model;

public interface ITestRepository
{
    Task<Test> CreateAsync(Test item);
    Task<Test> GetByIdAsync(int id);
    Task DeleteAsync(Test item);
}