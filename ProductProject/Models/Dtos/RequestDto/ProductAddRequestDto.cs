using ProductProject.Models.Entities;

namespace ProductProject.Models.Dtos.RequestDto;

public class ProductAddRequestDto
{
    public string Name {  get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public Category Category { get; set; }
}
