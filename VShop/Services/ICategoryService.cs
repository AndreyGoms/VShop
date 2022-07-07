using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.Dtos;

namespace VShop.Services
{
    interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetCategories();
        Task<IEnumerable<CategoryDto>> GetCategoriesProducts();
        Task<CategoryDto> GetCategoryById(int id);
        Task AddCategory(CategoryDto categoryDto);
        Task UpdateCategory(CategoryDto categoryDto);
        Task RemoveCategory(int id);
    }
}
