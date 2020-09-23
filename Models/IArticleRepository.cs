using Blog.Models;
using System;
using System.Collections.Generic;

namespace Blog.Data
{
    public interface IArticleRepository
    {
        public void AddArticle();

        public Article GetArticleById();

        public IEnumerable<Article> GetArticles();

        public IEnumerable<Article> SearchArticles(String word);
    }
}