using Biblioteca.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteca.Api.Controllers
{
    [Route("api/livros")]
    public class LivrosController : MainController
    {
        private readonly ILivroApplication _livroApplication;
        public LivrosController(ILivroApplication livroApplication)
        {
            _livroApplication = livroApplication;
        }

        [HttpGet(Name = nameof(Inserir))]
        public async Task<IActionResult> Inserir()
        {
            return Ok("Cheguei aqui");
            throw new NotImplementedException();
        }


        public async Task<IActionResult> ConsultarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
