using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppLibrary.Models;
using AppLibrary.Repository;
namespace AppLibrary.Repository
{
    public class RepositoryBooks : Ibooks
    {
    
        private libraryEntities libraryEntities;

        public RepositoryBooks(libraryEntities libraryEntities)
        {
            this.libraryEntities = libraryEntities;
        }

        public void deleteBookDetails(int book)
        {
            book bks=libraryEntities.books.Find(book);
           libraryEntities.books.Remove(bks);
            libraryEntities.SaveChanges();
            
        }

        public book getBookByID(int id)
        {
            return libraryEntities.books.Find(id);
        }

        public IEnumerable<book> getBookDetails()
        {
            return libraryEntities.books.ToList();
        }

        public void insertBookDetails(book books)
        {
             libraryEntities.books.Add(books);
             libraryEntities.SaveChanges();
            
        }

        public void updateBookDetails(book book)
        {
            libraryEntities.Entry(book).State = System.Data.Entity.EntityState.Modified;
            libraryEntities.SaveChanges();
        }
    }
}
