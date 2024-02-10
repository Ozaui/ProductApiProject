using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductProject.Models.Dtos.RequestDto;
using ProductProject.Models.Entities;
using ProductProject.Services.Interfaces;

namespace ProductProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _service;

    public CategoryController(ICategoryService _service)
    {
        this._service = _service;
    }

    //Create
    [HttpPost("add")]
    public IActionResult Add(CategoryAddRequestDto dto)
    {
        _service.Add(dto);
        return Ok("Ekleme başarılı");
    }

    //Read
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<Category> categories =_service.GetAll();
        return Ok(categories);
    }
    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery]int id)
    {
        Category category = _service.GetById(id);
        return Ok(category);
    }

    //Update
    [HttpPut("update")]
    public IActionResult Update(CategoryUpdateRequestDto dto)
    {
        _service.Update(dto);
        return Ok("Güncelleme başarılı");
    }

    //Delete
    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        _service.Delete(id);
        return Ok("silme başarılı");
    }
}
