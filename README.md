# Biblioteca Fiap

## Autores
- **Mathaus Victor Souza Marcelino** - RM564146
- **Luan Peixoto Marins Rocha** - RM562258
- **Vinícius Luis Exposito Morassi Garcia** - RM563340
## Descrição do Projeto
Este é um projeto de uma API Web para gerenciamento de uma biblioteca, desenvolvido em .NET.  O sistema permite modelar e gerenciar entidades relacionadas a empréstimos de livros, autores, clientes e funcionários.

O projeto está focado na modelagem de domínio, com entidades bem definidas e relacionamentos.

## Modelo Entidade-Relacionamento (MER)
O MER da biblioteca inclui as seguintes entidades e relacionamentos:

- **Autor** (1,n) **Livro**: Um autor pode ter vários livros.
- **Livro** (1,1) **Autor**: Um livro pertence a um autor.
- **Livro** (1,n) **Emprestimo**: Um livro pode ter vários empréstimos.
- **Cliente** (1,n) **Emprestimo**: Um cliente pode ter vários empréstimos.
- **Funcionario** (1,n) **Emprestimo**: Um funcionário pode ter vários empréstimos.
- **Emprestimo** (1,1) **Cliente**: Um empréstimo pertence a um cliente.
- **Emprestimo** (1,1) **Funcionario**: Um empréstimo pertence a um funcionário.
- **Emprestimo** (1,1) **Livro**: Um empréstimo pertence a um livro.

### Entidades
- **Autor**: Representa os autores dos livros (Nome).
- **Livro**: Representa os livros disponíveis (Título, Status, Data de Localização, Autor).
- **Cliente**: Representa os clientes da biblioteca (Nome, CPF, Telefone, Email).
- **Funcionario**: Representa os funcionários (Nome, Cargo, Telefone).
- **Emprestimo**: Representa os empréstimos (Datas de empréstimo e devolução, Cliente, Funcionario, Livro).

### Enums
- **StatusLivro**: Disponivel, Emprestado, Reservado.
- **CargoFuncionario**: Bibliotecario, Atendente, Administrador.


## Estrutura do Projeto
- **Biblioteca.Domain**: Contém as entidades, enums e lógica de domínio.
- **Biblioteca.Application**: Camada de aplicação.
- **Biblioteca.Infrastructure**: Camada de infraestrutura.
- **Biblioteca WebAPI**: API Web com endpoints básicos.

## Como Executar
1. Certifique-se de ter o .NET 10.0 instalado.
2. Abra o projeto no Visual Studio ou Rider.
3. Execute o projeto **Biblioteca WebAPI**.
4. A API estará disponível em `https://localhost:5001` (ou similar).

## Notas sobre a Criação do README
Este README foi criado utilizando assistência de IA (GitHub Copilot) e inclui tentativas de arrumar o merge que deu conflito.
