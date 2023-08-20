using EntityLayer.Conctrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
      public CategoryValidatior() 
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Do Not Pass Category Name Empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Do Not Pass Category Description Empty");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Minimum 3 charachter");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Maximum 20 charachter");
        }

    }
}
