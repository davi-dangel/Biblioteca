using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.ViewModels.Livro
{
    public class LivroParaInserirVM
    {
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Autor { get; set; }
        public int NumPaginas { get; set; }
        
    }
}
