using System;
using FluentValidation;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Data.Validation
{
    public class TransactionValidator : AbstractValidator<Transaction>
    {
        public TransactionValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.TransactionId).NotNull();
            RuleFor(x => x.CardPan).NotNull();
        }
    }
}

