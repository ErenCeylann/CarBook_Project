using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator:AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Geçmeyin!!!");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Giriniz !!!");
            RuleFor(x => x.CustomerRaytingValue).NotEmpty().WithMessage("Lütfen Puan Değerini Boş Geçmeyin !!!");
            RuleFor(x => x.CustomerComment).NotEmpty().WithMessage("Lütfen Yorum Değerini Boş Geçmeyin !!!");
            RuleFor(x => x.CustomerComment).MinimumLength(50).WithMessage("Lütfen Yorum Kısmına En Az 50 Karakter Veri Giriniz !!!");
            RuleFor(x => x.CustomerComment).MaximumLength(500).WithMessage("Lütfen Yorum Kısmına En Fazla 500 Karakter Veri Giriniz !!!");
            RuleFor(x => x.CustomerImage).NotEmpty().WithMessage("Lütfen Müşteri Görselini Boş Geçmeyin!!!");
        }
    }
}
