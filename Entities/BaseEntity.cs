namespace Entities;

public class BaseEntity 
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreateDate { get; set; } = new DateTime();
    public DateTime? UpdateDate { get; set; } = null;
}