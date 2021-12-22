using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces.Application;
using System;
using System.Threading.Tasks;

namespace Biblioteca.Application.Applications
{
    public class LivroApplication : ILivroApplication
    {
        public Task<bool> Apagar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Atualizar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Inserir(Livro livro)
        {
            throw new NotImplementedException();
        }
    }
}
