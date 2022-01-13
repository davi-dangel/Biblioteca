using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces.Application;
using Biblioteca.Domain.ViewModels.Livro;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Biblioteca.Api.Controllers
{
    [EnableCors]
    [Route("api/livros")]
    public class LivrosController : MainController
    {
        private readonly ILivroApplication _livroApp;
        public LivrosController(ILivroApplication livroApplication)
        {
            _livroApp = livroApplication;
        }

        //TODO: MELHORAR A ATUALIZAÇÃO
        [HttpPut(Name = nameof(Atualizar))]
        public async Task<IActionResult> Atualizar([FromBody] Livro livro)
        {
            if (livro == null)
                return BadRequest("Request inválido");

            try
            {
                var atualizado = await _livroApp.Atualizar(livro);
                return Ok(atualizado);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(Name = nameof(Inserir))]
        public async Task<IActionResult> Inserir([FromBody]LivroParaInserirVM livro)
        {
            try
            {
                await _livroApp.Inserir(livro);
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(Name = nameof(ConsultarTodos))]
        public async Task<IActionResult> ConsultarTodos()
        {
            try
            {
                var livros = await _livroApp.ConsultarTodos();
                return Ok(livros);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{titulo}", Name = nameof(ConsultarPorTitulo))]
        public async Task<IActionResult> ConsultarPorTitulo(string titulo)
        {
            try
            {
                var livro = await _livroApp.ConsultarPorTitulo(titulo);
                return Ok(livro);
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível buscar os livros");
            }
        }

        [HttpDelete(Name = nameof(Apagar))]
        public async Task<IActionResult> Apagar([FromQuery]string id)
        {
            if (id == null) return BadRequest("Request inválido");
            try
            {
                var apagado = await _livroApp.Apagar(id);
                return Ok(apagado);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
