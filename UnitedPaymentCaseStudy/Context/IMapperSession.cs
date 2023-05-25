using System;
using System.Linq.Expressions;

namespace UnitedPaymentCaseStudy.Context
{
    public interface IMapperSession<Entity> where Entity : class
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void CloseTransaction();

        void Save(Entity entity);
        void Update(Entity entity);
        void Delete(long id);
        List<Entity> GetAll();

        IQueryable<Entity> Entities { get; }
        IEnumerable<Entity> Where(Expression<Func<Entity, bool>> where);
        Entity GetById(long id);



    }
}

