using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantApp.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId = 1, CategoryName = "Easy to Grow", Description = "These Plants will make anyone feel as if they have a green thumb"},
                    new Category{CategoryId = 2, CategoryName = "Moderatly Easy to Grow", Description = "These group of plants will need a little more care."},
                    new Category{CategoryId = 3, CategoryName = "Challenging to Grow", Description = "These plants may need more specialized care"}

                };
            }
        }
    }
}
