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

        public ArticleController(ApplicationDbContext applicationDbContext, IArticleRepository articleRepository)
        {
            _applicationDbContext = applicationDbContext;
            _articleRepository = articleRepository;
        }

        // GET: Article
        public ActionResult Index(int Id)
        {
            //Article article = _applicationDbContext.Articles.FirstOrDefault(a => a.Id == Id);
            Article article = _articleRepository.GetArticleById(Id);
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
            _articleRepository.AddArticle(article);

            return RedirectToAction("Index", "Dashboard", new { area = "" });
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult MyEdit(int id, Article article)
        {
            _articleRepository.EditArticle(id, article);
            return RedirectToAction("Index", "Dashboard", new { area = "" });
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
            _articleRepository.DeleteArticle(id);
            return RedirectToAction("Delete", "Dashboard");
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