namespace MyApplication.Entities;

public class Festival
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    
    public int Price { get; set; }
    public DateTime? StartDate { get; set; } 
    public DateTime? EndDate { get; set; }
    
    public string? URl { get; set; }
    public string? PublicId { get; set; }
    
    public ICollection<BandFestival> BandFestivals { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}