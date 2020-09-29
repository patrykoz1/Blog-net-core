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

        public IActionResult Delete()
        {
            return View(_articlesRepository.GetArticles());
        }

        public IActionResult Edit()
        {
            return View(_articlesRepository.GetArticles());
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}