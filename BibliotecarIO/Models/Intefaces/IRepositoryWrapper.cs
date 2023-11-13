using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecarIO.Models.Intefaces
{
    public interface IRepositoryWrapper
    {
        IBookRepository Book {get;}
        IAuthorRepository Author {get;}
        IPublisherRepository Publisher {get;}

        void Save();
    }
}