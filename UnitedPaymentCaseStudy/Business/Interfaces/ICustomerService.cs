using UnitedPaymentCaseStudy.Business.Dto;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Business.Interfaces
{
    public interface ICustomerService : IBaseService<CustomerDto, Customer>
    {
    }
   
}

