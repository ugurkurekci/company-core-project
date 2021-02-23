using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductRegistrationValidator : AbstractValidator<ProductRegistration>
    {
        public ProductRegistrationValidator()
        {
            RuleFor(p => p.NewProductName).MinimumLength(2).NotEmpty();
            RuleFor(p => p.NewProductPrice).GreaterThan(0).NotEmpty();
            RuleFor(p => p.NewProductQuantity).GreaterThan(0).NotEmpty();
            RuleFor(p => p.NewProductImage).MinimumLength(1);

        }
    }
}


