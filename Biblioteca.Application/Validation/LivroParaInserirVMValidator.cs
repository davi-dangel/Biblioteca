using Biblioteca.Domain.Enums;
using Biblioteca.Domain.ViewModels.Livro;
using FluentValidation;
using System;

namespace Biblioteca.Application.Validation
{
    public class LivroParaInserirVMValidator : AbstractValidator<LivroParaInserirVM>
    {
        public LivroParaInserirVMValidator()
        {
            RuleFor(x => x.Titulo)
                .NotNull().WithMessage("Titulo do Livro não pode ser null")
                .NotEmpty().WithMessage("Titulo do Livro não pode ser vazio");

            RuleFor(x => x.Autores)
                .NotNull().WithMessage("Pelo menos um autor(a) deve ser cadastrado(a)")
                .NotEmpty().WithMessage("Pelo menos um autor(a) deve ser cadastrado(a)");

            RuleFor(x => x.AnoPublicacao)
                .NotNull().WithMessage("Ano da publicação deve ser cadastrado")
                .NotEmpty().WithMessage("Ano da publicação deve ser cadastrado")
                .LessThanOrEqualTo(DateTime.Today).WithMessage("Data inserida não pode ser superior a data atual");

            RuleFor(x => x.NumPaginas)
                .NotEmpty().WithMessage("O número de páginas deve ser inserido")
                .GreaterThan(0);

            RuleFor(x => x.Editora)
                .NotNull().WithMessage("A editora não pode ser nula")
                .NotEmpty().WithMessage("A editora deve ser inserida");

            RuleFor(x => x.Edicao)
                .NotEmpty().WithMessage("A edição deve ser preenchida")
                .GreaterThanOrEqualTo(1).WithMessage("O número da edição deve ser igual ou maior que 1");

            RuleFor(x => x.Categorias)
                .NotNull().WithMessage("Pelo menos uma categoria deve ser cadastrada")
                .NotEmpty().WithMessage("Pelo menos uma categoria deve ser cadastrada");

            RuleFor(x => x.Status)
                .NotNull().WithMessage("O status da leitura deve ser cadastrado")
                .NotEmpty().WithMessage("O status da leitura deve ser cadastrado")
                .Must(BeAValidStatus).WithMessage("Status não é valido");

            RuleFor(x => x.DataLeituraFim)
                .LessThanOrEqualTo(DateTime.Today).WithMessage("Data inserida não pode ser superior a data atual");

        }

        private bool BeAValidStatus(string status)
        {
            if (status.Equals(LeituraStatus.LIDO) ||
                status.Equals(LeituraStatus.NAO_LIDO) ||
                status.Equals(LeituraStatus.LENDO))
                return true;
            else
                return false;
        }
    }
}
