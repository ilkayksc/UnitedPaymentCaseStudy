using System;
using FluentValidation;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Data.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Surname).NotNull().MinimumLength(3).MaximumLength(50);
        }
    }
}

