using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class EFBookRepository: IBookRepository
    {
        private BookDbContext _context; // This is the private version

        // Constructor
        public EFBookRepository (BookDbContext context) // When you create an EFBookRepos.. you need to pass in with it a BookDbContext
        {
            _context = context; // We then store context in to the private context object
        }

        public IQueryable<Book> Books => _context.Books; // The context here is going to be set to what we have created in the BookDbContext file
    }
}
