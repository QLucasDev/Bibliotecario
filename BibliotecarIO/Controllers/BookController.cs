using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecarIO.Models;
using BibliotecarIO.Models.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecarIO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public BookController(IRepositoryWrapper repository)
        {
            _repository = repository;
        } 

        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _repository.Book.FindAll();
            return Ok(books);
        }
    }
}