using EntityLayer.Conctrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator :AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Do Not Pass Writer Name Empty");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Do Not Pass Writer Surname Empty");
            RuleFor(x => x.WriterInfo).NotEmpty().WithMessage("Cannot pass empty Writer Info");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Writer Surname can be min 3 characahters");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Writer Surname can be max 20 charachters");
        }
    }
}
