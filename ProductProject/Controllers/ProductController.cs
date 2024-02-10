using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductProject.Models.Dtos.RequestDto;
using ProductProject.Models.Entities;
using ProductProject.Services.Interfaces;

namespace ProductProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }
    //Create
    [HttpPost("add")]
    public IActionResult Add(ProductAddRequestDto dto)
    {
        _service.Add(dto);
        return Ok("Ekleme başarılı");
    }

    //Read
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<Product> products = _service.GetAll();
        return Ok(products);
    }
    [HttpGet("getbyname")]
    public IActionResult GetByName([FromQuery]string name) 
    {
        List<Product> product = _service.GetByName(name);
        return Ok(product);
    }
    [HttpGet("getbyprice")]
    public IActionResult GetByPrice([FromQuery]int min, [FromQuery]int max) 
    {
        List<Product> products = _service.GetByPrice(min, max);
        return Ok(products);
    }
    [HttpGet("getbystock")]
    public IActionResult GetByStock([FromQuery] int min, [FromQuery] int max)
    {
        List<Product> products = _service.GetByStock(min, max);
        return Ok(products);
    }

    //Update
    [HttpPut("Update")]
    public IActionResult Update([FromBody]ProductUpdateRequestDto dto)
    {
        _service.Update(dto);
        return Ok("güncelleme başarılı");
    }

    //Delete
    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        _service.Delete(id);
        return Ok("silme başarılı");
    }
}
