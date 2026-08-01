using SmartQA.Domain.Entities;
using SmartQA.Application.Interfaces;

namespace SmartQA.Application.Features;

public class UploadDocumentHandler
{
    private readonly IDocumentRepository _repository;

    public UploadDocumentHandler(IDocumentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> HandleAsync(string fileName, string content)
    {
        var document = new Document(fileName, content);
        await _repository.AddAsync(document);
        return document.Id;
    }
}