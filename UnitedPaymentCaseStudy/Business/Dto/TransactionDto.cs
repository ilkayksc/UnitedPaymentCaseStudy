using System;
using System.ComponentModel.DataAnnotations;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Business.Dto
{
    public class TransactionDto:BaseEntity
    {
        public virtual string TransactionId { get; set; }

        public virtual string CustomerId { get; set; }

        public virtual string OrderId { get; set; }

        public virtual int TypeId { get; set; }

        public virtual decimal Amount { get; set; }

        public virtual string CardPan { get; set; }

        public virtual int ResponseCode { get; set; }

        public virtual string ResponseMessage { get; set; }

        public TransactionDto() { }
    }
}

