using AutoMapper;
using UnitedPaymentCaseStudy.Business.Dto;
using UnitedPaymentCaseStudy.Business.Interfaces;
using UnitedPaymentCaseStudy.ConnectedService.Payzee.Interface;
using UnitedPaymentCaseStudy.Context;
using UnitedPaymentCaseStudy.Data.Entity;
using UnitedPaymentCaseStudy.Data.Enum;
using ISession = NHibernate.ISession;
namespace UnitedPaymentCaseStudy.Business.Services
{
    public class TransactionService : BaseService<TransactionDto, Transaction>, ITransactionService
    {
        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IMapperSession<Transaction> transactionRepository;
        protected readonly ILoginService _login;
        private readonly IPayment _payment;

        public TransactionService(ILoginService login, ISession session, IPayment payment, IMapper mapper) : base(session, mapper)
        {
            this._login = login;
            this._payment = payment;
            transactionRepository = new MapperSession<Transaction>(session);

        }

        public BaseResponse<TransactionDto> Payment(PaymentRequestDto dto)
        {
            try
            {
                var token = _login.PayzeeToken().Result;

                dto.Hash = CreateHash(new VposRequest()
                {
                    ApiKey = dto.ApiKey,
                    TotalAmount = dto.TotalAmount,
                    CustomerId = dto.CustomerId,
                    UserCode = dto.UserCode,
                    OrderId = dto.OrderId,
                    Rnd = dto.Rnd,
                    TxnType = dto.TxnType
                });

                var result = _payment.Payment(dto, token).Result;

                var respMessageData = result.result;
                var respMessage = respMessageData.ToString();
             
                transactionRepository.Save(new Transaction()
                {
                    Amount = Convert.ToDouble(dto.TotalAmount),
                    CreatedAt = DateTime.UtcNow,
                    CardPan = dto.CardPan,
                    CustomerId = dto.CustomerId,
                    ResponseCode = Convert.ToInt32(result.statusCode),
                    ResponseMessage = respMessage,
                    OrderId = dto.OrderId,
                    TransactionId = "1",
                    UpdatedAt = DateTime.UtcNow,
                    Status = "1",
                    TypeId = TypeIdEnum.Sale
                });

                if (result.result.responseCode != "00") 
                {
                    return new BaseResponse<TransactionDto>(result);
                }
                else
                {
                    return new BaseResponse<TransactionDto>(result);
                }

            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static string CreateHash(VposRequest request)
        {

            var apiKey = request.ApiKey; // Bu bilgi size özel olup kayıtlı kullanıcınıza mail olarak gönderilmiştir.

            var hashString = $"{apiKey}{request.UserCode}{request.Rnd}{request.TxnType}{request.TotalAmount}{request.CustomerId}{request.OrderId}";

            System.Security.Cryptography.SHA512 s512 = System.Security.Cryptography.SHA512.Create();

            System.Text.UnicodeEncoding ByteConverter = new System.Text.UnicodeEncoding();

            byte[] bytes = s512.ComputeHash(ByteConverter.GetBytes(hashString));

            var hash = System.BitConverter.ToString(bytes).Replace("-", "");

            return hash;

        }
    }
}

