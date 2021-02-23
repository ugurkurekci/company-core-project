using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerRegistrationValidator : AbstractValidator<CustomerRegistration>
    {
        public CustomerRegistrationValidator()
        {
            RuleFor(p => p.NewCustomerName).MinimumLength(2).NotEmpty();
            RuleFor(p => p.NewCustomerSurname).MinimumLength(1).NotEmpty();
            RuleFor(p => p.NewCustomerTelephoneNo.ToString()).NotEmpty().MaximumLength(12).MinimumLength(7);
            RuleFor(p => p.Mail).MinimumLength(5).NotEmpty().EmailAddress();
            RuleFor(p => p.Adress).MinimumLength(2).NotEmpty();






        }
    }
}
