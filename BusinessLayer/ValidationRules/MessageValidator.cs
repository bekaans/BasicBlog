using EntityLayer.Conctrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
        RuleFor(x => x.MessageReceiver).NotEmpty().WithMessage("Do Not Pass Receiver Name Empty");
        RuleFor(x => x.MessageSender).NotEmpty().WithMessage("Do Not Pass Sender Name Empty");
        RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Do Not Pass Content Empty");
        RuleFor(x => x.MessageSender).MinimumLength(3).WithMessage("Minimum 3 charachter");
        RuleFor(x => x.MessageReceiver).MinimumLength(3).WithMessage("Minimum 3 charachter");
        RuleFor(x => x.MessageSender).MaximumLength(50).WithMessage("Maximum 20 charachter");
        RuleFor(x => x.MessageReceiver).MaximumLength(20).WithMessage("Maximum 20 charachter");
        }
        
       
    }
}
