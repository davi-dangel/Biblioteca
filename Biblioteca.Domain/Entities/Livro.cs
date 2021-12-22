using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Biblioteca.Domain.Entities
{
    public class Livro
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
    }
}
