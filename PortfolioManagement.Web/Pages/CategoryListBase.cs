using Microsoft.AspNetCore.Components;
using PortfolioManagement.Models;

namespace PortfolioManagement.Web.Pages
{
    public class CategoryListBase : ComponentBase
    {
        public IEnumerable<Category> Categories { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadCategories();
            return base.OnInitializedAsync();
        }

        private void LoadCategories()
        {
            Category c1 = new Category
            {
                CategoryId = 1,
                CategoryName = "Games",
            };

            Category c2 = new Category
            {
                CategoryId = 2,
                CategoryName = "Web Projects",
            };

            Category c3 = new Category
            {
                CategoryId = 3,
                CategoryName = "Blender Projects",
            };

            Category c4 = new Category
            {
                CategoryId = 4,
                CategoryName = "Books",
            };

            Category c5 = new Category
            {
                CategoryId = 5,
                CategoryName = "Online Courses",
            };

            Category c6 = new Category
            {
                CategoryId = 6,
                CategoryName = "Magazines",
            };

            Categories = new List<Category> { c1, c2, c3, c4, c5, c6 };
        }
    }
}
