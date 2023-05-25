using Microsoft.AspNetCore.Mvc;
using UnitedPaymentCaseStudy.Business.Dto;
using UnitedPaymentCaseStudy.Business.Interfaces;
using UnitedPaymentCaseStudy.Data.Entity;
using ISession = NHibernate.ISession;

namespace UnitedPaymentCaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionContoller : ControllerBase
    {
        private readonly ISession session;
        private readonly ITransactionService transaction;

        public TransactionContoller(ISession session, ITransactionService _transaction)
        {
            this.session = session;
            this.transaction = _transaction;
        }

        [HttpGet("GetAll")]
        public BaseResponse<IEnumerable<TransactionDto>> GetAll()
        {
            var result = transaction.GetAll();
            return result;
        }

        [HttpPost("Create")]
        public BaseResponse<TransactionDto> Post([FromBody] PaymentRequestDto request)
        {
            var result = transaction.Payment(request);
            return result;
        }
    }
}

