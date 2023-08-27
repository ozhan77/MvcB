using ClassLibrary1.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı boş olamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı boş olamaz");
            RuleFor(x => x.CategoryDescription).MinimumLength(3).WithMessage("Kategori açıklamasınada birşeyler yaz boş olamaz");
        }
    }
}
