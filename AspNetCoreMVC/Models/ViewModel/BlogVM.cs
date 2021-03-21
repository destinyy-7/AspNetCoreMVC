using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC.Models.ViewModel
{
    public class BlogVM
    {
        public BlogAuthor blogAuthor { get; set; }
        public List<BlogDetails> blogDetails { get; set; }
    }
}
