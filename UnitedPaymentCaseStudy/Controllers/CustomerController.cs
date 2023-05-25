using Microsoft.AspNetCore.Mvc;
using UnitedPaymentCaseStudy.Business.Dto;
using UnitedPaymentCaseStudy.Business.Interfaces;
using UnitedPaymentCaseStudy.Data.Entity;
using ISession = NHibernate.ISession;

namespace UnitedPaymentCaseStudy.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerContoller : ControllerBase
    {
        private readonly ISession session;
        private readonly ICustomerService customer;

        public CustomerContoller(ISession session, ICustomerService _customer)
        {
            this.session = session;
            this.customer = _customer;
        }

        [HttpGet("GetAll")]
        public BaseResponse<IEnumerable<CustomerDto>> GetAll()
        {
            var result = customer.GetAll();
            return result;
        }

        [HttpPost("Create")]
        public BaseResponse<CustomerDto> Post([FromBody] CustomerDto request)
        {
            var result = customer.Insert(request);
            return result;
        }
    }
}

