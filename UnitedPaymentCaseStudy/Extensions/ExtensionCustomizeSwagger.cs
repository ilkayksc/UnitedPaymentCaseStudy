using System;
using Microsoft.OpenApi.Models;

namespace UnitedPaymentCaseStudy.Extensions
{
    public static class ExtensionCustomizeSwagger
    {
        public static void AddCustomizeSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "United Payment Case Study", Version = "v1.0" });
                c.OperationFilter<ExtensionSwaggerFileOperationFilter>();
            });
        }
    }
}

