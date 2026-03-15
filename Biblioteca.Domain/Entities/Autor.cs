using Biblioteca.Domain.Commons;

namespace Biblioteca.Domain.Entities;

public class Autor : EntityBase
{
    public string Nome { get; set; } = string.Empty;
    
    // (1,n)
    public ICollection<Livro> Livros { get; set; } = new List<Livro>();
}