namespace TaskTracker.Application.Dto;

public record CreateTaskDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public required IEnumerable<TagDto> Tags { get; set; }
}
