using DataAccess.Abstract;
using Entities.Concrete;

public class CategoryManager : ICategoryDal
{
    private readonly CategoryDal _categoryDal;

    public CategoryManager(CategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}