using Biblioteca.Domain.Commons;

namespace Biblioteca.Domain.Entities;

public class Emprestimo : EntityBase
{
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucaoPrevista { get; set; }     
    public DateTime? DataDevolucao { get; set; }           
    
    public int IdCliente { get; set; }                    
    public int IdFuncionario { get; set; }                
    public int IdLivro { get; set; }
    
    public Cliente? Cliente { get; set; }
    public Funcionario? Funcionario { get; set; }
    public Livro? Livro { get; set; }
}