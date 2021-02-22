using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("This field cannot be left blank!");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("This field cannot be left blank!");
            RuleFor(u => u.Email).NotEmpty().WithMessage("This field cannot be left blank!");
            RuleFor(u => u.Password).NotEmpty().WithMessage("This field cannot be left blank!");
        }
    }
}
