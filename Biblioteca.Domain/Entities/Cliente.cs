using Biblioteca.Domain.Commons;

namespace Biblioteca.Domain.Entities;

public class Cliente : EntityBase
{
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty; 
    public string? Telefone { get; set; }          
    public string? Email { get; set; }
    
    // (1,n)
    public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}