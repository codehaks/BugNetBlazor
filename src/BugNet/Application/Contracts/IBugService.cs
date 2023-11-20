using BugNet.Infrastructure.Models;

namespace BugNet.Application.Contracts;

public interface IBugService
{
    Task CreateAync(Bug bug);

    Task<IList<Bug>> FilterAsync(string term);

    Task<Bug?> FindByIdAsync(int id);

    Task UpdateAsync(Bug bug);

    Task DeleteAsync(int id);
    Task<IList<Bug>> GetAllAsync();
}