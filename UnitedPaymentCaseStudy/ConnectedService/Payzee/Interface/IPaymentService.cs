using System;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.ConnectedService.Payzee.Interface
{
    public interface IPayment
    {
        Task<dynamic> Payment(PaymentRequestDto payRequest, string token);
    }
}

