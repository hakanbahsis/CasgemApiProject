using Casgem.BusinessLayer.Abstract;
using Casgem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
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

        [HttpGet("getCategoryList")]
        public IActionResult GetCategorylist()
        {
            var values = _categoryService.GetAll();
            return Ok(values);
        }

        [HttpPost("addCategory")]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.Add(category);
            return Ok();
        }

        [HttpGet("deleteCategory/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values=_categoryService.GetById(id);
            _categoryService.Delete(values);
            return Ok();
        }

        [HttpPost("updateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.Update(category);
            return Ok();
        }

        [HttpGet("getCategory/{id}")]
        public IActionResult GetCategory(int id)
        {
            var values= _categoryService.GetById(id);
            return Ok(values);
        }
    }
}
