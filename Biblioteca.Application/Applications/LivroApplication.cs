using AutoMapper;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces.Application;
using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Domain.ViewModels.Livro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteca.Application.Applications
{
    public class LivroApplication : ILivroApplication
    {
        private readonly ILivroRepository _repo;
        private readonly IMapper _mapper;

        public LivroApplication(ILivroRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Apagar(string id)
            => await _repo.Apagar(id);

        public async Task<bool> Atualizar(Livro livro)
            => await _repo.Atualizar(livro);

        public Task<IEnumerable<Livro>> ConsultarPorTitulo(string titulo)
            => _repo.ConsultarPorTitulo(titulo);

        public async Task<bool> Inserir(LivroParaInserirVM livroParaInserir)
        {
            var livro = _mapper.Map<Livro>(livroParaInserir);
            return await _repo.Inserir(livro);
        }

        async Task<IEnumerable<Livro>> ILivroApplication.ConsultarTodos()
            => await _repo.ConsultarTodos();
    }
}
