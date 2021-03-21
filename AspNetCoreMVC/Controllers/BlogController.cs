using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogDetails()
        {
            BlogAuthor blogAuthor = new BlogAuthor();
            blogAuthor.Name = "Stefan";
            blogAuthor.Surname = "Zweig";

            List<BlogDetails> blogDetails = new List<BlogDetails>()
            {
                new BlogDetails(){BookName="Olağan Üstü Bir Gece",Description="perfect",Image="1.jpg"},
                new BlogDetails(){BookName="Satranç",Description="perfect",Image="2.jpg"},
                new BlogDetails(){BookName="Ay Işığı Sokağı",Description="perfect",Image="3.jpg"},
                new BlogDetails(){BookName="Mecburiyet",Description="perfect",Image="4.jpg"},
                new BlogDetails(){BookName="Korku",Description="perfect",Image="5.jpg"},
            };

            (BlogAuthor, List<BlogDetails>) blog = (blogAuthor, blogDetails);
            return View(blog);
        }
    }
}
