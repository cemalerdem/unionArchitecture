using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnionArcDemo.ApplicationCore.DTOs.Category;
using UnionArcDemo.ApplicationCore.Entities;
using UnionArcDemo.ApplicationCore.Interfaces.EFInitialize;
using UnionArcDemo.ApplicationCore.Interfaces.Repositories;
using UnionArcDemo.ApplicationCore.Interfaces.Services;
using UnionArcDemo.Common.RequestModel.Category;

namespace UnionArcDemo.ApplicationCore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }


        public async Task<List<CategoryDto>> GetCategories()
        {
            var categories = await _categoryRepository.Table.Select(x => new CategoryDto
            {
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToListAsync();

            return categories;
        }

        public async Task<CategoryDto> GetCategoryById(int categoryId)
        {
            var category = await _categoryRepository.GetAsync(cat => cat.CategoryId == categoryId);
            return category != null ? new CategoryDto {CategoryName = category.CategoryName, Description = category.Description} : new CategoryDto(null, null);
        }

        public async Task<Category> CreateCategoryAsync(CreateCategoryRequest categoryRequest)
        {
            Category entity = new Category
            {
                CategoryName = categoryRequest.CategoryName,
                Description = categoryRequest.Description,
                Picture = categoryRequest.Picture
            };

            _categoryRepository.Add(entity);
            await _unitOfWork.CommitAsync();
            return entity;

        }
    }
}