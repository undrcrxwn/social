using System.ComponentModel.DataAnnotations;

namespace CrowdParlay.Social.Domain.Entities;

public class Discussion
{
    public int Id { get; set; }
    public List<Post> Posts { get; set; } = new();
    public string Title { get; set; } = default!;
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
}