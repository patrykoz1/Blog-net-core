using Blog.Models;
using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Data
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ArticleRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void DeleteArticle(int Id)
        {
            //Yeah, we can't delete only by id. We have to search record and then delete
            //But we can use EF Plus (3rd library).
            var art = _applicationDbContext.Articles.FirstOrDefault(x => x.Id == Id);
            _applicationDbContext.Remove(art);
            _applicationDbContext.SaveChanges();
            
        }
        public void AddArticle(ArticleVM article)
        {
            Article art = new Article { Content = article.Content, CategoryId = article.CategoryId, Title = article.Title, Url = "Article/" + article.Title, PublishDate = DateTime.Now };
            art.Url = "Article" + art.Id;
            _applicationDbContext.Articles.Add(art);
            var res = _applicationDbContext.SaveChangesAsync().Result;
        }
        public void EditArticle(int id, Article article)
        {
            Article editedArt = _applicationDbContext.Articles.FirstOrDefault(x => x.Id == id);
            editedArt.Title = article.Title;
            editedArt.CategoryId = article.CategoryId;
            editedArt.Content = article.Content;
            editedArt.PublishDate = DateTime.Now;
            _applicationDbContext.SaveChanges();
        }


        public Article GetArticleById(int Id)
        {
            Article article = _applicationDbContext.Articles.FirstOrDefault(a => a.Id == Id);
            return article;
        }

        public IEnumerable<Article> GetArticles()
        {
            return _applicationDbContext.Articles;
        }

        public IEnumerable<Article> SearchArticles(String word)
        {
            return _applicationDbContext.Articles.Where(x => x.Title.Contains(word));
        }
    }
}