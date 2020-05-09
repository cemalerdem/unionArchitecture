using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnionArcDemo.ApplicationCore.DTOs.Category;
using UnionArcDemo.ApplicationCore.Entities;
using UnionArcDemo.ApplicationCore.Interfaces.Services;
using UnionArcDemo.Common.RequestModel.Category;

namespace UnionArcDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("get-categories")]
        [ProducesResponseType(typeof(List<CategoryDto>),200)]
        public async Task<ActionResult<List<CategoryDto>>> GetCategoriesAsync()
        {
            try
            {
                var categories = await _categoryService.GetCategories();
                return Ok(categories);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("Id")]
        [ProducesResponseType(typeof(CategoryDto),200)]
        public async Task<ActionResult<CategoryDto>> GetCategoryByIdAsync(GetCategoryByIdRequest request)
        {
            try
            {
                var category = await _categoryService.GetCategoryById(request.CategoryId);
                return Ok(category);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("create-category")]
        [ProducesResponseType(typeof(Category), 201)]
        public async Task<ActionResult<CategoryDto>> CreateCategoryAsync(CreateCategoryRequest request)
        {
            try
            {
                var createdCategory = await _categoryService.CreateCategoryAsync(request);
                return Ok(createdCategory);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}