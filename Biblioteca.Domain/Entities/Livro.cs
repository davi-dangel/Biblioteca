using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Biblioteca.Domain.Entities
{
    public class Livro
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public List<string> Autores { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int NumPaginas { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public List<string> Categorias { get; set; }
        public string Status { get; set; }
        public DateTime DataLeituraFim { get; set; }
    }
}
