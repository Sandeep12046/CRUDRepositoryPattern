using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLibrary.Models;
namespace AppLibrary.Repository
{
    internal interface Ibooks
    {
        void insertBookDetails(book books);
        IEnumerable<book> getBookDetails();
        void updateBookDetails(book book);
        void deleteBookDetails(int book);
        book getBookByID(int id);

    }
}
