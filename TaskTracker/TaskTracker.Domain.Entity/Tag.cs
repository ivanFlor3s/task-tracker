namespace TaskTracker.Domain;

public class Tag
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string HexColor { get; set; }
}