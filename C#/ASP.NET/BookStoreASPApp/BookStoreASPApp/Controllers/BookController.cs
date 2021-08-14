using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreASPApp.Models;
using BookStoreASPApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreASPApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(id);
            return View();
        }

        public ViewResult SearchBook(string bookName, string authorName)
        {
            var data = _bookRepository.SearchBook(bookName, authorName);
            return View();
        }

        
    }
}
