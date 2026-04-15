namespace Lesson3.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Book { get; set; }
    public string Author { get; set; }
    public RoleType Role { get; set; }
    public string Description { get; set; }
    public enum RoleType
    {
        Main,
        Secondary,
        Antagonist
    }
}

