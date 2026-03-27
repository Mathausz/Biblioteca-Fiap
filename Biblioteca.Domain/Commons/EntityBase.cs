using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Domain.Commons;

public class EntityBase
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    protected virtual void OnModelCreating(ModelBuilder modelBuilder)
    {
        throw new NotImplementedException();
    }
}
