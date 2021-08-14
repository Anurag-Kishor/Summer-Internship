using BookStoreASPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreASPApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(book => book.Id == id).FirstOrDefault() ;
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return DataSource().Where(book => book.Author.Contains(authorName) && book.Title.Contains(bookName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>() {
                new BookModel() { Id = 101, Author="Author1", Title="Title1"},
                new BookModel() { Id = 102, Author="Author2", Title="Title2"},
                new BookModel() { Id = 103, Author="Author3", Title="Title3"},
                new BookModel() { Id = 104, Author="Author4", Title="Title4"},
                new BookModel() { Id = 105, Author="Author5", Title="Title5"}
            };
        }
    }
}
