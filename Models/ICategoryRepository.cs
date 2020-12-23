using Blog.ViewModels;

namespace Blog.Data
{
    public interface ICategoryRepository
    {
        public void AddCategory(CategoryVM catvm);
    }
}