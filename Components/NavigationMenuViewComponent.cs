using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
namespace OnlineBookstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;   // Instance of a template connected with EFCharityRepository connected with DBContext


        public NavigationMenuViewComponent(IBookRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()    // Drop a partial view into a view
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];   // Pulls from the url and says this is our selected category

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
