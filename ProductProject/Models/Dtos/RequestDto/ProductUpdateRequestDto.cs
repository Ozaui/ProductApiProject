using ProductProject.Models.Entities;

namespace ProductProject.Models.Dtos.RequestDto;

public class ProductUpdateRequestDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public Category Category { get; set; }
}
