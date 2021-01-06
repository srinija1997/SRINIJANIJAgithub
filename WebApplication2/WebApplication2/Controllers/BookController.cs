using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class BookController : Controller
    {
        private readonly Book_repository bookrepos=null;

        public BookController()
        {
            bookrepos = new Book_repository();
        }
        public ViewResult Getallbooks()
        {
            var data= bookrepos.getallbooks();
            return View();
        }

        public Book Getbook(int id)
        {   
            return  bookrepos.getbookbyid(id);
        }

        public List<Book> booksearch(string bookname, string authorname)
        {
            return bookrepos.searchbook(bookname, authorname);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
    