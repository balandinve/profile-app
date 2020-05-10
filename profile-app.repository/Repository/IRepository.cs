using profile.data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace profile.repository
{
    public interface IRepository
    {
        public interface IRepository<TEntity, TKey> where TEntity : IBaseEntity<TKey>
        {
            /// <summary>
            /// Добавляет модель
            /// </summary>
            /// <param name="entity">Объект модели</param>
            TKey Add(TEntity entity);


            /// <summary>
            /// Обновляет модель
            /// </summary>
            /// <param name="entity">Объект модели</param>
            void Update(TEntity entity);


            /// <summary>
            /// Помечает модель как удаленную
            /// </summary>
            /// <param name="id">Уникальный идентификатор модели</param>
            void Delete(TKey id);


            /// <summary>
            /// Возвращает объект модели по идентификатору
            /// </summary>
            /// <param name="id">Идентификатор</param>
            TEntity GetByID(TKey id);

            IEnumerable<TEntity> GetAll(Func<TEntity, bool> expression, params Expression<Func<TEntity, object>>[] includeProperties);
        }
    }
}
