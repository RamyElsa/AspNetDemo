using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace AspDotNetDemo.Pages
{
    public class AboutModel : PageModel
    {
        private List<Book> books;
        public string Title;

        private readonly IConfiguration configuration;

        public AboutModel(IConfiguration configuration)
        {
            Title = "About Page";
            books = new List<Book>
            {
                new Book { Id = 1, Title = "Learn C#",Auther="Ramy",Price=240 },
                new Book { Id = 2, Title = "Learn Java",Auther="Zain",Price=250 },
                new Book { Id = 3, Title = "Learn C++",Auther="Kareem",Price=220 },
                new Book { Id = 4, Title = "Learn PHP",Auther="Mohamed",Price=270 }
            };
            // Inject 
            this.configuration = configuration;
            // Set
            //configuration["AboutPageTitle"] = "About Page from Model";
        }
        public void OnGet()
        {
            
        }
        public string GetTitle()
        {
            return Properties.Resources.AboutPageTitle;
        }

        public List<Book> GetBooks()
        {
            return books;
        }
        public string GetPageTitle()
        {
            // Get
            return configuration["AboutPageTitle"];
        }

    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Price { get; set; }

    }
}
