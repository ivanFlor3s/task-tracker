namespace TaskTracker.Domain;

public class TaskItem
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public ICollection<Tag>? Tags { get; set; }
}
    