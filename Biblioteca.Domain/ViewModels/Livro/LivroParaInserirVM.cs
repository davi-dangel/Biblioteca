using System;
using System.Collections.Generic;

namespace Biblioteca.Domain.ViewModels.Livro
{
    public class LivroParaInserirVM
    {
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public List<string> Autores { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public int NumPaginas { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public List<string> Categorias { get; set; }
        public string Status { get; set; }
        public DateTime DataLeituraFim { get; set; }

    }
}
