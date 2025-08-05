namespace Mix.tj.Application.Likes.Models;

public class LikeDto
{
    public Guid? Id { get; set; }
    public Guid UserId { get; set; }
    public string Text { get; set; }
    public string Reply { get; set; }
}
