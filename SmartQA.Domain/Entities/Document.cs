namespace SmartQA.Domain.Entities;

public class Document
{
    // Nothing outside this class can directly mutate FileName or Content after creation. Changes have to go through explicit methods
    public Guid Id { get; private set; } 
    public string FileName { get; private set; }
    public string Content { get; private set; }
    public DateTime UploadedAt { get; private set; }

    private Document() { } // for EF Core later

    // Constructor requires these 2 properties to create  
    public Document(string fileName, string content)
    {
        Id = Guid.NewGuid();
        FileName = fileName;
        Content = content;
        UploadedAt = DateTime.UtcNow;
    }
}