using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Repository.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
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
        public async Task<bool> Apagar(string id)
        {
            try
            {
                var filter = Builders<Livro>.Filter.Eq(x => x.Id, id);
                await _db.Livros.DeleteOneAsync(filter);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Atualizar(Livro livro)
        {
            try
            {
                var filter = Builders<Livro>.Filter.Eq(x => x.Id, livro.Id);
                var update = Builders<Livro>.Update.Set(x => x.Titulo, livro.Titulo);
                await _db.Livros.UpdateOneAsync(filter, update);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Livro>> ConsultarPorTitulo(string titulo)
        {
            var filtro = Builders<Livro>.Filter.Eq(x => x.Titulo, titulo);

            return await _db.Livros.Find(filtro)
                .ToListAsync();
        }

        public async Task<IEnumerable<Livro>> ConsultarTodos()
            => await _db.Livros.Find(new BsonDocument()).SortBy(x => x.Titulo).ToListAsync();
        //new bsonDocumento é usado quando não queremos passar nenhum filtro no método find

        public async Task<bool> Inserir(Livro livro)
        {
            try
            {
                await _db.Livros.InsertOneAsync(livro);

                if (livro.Id != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
