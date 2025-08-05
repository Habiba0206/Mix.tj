using Mix.tj.Domain.Enums;

namespace Mix.tj.Application.NewsEntities.Models;

public class NewsDto
{
    public Guid? Id { get; set; }
    public Guid UserId { get; set; }
    public string Headline { get; set; } = default!;
    public string Content { get; set; } = default!;
    public Category Category { get; set; }
    public IEnumerable<string> Tags { get; set; }
}
