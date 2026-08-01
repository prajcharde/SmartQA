using SmartQA.Domain.Entities;

namespace SmartQA.Application.Interfaces;

public interface IDocumentRepository
{
    Task AddAsync(Document document);
    Task<Document?> GetByIdAsync(Guid id);
    Task<List<Document>> GetAllAsync();
}