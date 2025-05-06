namespace CyberNote.Models;

public class OS
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Laptop> Laptops { get; set; }
}