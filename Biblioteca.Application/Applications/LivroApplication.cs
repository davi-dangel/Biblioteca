using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces.Application;
using Biblioteca.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteca.Application.Applications
{
    public class LivroApplication : ILivroApplication
    {
        private readonly ILivroRepository _repo;
        public LivroApplication(ILivroRepository repo)
        {
            _repo = repo;
        }
        public async Task<bool> Apagar(string id)
            => await _repo.Apagar(id);

        public async Task<bool> Atualizar(Livro livro)
            => await _repo.Atualizar(livro);

        public Task<IEnumerable<Livro>> ConsultarPorTitulo(string titulo)
            => _repo.ConsultarPorTitulo(titulo);

        public async Task<bool> Inserir(Livro livro)
            => await _repo.Inserir(livro);

        async Task<IEnumerable<Livro>> ILivroApplication.ConsultarTodos()
            => await _repo.ConsultarTodos();
    }
}
