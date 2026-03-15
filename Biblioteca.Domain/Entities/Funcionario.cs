using Biblioteca.Domain.Commons;
using Biblioteca.Domain.Enums;

namespace Biblioteca.Domain.Entities;

public class Funcionario : EntityBase
{
    public string Nome { get; set; } = string.Empty;
    public CargoFuncionario Cargo { get; set; }  
    public string? Telefone { get; set; }
    
    // (1,n)
    public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}