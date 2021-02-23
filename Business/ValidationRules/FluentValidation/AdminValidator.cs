using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(p => p.Name).MinimumLength(0).NotEmpty();
            RuleFor(p => p.Passw).MinimumLength(0).NotEmpty();
            RuleFor(p => p.Mail).NotEmpty();
            RuleFor(p => p.Mail).EmailAddress().NotEmpty();

        }


    }
}
