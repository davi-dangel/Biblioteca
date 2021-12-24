using Biblioteca.Domain.Entities;
using Biblioteca.Domain.ViewModels.Livro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Interfaces.Application
{
    public interface ILivroApplication
    {
        Task<IEnumerable<Livro>> ConsultarTodos();
        Task<IEnumerable<Livro>> ConsultarPorTitulo(string titulo);
        Task<bool> Inserir(LivroParaInserirVM livro);
        Task<bool> Apagar(string id);
        Task<bool> Atualizar(Livro livro);

    }
}
