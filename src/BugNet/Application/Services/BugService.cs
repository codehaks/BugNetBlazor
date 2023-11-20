using BugNet.Application.Contracts;
using BugNet.Infrastructure.Data;
using BugNet.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BugNet.Application.Services;

public class BugService : IBugService
{
    private readonly BugDbContext _db;

    public BugService(BugDbContext db)
    {
        _db = db;
    }

    public async Task<IList<Bug>> GetAllAsync()
    {
        await Task.Delay(1000);
        return await _db.Bugs.ToListAsync();
    }

    public async Task<IList<Bug>> FilterAsync(string term)
    {
        await Task.Delay(1000);
        var result = _db.Bugs.Where(b => b.Name.Contains(term));
        return await result.ToListAsync();
    }

    public async Task CreateAync(Bug bug)
    {
        _db.Bugs.Add(bug);
        await _db.SaveChangesAsync();
    }

    public async Task<Bug?> FindByIdAsync(int id)
    {
        return await _db.Bugs.FindAsync(id);
    }

    public async Task UpdateAsync(Bug bug)
    {
        _db.Attach(bug!).State = EntityState.Modified;

        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var bug = await _db.Bugs.FindAsync(id);
        if (bug is not null)
        {

            _db.Bugs.Remove(bug);
            await _db.SaveChangesAsync();
        }
    }
}
