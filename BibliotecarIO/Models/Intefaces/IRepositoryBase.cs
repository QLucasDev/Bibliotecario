using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BibliotecarIO.Models.Intefaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable FindAll();
        IQueryable FindByCondiction(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}