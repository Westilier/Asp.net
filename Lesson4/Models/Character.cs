namespace Lesson3.Models;

public class Character
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Book { get; set; }
    public required string Author { get; set; }
    public required RoleType Role { get; set; }
    public required string Description { get; set; }
    public enum RoleType
    {
        Main,
        Secondary,
        Antagonist
    }
}

