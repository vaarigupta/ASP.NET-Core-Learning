using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
       
        private List<BookModel> BookResource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id= 1, title = "Revolution2020", author="Chetan Bhagat"},
                new BookModel() { Id= 2, title = "Revolution2021", author="Chetan Bhagat1"},
                new BookModel() { Id= 3, title = "Revolution2022", author="Chetan Bhagat2"},
                new BookModel() { Id= 4, title = "Revolution2023", author="Chetan Bhagat3"},
                new BookModel() { Id= 5, title = "Revolution2024", author="Chetan Bhagat4"}

            };
        }
        public List<BookModel> GetAllBooks()
        {
            return BookResource();
        }
        public BookModel GetBookById(int id)
        {
            return BookResource().Where(x => x.Id == id).FirstOrDefault();
        }
        public BookModel SearchBook(String title,String author)
        {
            return BookResource().Where(x => x.title == title || x.author == author).FirstOrDefault();
        }
    }
}
