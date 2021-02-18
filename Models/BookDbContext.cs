using System;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Models
{
    public class BookDbContext : DbContext // DbContext instance represents a session with the database, CRUD - this is where this is happening
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base (options) // We need to know what options they selected of (BookContext), inherits from the base options
        {

        }

        public DbSet<Book> Books { get; set; } // DbSet is a built in type of the type that we are building (book), so Books
    }
}
