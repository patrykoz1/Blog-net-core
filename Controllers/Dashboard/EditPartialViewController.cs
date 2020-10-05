using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Blog.Controllers.Dashboard
{
    public class EditPartialViewController : Controller
    {
        private ApplicationDbContext context;

        public EditPartialViewController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IActionResult TableSeeder(int id)
        {
            Article model = context.Articles.Where(x => x.Id == id).ToList()[0];// only one element
            String xd = id.ToString();
            
            return PartialView("~/Views/Dashboard/EditPartialView.cshtml", model);
        }
    }
}