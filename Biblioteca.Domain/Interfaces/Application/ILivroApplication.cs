using Biblioteca.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Interfaces.Application
{
    public interface ILivroApplication
    {
        Task ConsultarTodos();
        Task<bool> Inserir(Livro livro);
        Task<bool> Apagar(Guid id);
        Task<bool> Atualizar(Livro livro);

    }
}
