namespace MyApplication.Entities;

public class Booking
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public int FestivalId { get; set; }
    public Festival Festival { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}