using System;
using System.ComponentModel.DataAnnotations;

namespace UnitedPaymentCaseStudy.Data.Entity
{
	public class Customer:BaseEntity
	{
        public virtual long CustomerId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual DateTime BirthDate { get; set; }

        public virtual string IdentityNo { get; set; }

        public virtual bool IdentityNoVerified { get; set; }

        public virtual bool Status { get; set; }

        public Customer() { }
	}
}

