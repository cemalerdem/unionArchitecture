using System.Collections.Generic;
using System.Threading.Tasks;
using UnionArcDemo.ApplicationCore.DTOs.Category;
using UnionArcDemo.ApplicationCore.Entities;
using UnionArcDemo.Common.RequestModel.Category;

namespace UnionArcDemo.ApplicationCore.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategories();
        Task<CategoryDto> GetCategoryById(int categoryId);
        Task<Category> CreateCategoryAsync(CreateCategoryRequest categoryRequest);
    }
}