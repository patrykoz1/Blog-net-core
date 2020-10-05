using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class DashboardController : Controller
    {
        private IArticleRepository _articlesRepository;

        public DashboardController(IArticleRepository articleRepository)
        {
            _articlesRepository = articleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DeleteArticle()
        {
            return View(_articlesRepository.GetArticles());
        }

        public IActionResult EditArticle()
        {
            return View(_articlesRepository.GetArticles());
        }

        public IActionResult AddArticle()
        {
            return View();
        }

        public IActionResult AddCategory()
        {
            return View();
        }
    }
}