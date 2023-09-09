using ClassLibrary1.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı boş olamaz");
            RuleFor(x => x.WriterName).Must(name => name.Contains("a")).WithMessage("Yazar Adı 'a' harfi içermelidir");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadı boş olamaz");
            RuleFor(x => x.WriterAbout).MinimumLength(3).WithMessage("Yazar açıklamasınada birşeyler yaz boş olamaz");
        }
    }
}
