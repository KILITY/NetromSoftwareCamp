using MyApplication.Enums;

namespace MyApplication.Entities;

public class Band
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Genre Genre { get; set; }

    public ICollection<Festival> Festivals { get; set; } = [];
}

