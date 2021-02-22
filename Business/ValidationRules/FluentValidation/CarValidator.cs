using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car> 
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c=>c.Name).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(50).When(c => c.BrandId == 1);
            //RuleFor(c => c.Name).Must(StartWithA).WithMessage("Cars must start with the letter A");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
