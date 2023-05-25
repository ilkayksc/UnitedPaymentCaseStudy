using System;
namespace UnitedPaymentCaseStudy.Data.Entity
{
    public class PaymentRequestDto
    {
        public string ApiKey { get; set; }

        public int MemberId { get; set; }

        public int MerchantId { get; set; }

        public string CustomerId { get; set; }

        public string CardPan { get; set; }

        public string ExpiryDateMonth { get; set; }

        public string ExpiryDateYear { get; set; }

        public string Cvv { get; set; }

        public string SecureDataId { get; set; }

        public string CardAlias { get; set; }

        public string UserCode { get; set; }

        public string TxnType { get; set; }

        public string InstallmentCount { get; set; }

        public string Currency { get; set; }

        public string OrderId { get; set; }

        public string TotalAmount { get; set; }

        public string PointAmount { get; set; }

        public string Rnd { get; set; }

        public string Hash { get; set; }

        public string Description { get; set; }

        public string CardHolderName { get; set; }

        public string RequestIp { get; set; }

        public InfoDto BillingInfo { get; set; } = new InfoDto();

        public InfoDto DeliveryInfo { get; set; } = new InfoDto();

        public List<ProductDto> Productlist { get; set; } = new List<ProductDto>();
    }
}

