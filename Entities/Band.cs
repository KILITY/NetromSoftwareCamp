namespace MyApplication.Entities;

public class Band
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<BandMember> BandMembers { get; set; }
    public ICollection<Festival> Festivals { get; set; }
}