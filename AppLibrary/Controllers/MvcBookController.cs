using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLibrary.Models;
using AppLibrary.Repository;
using System.Linq;
namespace AppLibrary.Controllers
{
    public class MvcBookController : Controller
    {
        private Ibooks bk;
        public MvcBookController()
        {
            this.bk = new RepositoryBooks(new libraryEntities()) ;
        }

        // GET: MvcBook
        public ActionResult Index()
        {
            var bookData=bk.getBookDetails().ToList();
            return View(bookData);
        }

        // GET: MvcBook/Details/5
        public ActionResult Details(int id)
        {
            var bookById=bk.getBookByID(id);
            return View(bookById);
        }

        // GET: MvcBook/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MvcBook/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,book newBook)
        {
            try
            {
                var newBookData=new book();
                newBookData.book_name = newBook.book_name;
                newBookData.author_name = newBook.author_name;
                newBookData.price = newBook.price;
                newBookData.summary = newBook.summary;
                newBookData.publish_date = newBook.publish_date;
                bk.insertBookDetails(newBookData);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MvcBook/Edit/5
        public ActionResult Edit(int id)
        {

            var bookData = bk.getBookByID(id);
            var newBookData = new book();
            newBookData.book_name = bookData.book_name;
            newBookData.author_name = bookData.author_name;
            newBookData.price = bookData.price;
            newBookData.summary = bookData.summary;
            newBookData.publish_date = bookData.publish_date;
            bk.insertBookDetails(newBookData);
            return View(bookData);
        }

        // POST: MvcBook/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection,book bs)
        {
            try
            {
                // TODO: Add update logic here
                bk.updateBookDetails(bs);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MvcBook/Delete/5
        public ActionResult Delete(int id)
        {

            var bookData=bk.getBookByID(id);
            return View(bookData);
        }

        // POST: MvcBook/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                bk.deleteBookDetails(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
