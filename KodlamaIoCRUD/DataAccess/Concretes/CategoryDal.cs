using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Programlama"
                }
            };
        }

        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _categories.Remove(category);
            }
            else
            {
                Console.WriteLine($"Category with id {id} not found");
            }
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Category entity)
        {
            var category = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (category != null)
            {
                category.Name = entity.Name;
            }
            else
            {
                Console.WriteLine($"Category with id {entity.Id} not found");
            }
        }
    }
}
