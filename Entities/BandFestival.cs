using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApplication.Entities;

public class BandFestival
{
    public Guid FestivalId { get; set; }
    public Festival Festival { get; set; }
    
    public Guid BandId { get; set; }
    public Band Band { get; set; }
    
    public int Order { get; set; }
}