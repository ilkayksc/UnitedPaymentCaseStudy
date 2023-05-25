using System;
using System.ComponentModel.DataAnnotations;
using UnitedPaymentCaseStudy.Data.Enum;

namespace UnitedPaymentCaseStudy.Data.Entity
{
	public class Transaction:BaseEntity
	{
        public virtual string TransactionId { get; set; }

        public virtual string CustomerId { get; set; }

        public virtual string OrderId { get; set; }

        public virtual TypeIdEnum TypeId { get; set; }

        public virtual double Amount { get; set; }

        public virtual string CardPan { get; set; }

        public virtual int ResponseCode { get; set; }

        public virtual string ResponseMessage { get; set; }

        public Transaction() { }
	}
}

