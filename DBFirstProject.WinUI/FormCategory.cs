using DBFirstProject.BLL;
using DBFirstProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstProject.WinUI
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }
        CategoryController categoryController;
        private void FormCategory_Load(object sender, EventArgs e)
        {
            categoryController = new CategoryController();
            dgvCategories.DataSource = categoryController.GetCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.CategoryName = txtCategoryName.Text;
            category.Description = txtCategoryDescription.Text;
            categoryController.AddCategory(category);

        }
    }
}
