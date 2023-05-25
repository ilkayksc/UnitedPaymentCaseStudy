using System;
using AutoMapper;
using UnitedPaymentCaseStudy.Business;
using UnitedPaymentCaseStudy.Business.Interfaces;
using UnitedPaymentCaseStudy.Business.Services;
using UnitedPaymentCaseStudy.ConnectedService.Payzee.Interface;
using UnitedPaymentCaseStudy.ConnectedService.Payzee.Services;
using UnitedPaymentCaseStudy.Mapper;

namespace UnitedPaymentCaseStudy.Extensions
{
    public static class ExtensionService
    {

        public static void AddServices(this IServiceCollection services)
        {
            // services 
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IPayment, Payment>();

            // mapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());

        }
    }
}

