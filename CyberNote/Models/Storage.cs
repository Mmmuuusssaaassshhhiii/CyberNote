namespace CyberNote.Models;

public class Storage
{
    public int Id { get; set; }
    public string Type { get; set; }
    public int SizeGB { get; set; }
    
    public ICollection<Laptop> Laptops { get; set; }
}