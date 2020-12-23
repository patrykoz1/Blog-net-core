using Blog.Models;
using Blog.ViewModels;
using System;
using System.Collections.Generic;

namespace Blog.Data
{
    public interface IArticleRepository
    {
        public void AddArticle(ArticleVM article);
        public void DeleteArticle(int Id);
        public void EditArticle(int id, Article article);

        public Article GetArticleById(int Id);

        public IEnumerable<Article> GetArticles();

        public IEnumerable<Article> SearchArticles(String word);
    }
}