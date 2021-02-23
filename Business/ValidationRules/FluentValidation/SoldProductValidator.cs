using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class SoldProductValidator : AbstractValidator<SoldProduct>
    {
        public SoldProductValidator()
        {
            RuleFor(p => p.BuyerName).MinimumLength(2).NotEmpty();
            RuleFor(p => p.BuyerSurname).MinimumLength(1).NotEmpty();
            RuleFor(p => p.BuyerProject).MinimumLength(2).NotEmpty();
            RuleFor(p => p.BuyerImage).MinimumLength(2);
            RuleFor(p => p.BuyerPrice).GreaterThan(0).NotEmpty();
            RuleFor(p => p.BuyerQuantity).GreaterThan(0).NotEmpty();



        }
    }
}
