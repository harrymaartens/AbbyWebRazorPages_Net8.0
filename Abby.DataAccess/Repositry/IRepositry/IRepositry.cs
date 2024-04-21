using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IRepositry<T> where T : class
	{
        // GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE

        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null,
            string? includeProperties = null);
        T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

    }
}
