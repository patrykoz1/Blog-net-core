using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        public String Content { get; set; }
        public String Title { get; set; }
        public int UserId { get; set; }
        public DateTime PublishDate { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public String Url { get; set; }
        //public SelectList ArticleList { get; set; }
    }
}