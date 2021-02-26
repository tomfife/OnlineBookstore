using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        BookTitle = "Les Miserables",

                        AuthorFirstName = "Victor",

                        AuthorLastName = "Hugo",

                        Publisher = "Signet",

                        PagesInBook = 1488,

                        ISBN = "978-0451419439",

                        Classification = "Fiction",

                        Category = "Classic",

                        BookPrice = 9.95
                    },

                    new Book
                    {
                        BookTitle = "Team of Rivals",

                        AuthorFirstName = "Doris",

                        AuthorMiddleName = "Kearns",

                        AuthorLastName = "Goodwin",

                        Publisher = "Simon & Schuster",

                        PagesInBook = 944,

                        ISBN = "978-0743270755",

                        Classification = "Non-Fiction",

                        Category = "Biography",

                        BookPrice = 14.58
                    },

                    new Book
                    {
                        BookTitle = "The Snowball",

                        AuthorFirstName = "Alice",

                        AuthorLastName = "Schroeder",

                        Publisher = "Bantam",

                        PagesInBook = 832,

                        ISBN = "978-0553384611",

                        Classification = "Non-Fiction",

                        Category = "Biography",

                        BookPrice = 21.54
                    },

                new Book
                {
                    BookTitle = "American Ulysses",

                    AuthorFirstName = "Ronald",

                    AuthorMiddleName = "C.",

                    AuthorLastName = "White",

                    Publisher = "Random House",

                    PagesInBook = 864,

                    ISBN = "978-0812981254",

                    Classification = "Non-Fiction",

                    Category = "Biography",

                    BookPrice = 11.61
                },

                new Book
                {
                    BookTitle = "Unbroken",

                    AuthorFirstName = "Laura",

                    AuthorLastName = "Hillenbrand",

                    Publisher = "Random House",

                    PagesInBook = 528,

                    ISBN = "978-0812974492",

                    Classification = "Non-Fiction",

                    Category = "Historical",

                    BookPrice = 13.33
                },


                new Book
                {
                    BookTitle = "The Great Train Robbery",

                    AuthorFirstName = "Michael",

                    AuthorLastName = "Crichton",

                    Publisher = "Vintage",

                    PagesInBook = 288,

                    ISBN = "978-0804171281",

                    Classification = "Fiction",

                    Category = "Historical Fiction",

                    BookPrice = 15.95
                },

                new Book
                {
                    BookTitle = "Deep Work",

                    AuthorFirstName = "Cal",

                    AuthorLastName = "Newport",

                    Publisher = "Grand Central Publishing",

                    PagesInBook = 304,

                    ISBN = "978-1455586691",

                    Classification = "Non-Fiction",

                    Category = "Self-Help",

                    BookPrice = 14.99
                },

                new Book
                {
                    BookTitle = "It's Your Ship",

                    AuthorFirstName = "Michael",

                    AuthorLastName = "Abrashoff",

                    Publisher = "Grand Central Publishing",

                    PagesInBook = 240,

                    ISBN = "978-1455523023",

                    Classification = "Non-Fiction",

                    Category = "Self-Help",

                    BookPrice = 21.66
                },

                new Book
                {
                    BookTitle = "The Virgin Way",

                    AuthorFirstName = "Richard",

                    AuthorLastName = "Branson",

                    Publisher = "Portfolio",

                    PagesInBook = 400,

                    ISBN = "978-1591847984",

                    Classification = "Non-Fiction",

                    Category = "Business",

                    BookPrice = 29.16
                },

                 new Book
                 {
                     BookTitle = "Sycamore Row",

                     AuthorFirstName = "John",

                     AuthorLastName = "Grisham",

                     Publisher = "Bantam",

                     PagesInBook = 642,

                     ISBN = "978-0553393613",

                     Classification = "Fiction",

                     Category = "Thrillers",

                     BookPrice = 15.03
                 },

                 new Book
                 {
                     BookTitle = "How Will You Measure Your Life",

                     AuthorFirstName = "Clayton",

                     AuthorMiddleName = "M.",

                     AuthorLastName = "Christensen",

                     Publisher = "Haper Collins",

                     PagesInBook = 221,

                     ISBN = "978-0062102416",

                     Classification = "Non-Fiction",

                     Category = "Business",

                     BookPrice = 18.67
                 },

                 new Book
                 {
                     BookTitle = "The Power of Habit",

                     AuthorFirstName = "Charles",

                     AuthorLastName = "Duhigg",

                     Publisher = "Random House",

                     PagesInBook = 416,

                     ISBN = "978-0812981605",

                     Classification = "Non-Fiction",

                     Category = "Self-Help",

                     BookPrice = 17.78
                 },

                 new Book
                 {
                     BookTitle = "Drawing on the Powers of Heaven",

                     AuthorFirstName = "Grant",

                     AuthorMiddleName = "Von",

                     AuthorLastName = "Harrison",

                     Publisher = "Publishers Book Sales",

                     PagesInBook = 85,

                     ISBN = "978-0910558006",

                     Classification = "Non-Fiction",

                     Category = "Gospel",

                     BookPrice = 11.99
                 }
                );

                context.SaveChanges();
            }
        }
    }
}
