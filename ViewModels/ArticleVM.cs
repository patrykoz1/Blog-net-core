using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class ArticleVM
    {
        public String Content { get; set; }
        public String Title { get; set; }
        public int CategoryId { get; set; }
    }
}
