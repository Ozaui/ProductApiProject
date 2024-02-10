using ProductProject.Models.Dtos.RequestDto;

namespace ProductProject.Models.Entities;

public class Category:Entity
{
    //public List<Product> products { get; set; }
    
    public static implicit operator Category(CategoryAddRequestDto dto)
    {
        return new Category()
        {
            Name = dto.Name,
        };
    }

    public static implicit operator Category(CategoryUpdateRequestDto dto)
    {
        return new Category()
        {
            Name = dto.Name,
            Id = dto.Id,
        };
    }
}
