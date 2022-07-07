using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.Dtos;
using VShop.Models;
using VShop.Repositories;

namespace VShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper )
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetCategories()
        {
            var categoriesEntity = await _categoryRepository.GetAll();

            return _mapper.Map<IEnumerable<CategoryDto>>(categoriesEntity);
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoriesProducts()
        {
            var categoriesEntity = await _categoryRepository.GetCategoriesProducts();

            return _mapper.Map<IEnumerable<CategoryDto>>(categoriesEntity);
        }
        public async Task<CategoryDto> GetCategoryById(int id)
        {
            var categoriesEntity = await _categoryRepository.GetById(id);

            return _mapper.Map<CategoryDto>(categoriesEntity);
        }

        public async Task AddCategory(CategoryDto categoryDto)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDto);
            await _categoryRepository.Create(categoryEntity);
            categoryDto.CategoryID = categoryEntity.CategoryID;            
        }

        public async Task UpdateCategory(CategoryDto categoryDto)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDto);
            await _categoryRepository.Create(categoryEntity);
            categoryDto.CategoryID = categoryEntity.CategoryID;
        }

        public async Task RemoveCategory(int id)
        {
            var categoryEntity = _categoryRepository.GetById(id).Result;
            await _categoryRepository.Delete(categoryEntity.CategoryID);
        }
    }
}
