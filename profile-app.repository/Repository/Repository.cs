using Microsoft.EntityFrameworkCore;
using profile.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static profile.repository.IRepository;

namespace profile.repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class, IBaseEntity<TKey>
    {
        private readonly UnitOfWork unitOfWork;
        private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> result = unitOfWork.Context.Set<TEntity>().AsNoTracking();
            return includeProperties.Aggregate(result, (current, includeProperty) => current.Include(includeProperty));
        }
        public Repository(UnitOfWork context)
        {
            unitOfWork = context;
        }
        public virtual TKey Add(TEntity entity)
        {
            //Include();
            unitOfWork.Context.Set<TEntity>().Add(entity);
            unitOfWork.Context.SaveChanges();
            return entity.Id;
        }
        public virtual void Update(TEntity entity)
        {
            if (entity != null)
            {
                TEntity updatableEntity = unitOfWork.Context.Set<TEntity>().Find(entity.Id);
                if (updatableEntity != null)
                {
                    unitOfWork.Context.Entry(updatableEntity).CurrentValues.SetValues(entity);
                    unitOfWork.Context.SaveChanges();
                }

            }
        }
        public virtual TEntity GetByID(TKey id)
        {
            return unitOfWork.Context.Set<TEntity>().Find(id);
        }
        public virtual void Delete(TKey id)
        {
            TEntity deletableEntity = unitOfWork.Context.Set<TEntity>().Find(id);
            deletableEntity.DeletedDate = DateTime.Now;
            unitOfWork.Context.SaveChanges();
        }
        public IEnumerable<TEntity> GetAll(Func<TEntity, bool> expression, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var result = Include(includeProperties);
            return result.Where(expression);
        }
    }
}
