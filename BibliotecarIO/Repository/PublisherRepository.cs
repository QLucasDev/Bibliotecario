using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecarIO.DataBase;
using BibliotecarIO.Models;
using BibliotecarIO.Models.Intefaces;

namespace BibliotecarIO.Repository
{
    public class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(BibliotecarioContext _context) : base(_context)
        {
        }
    }
}