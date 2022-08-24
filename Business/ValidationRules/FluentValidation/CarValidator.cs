using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Cars_Name).NotEmpty();
            RuleFor(c => c.BrandsId).NotEmpty();
            RuleFor(c => c.Cars_Name).MinimumLength(2);
            RuleFor(c => c.Daily_Price).NotEmpty();
            RuleFor(c => c.Daily_Price).GreaterThanOrEqualTo(0);
        }
    }
}
