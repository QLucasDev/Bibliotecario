using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecarIO.DataBase;
using BibliotecarIO.Models.Intefaces;

namespace BibliotecarIO.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private BibliotecarioContext _context;
        private IBookRepository _book;
        private IAuthorRepository _author;
        private IPublisherRepository _publisher;

        public IBookRepository Book { get {
                if(_book == null)
                {
                    _book = new BookRepository(_context);
                }
                return _book;
            }
        }

        public IAuthorRepository Author { get {
                if(_author == null)
                {
                    _author = new AuthorRepository(_context); 
                }
                return _author;
            }
        }

        public IPublisherRepository Publisher { get {
                if(_publisher == null)
                {
                    _publisher = new PublisherRepository(_context);
                }
                return _publisher;
            }
        }

        public RepositoryWrapper(BibliotecarioContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}