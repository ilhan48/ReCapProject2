using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentValidator:AbstractValidator<Rent>
    {
        public RentValidator()
        {
            RuleFor(r => r.RentDate).Empty().WithMessage("The car is not rent.");
        }
    }
}
