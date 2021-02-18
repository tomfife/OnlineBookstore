using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
// This is a template that defines what needs to be set up in what way