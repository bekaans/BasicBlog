using EntityLayer.Conctrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator() 
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Do not pass to Email Adress");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Do Not Pass to Subject  Empty");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Do Not Pass to Username Empty");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Minimum 3 charachter");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Minimum 3 charachter");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Maximum 20 charachter");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Maximum 20 charachter");
        }
    }
}
