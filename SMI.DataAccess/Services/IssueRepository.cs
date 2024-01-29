using MongoDB.Driver;
using SMI.DataAccess.Models;
using SMI.DataAccess.Services.Interfaces;

namespace SMI.DataAccess.Services;

public class IssueRepository : IIssueRepository
{
    private readonly IMongoCollection<Issue> _issueCollection;
    public IssueRepository(IMongoDatabase db)
    {
        var collectionName = "Issues";
        _issueCollection = db.GetCollection<Issue>(collectionName);

    }

    public async Task AddAsync(Issue entity)
    {
        await _issueCollection.InsertOneAsync(entity);
    }

    public async Task DeleteAsync(string id)
    {
        await _issueCollection.DeleteOneAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Issue>> GetAllAsync()
    {
        return await _issueCollection.Find(x => true).ToListAsync();
    }

    public async Task<Issue> GetByIdAsync(string id)
    {
        return await _issueCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(Issue entity)
    {
        await _issueCollection.ReplaceOneAsync(x => x.Id == entity.Id, entity);
    }
}
