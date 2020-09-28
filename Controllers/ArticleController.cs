using Blog.Data;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Blog.Controllers
{
    public class ArticleController : Controller

    {
        private ApplicationDbContext _applicationDbContext;
        private IArticleRepository _articleRepository;

        public ArticleController(ApplicationDbContext applicationDbContext,IArticleRepository articleRepository)
        {
            _applicationDbContext = applicationDbContext;
            _articleRepository = articleRepository;
        }

        // GET: Article
        public ActionResult Index(int Id)
        {
            Article article = _applicationDbContext.Articles.FirstOrDefault(a => a.Id == Id);
            return View(article);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Article/Create
        /* public ActionResult Create()
         {
             return View();
         }*/

        // POST: Article/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleVM article)
        {
            Article art = new Article { Content = article.Content, CategoryId = article.CategoryId, Title = article.Title, Url = "Article/" + article.Title,PublishDate=DateTime.Now };
            art.Url = "Article"+art.Id;
            _applicationDbContext.Articles.Add(art);
            var res =_applicationDbContext.SaveChangesAsync().Result;
            
            return RedirectToAction("Index", "Dashboard", new { area = "" });
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            //Yeah, we can't delete only by id. We have to search record and then delete
            //But we can use EF Plus (3rd library).
            var art = _applicationDbContext.Articles.FirstOrDefault(x => x.Id == id);
            _applicationDbContext.Remove(art);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("Delete","Dashboard");
        }

        // POST: Article/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}