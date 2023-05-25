using UnitedPaymentCaseStudy.Business.Dto;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Business.Interfaces
{
    public interface ITransactionService : IBaseService<TransactionDto, Transaction>
    {
        BaseResponse<TransactionDto> Payment(PaymentRequestDto dto);
    }
}

