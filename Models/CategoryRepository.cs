using Blog.ViewModels;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext applicationDbContext;
        public CategoryRepository(ApplicationDbContext _applicationDbContext)
        {
            this.applicationDbContext = _applicationDbContext;
        }
        public void AddCategory(CategoryVM catvm)
        {
            Category category = new Category { Name = catvm.Name };
            applicationDbContext.Categories.Add(category);
            var res = applicationDbContext.SaveChangesAsync().Result;
        }
    }
}
