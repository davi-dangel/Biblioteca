using Biblioteca.Domain.Entities;
using FluentValidation;

namespace Biblioteca.Application.Validation
{
    public class LivroValidator : AbstractValidator<Livro>
    {
        public LivroValidator()
        {
            RuleFor(x => x.Titulo).NotNull().NotEmpty();
        }
    }
}
