using System;
using UnitedPaymentCaseStudy.Business.Dto;
using UnitedPaymentCaseStudy.Business.Interfaces;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.ConnectedService.Payzee.Interface
{
    public interface ILoginService
    {
        Task<string> PayzeeToken();
    }
}

