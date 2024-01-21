namespace Entities;

public class BaseEntity 
{
    public Guid Id { get; set; }
    public DateTime CreateDate { get; set; }
    public int CreatedUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
}