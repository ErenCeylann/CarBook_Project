using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class CreateReviewValidator : AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Geçmeyin!!!");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Giriniz !!!");
            RuleFor(x => x.CustomerRaytingValue).NotEmpty().WithMessage("Lütfen Puan Değerini Boş Geçmeyin !!!");
            RuleFor(x => x.CustomerComment).NotEmpty().WithMessage("Lütfen Yorum Değerini Boş Geçmeyin !!!");
            RuleFor(x => x.CustomerComment).MinimumLength(50).WithMessage("Lütfen Yorum Kısmına En Az 50 Karakter Veri Giriniz !!!");
            RuleFor(x => x.CustomerComment).MaximumLength(500).WithMessage("Lütfen Yorum Kısmına En Fazla 500 Karakter Veri Giriniz !!!");
        }
    }
}
