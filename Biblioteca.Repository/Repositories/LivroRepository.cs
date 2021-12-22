using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Repository.Configuration;
using System;
using System.Threading.Tasks;

namespace Biblioteca.Repository.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly MongoDBContext _db;

        public LivroRepository(MongoDBContext mongoDBContext)
        {
            _db = mongoDBContext;
        }
        public Task<bool> Apagar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Atualizar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Inserir(Livro livro)
        {
            throw new NotImplementedException();
        }

        Task ILivroRepository.ConsultarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
