using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecarIO.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }  
         public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public enumCategory Category {get; set;}
        public int NumOfPages { get; set; }
        public double Price { get; set; }

        public Book()
        {
            
        }
    }
}