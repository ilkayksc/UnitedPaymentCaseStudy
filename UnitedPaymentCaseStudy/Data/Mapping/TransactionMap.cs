using System;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Data.Mapping
{
    public class TransactionMap : ClassMapping<Transaction>
    {   // Customer tablosu map işlemleri
        public TransactionMap()
        {   // Primary key olduğu için property yerine id kullanıldı.
            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Generator(Generators.Increment);
                x.Column("Id");
                x.UnsavedValue(0);

            });
            Property(b => b.Amount, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.Double);
                x.NotNullable(true);
                x.Column("Amount");
            });
            Property(b => b.CardPan, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
                x.Column("CardPan");
            });

            Property(b => b.CustomerId, x =>
            {
                x.Type(NHibernateUtil.String);
                x.Column("CustomerId");
            });

            Property(b => b.OrderId, x =>
            {
                x.Length(20);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
                x.Column("OrderId");
            });

            Property(b => b.TypeId, x =>
            {
                x.Length(20);
                x.Type(NHibernateUtil.Int32);
                x.NotNullable(true);
                x.Column("TypeId");
            });

            Property(b => b.Status, x =>
            {
                x.Length(20);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
                x.Column("StatusId");
            });
            Property(b => b.ResponseCode, x =>
            {
                x.Length(20);
                x.Type(NHibernateUtil.Int32);
                x.NotNullable(true);
                x.Column("ResponseCode");
            });
            Property(b => b.ResponseMessage, x =>
            {
                x.Length(20);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
                x.Column("ResponseMessage");
            });
            Table("transaction");

        }
    }
}

