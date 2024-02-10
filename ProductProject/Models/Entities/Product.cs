using ProductProject.Models.Dtos.RequestDto;

namespace ProductProject.Models.Entities;

public class Product:Entity
{
    public double Price { get; set; }
    public int Stock {  get; set; }
    public int CategoryId {  get; set; }
    public Category Category { get; set; }

    public static implicit operator Product(ProductAddRequestDto dto)
    {
        return new Product()
        {
            Price = dto.Price,
            Stock = dto.Stock,
            Category = dto.Category,
            Name = dto.Name
        };
    }

    public static implicit operator Product(ProductUpdateRequestDto dto)
    {
        return new Product()
        {
            Price = dto.Price,
            Stock = dto.Stock,
            Category = dto.Category,
            Name = dto.Name,
            Id = dto.Id,
        };
    }
}
