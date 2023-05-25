using System;
namespace UnitedPaymentCaseStudy.Data.Entity
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }

        public virtual DateTime CreatedAt { get; set; }

        public virtual DateTime UpdatedAt { get; set; }

        public virtual string Status { get; set; }
    }
}

