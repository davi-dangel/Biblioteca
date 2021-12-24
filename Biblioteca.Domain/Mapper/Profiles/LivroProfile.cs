using AutoMapper;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.ViewModels.Livro;

namespace Biblioteca.Domain.Mapper.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Livro, LivroParaInserirVM>();
            CreateMap<LivroParaInserirVM, Livro>();
        }
    }
}
