using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstProject.DAL.Management
{
    public class CategoryManagement
    {
        private NorthwindEntities database;

        public CategoryManagement()
        {
            database = new NorthwindEntities();
        }

        public Categories AddCategory(Categories category)
        {
            return database.Set<Categories>().Add(category);
        }

        public void UpdateCategory(Categories category)
        {
            database.Entry(category).State = EntityState.Modified;
        }

        public void DeleteCategory(Categories category)
        {
            database.Set<Categories>().Remove(category);
        }

        public void ChangeCategory(Categories oldCategories, Categories newCategories)
        {
            database.Entry(oldCategories).CurrentValues.SetValues(newCategories);
        }

        public List<Categories> GetCategory()
        {
            return database.Set<Categories>().ToList();
        }

        public Categories GetCategoryById(int CategoryId)
        {        
            return database.Set<Categories>().FirstOrDefault(c => c.CategoryID == CategoryId);
        }

        public int CategoryChangeSave()
        {
            return database.SaveChanges(); 
        }
    }
}
