namespace Lesson2.Models;

public class Product
{
    public required string Name { get; set; }
    public required int Price { get; set; }
    public required string Category { get; set; }
    public required bool IsOnStorage { get; set; }
    public bool IsDiscount { get; set; } = false;
}
