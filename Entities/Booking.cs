namespace MyApplication.Entities;

public class Booking
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public int FestivalId { get; set; }
    public Festival Festival { get; set; }
    
}