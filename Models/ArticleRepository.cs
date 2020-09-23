using Blog.Models;
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

        public void AddArticle()
        {
            throw new NotImplementedException();
        }

        public Article GetArticleById()
        {
            throw new NotImplementedException();
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