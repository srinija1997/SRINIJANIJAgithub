using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class Book_repository
    {
        public List<Book> getallbooks()
        {
            return DataSource();
        }

        public Book getbookbyid(int id)  
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }

        public List<Book> searchbook(string title,string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
            new Book() { id = 1, Title = "Life", Author = "Srinija" },
            new Book() { id = 2, Title = "Foods", Author = "Anuja" },
            new Book { id = 3, Title = "Health", Author = "Lakshmi" },
            new Book { id = 4, Title = "Fitness", Author = "Satya" },
            new Book { id = 5, Title = "c#", Author = "Nithish" },
            };
        }
    }
}
