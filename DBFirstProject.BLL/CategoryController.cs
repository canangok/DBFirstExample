using DBFirstProject.DAL;
using DBFirstProject.DAL.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstProject.BLL
{
    public class CategoryController
    {
        CategoryManagement categoryManagement;
        public CategoryController()
        {
            categoryManagement = new CategoryManagement();
        }

        public Categories AddCategory(Categories categories)
        {
            Categories addedCategory = null;

            if (categories == null)
                return null;

            if (categories.CategoryName.Length > 50)
                return null;

            addedCategory = categoryManagement.AddCategory(categories);
            categoryManagement.CategoryChangeSave();



            return addedCategory;
        }

        public List<Categories> GetCategories()
        {
            return categoryManagement.GetCategory();
        }
    }
}
