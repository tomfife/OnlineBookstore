using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; } // Auto-incrementing Id - Primary Key
        // Pretty sure you don't have to put [key] here, but double check

        [Required(ErrorMessage = "Please enter a book Title")]
        public string BookTitle { get; set; }

        [Required]
        [RegularExpression(@"(?=(?:\D *\d){10}(?:(\D*\d){3})?$)[\d-]+$", ErrorMessage = "Please enter the ISBN in the proper format")]
        public string ISBN { get; set; } // Can't remember if this needs to be a string or an int
        // Also, remember to do validation elsewhere

        [Required(ErrorMessage = "Please enter the Author's First Name")]
        public string AuthorFirstName { get; set; }

        public string? AuthorMiddleName { get; set; } // Not required becuase some Authors don't include middle name

        [Required(ErrorMessage = "Please enter the Author's First Name")]
        public string AuthorLastName { get; set; }

        [Required(ErrorMessage = "Please enter a classification")]
        public string Classification { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter the Publisher")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please enter the price of the book")]
        public double BookPrice { get; set; }
    }
}
