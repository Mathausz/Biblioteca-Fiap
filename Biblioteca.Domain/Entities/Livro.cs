using Biblioteca.Domain.Commons;
using Biblioteca.Domain.Enums;

namespace Biblioteca.Domain.Entities;

public class Livro : EntityBase
{
    public string Titulo { get; set; } = string.Empty;
    public StatusLivro Status { get; set; } = StatusLivro.Disponivel;
    public DateTime? DataLocalizacao { get; set; }
    
    // Relacionamento com Autor (1,1)
    public int IdAutor { get; set; }
    public required Autor Autor { get; set; }
    
    // (1,n)
    public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}
