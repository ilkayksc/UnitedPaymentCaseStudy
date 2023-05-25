using NHibernate.Mapping.ByCode.Conformist;
using NHibernate;
using NHibernate.Mapping.ByCode;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Data.Mapping
{
    public class CustomerMap : ClassMapping<Customer>
    {   // Customer tablosu map işlemleri
        public CustomerMap()
        {   // Primary key olduğu için property yerine id kullanıldı.
            Id(x => x.CustomerId, x =>
            {
                x.Type(NHibernateUtil.Int64);
                x.Generator(Generators.Increment);
                x.Column("CustomerId");
                x.UnsavedValue(0);

            });
            Property(b => b.Name, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
                x.Column("Name");
            });
            Property(b => b.Surname, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
                x.Column("Surname");
            });

            Property(b => b.BirthDate, x =>
            {
                x.Type(NHibernateUtil.DateTime);
                x.Column("BirthDate");
            });
            Property(b => b.IdentityNo, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
                x.Column("IdentityNo");
            });
            Property(b => b.IdentityNoVerified, x =>
            {
                x.Length(20);
                x.Type(NHibernateUtil.Boolean);
                x.NotNullable(true);
                x.Column("IdentityNoVerified");
            });

            Property(b => b.Status, x =>
            {
                x.Length(20);
                x.Type(NHibernateUtil.Boolean);
                x.NotNullable(true);
                x.Column("Status");
            });

            Table("customer");

        }
    }
}

