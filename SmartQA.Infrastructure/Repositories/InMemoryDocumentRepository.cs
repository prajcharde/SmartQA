using SmartQA.Domain.Entities;
using SmartQA.Application.Interfaces;

namespace SmartQA.Infrastructure.Repositories;

public class InMemoryDocumentRepository : IDocumentRepository
{
    private readonly List<Document> _documents = new();

    public Task AddAsync(Document document)
    {
        _documents.Add(document);
        return Task.CompletedTask;
    }

    public Task<Document?> GetByIdAsync(Guid id)
    {
        var doc = _documents.FirstOrDefault(d => d.Id == id);
        return Task.FromResult(doc);
    }

    public Task<List<Document>> GetAllAsync()
    {
        return Task.FromResult(_documents.ToList());
    }
}