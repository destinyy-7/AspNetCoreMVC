using AspNetCoreMVC.Models;
using AspNetCoreMVC.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult AnaSayfa()
        {
            return View();
        }
        public IActionResult Blog()
        {
            BlogAuthor blogAuthor = new BlogAuthor();
            blogAuthor.Name = "Oğuz";
            blogAuthor.Surname = "Atay";

            List<BlogDetails> blogDetails = new List<BlogDetails>()
            {
                new BlogDetails(){BookName="Oyunlarla Yaşayanlar",Description="perfect",Image="6.jpg"},
                new BlogDetails(){BookName="Tutunamayanlar",Description="perfect",Image="7.jpg"},
                new BlogDetails(){BookName="Tehlikeli Oyunlar",Description="perfect",Image="8.jpg"},
                new BlogDetails(){BookName="Korkuyu Beklerken",Description="perfect",Image="9.jpg"},
                new BlogDetails(){BookName="Günlük",Description="perfect",Image="10.jpg"},
            };

            BlogVM blog = new BlogVM();
            blog.blogAuthor = blogAuthor;
            blog.blogDetails = blogDetails;

            return View(blog);

        }
        public IActionResult İletişim()
        {
            BlogAuthor blogAuthor = new BlogAuthor();
            blogAuthor.Name = "Kader";
            blogAuthor.Surname = "Güneş";

            return View(blogAuthor);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
