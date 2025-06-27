using System.ComponentModel.DataAnnotations;

namespace MyApplication.Entities;

public class BandMember
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int Band_Id { get; set; }
    public Band Band { get; set; }
}