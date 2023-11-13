using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BibliotecarIO.DataBase;
using BibliotecarIO.Models.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace BibliotecarIO.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected BibliotecarioContext context {get; set;}
        public RepositoryBase(BibliotecarioContext _context)
        {
            context = _context;
        }

        public IQueryable FindAll() => context.Set<T>().AsNoTracking();

        public IQueryable FindByCondiction(Expression<Func<T, bool>> expression) => context.Set<T>().Where(expression).AsNoTracking();
        
        public void Create(T entity) => context.Set<T>().Add(entity);

        public void Update(T entity) => context.Set<T>().Update(entity);

        public void Delete(T entity) => context.Set<T>().Remove(entity);

    }
}