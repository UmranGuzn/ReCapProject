using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.Descriptions).NotEmpty();
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.ModelYear).NotEmpty();

            RuleFor(p => p.Descriptions).MinimumLength(2);
           
            RuleFor(p => p.DailyPrice).GreaterThan(0);

            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(50000).When(p => p.BrandId == 1);

            RuleFor(p => p.ModelYear).Must(StartWithTwo).WithMessage("Araçlar 2000 yılından önce olamaz");
        }

        private bool StartWithTwo(string arg)
        {
            return arg.StartsWith("2");
        }
    }
}
