using ProductProject.Models.Dtos.RequestDto;
using ProductProject.Models.Entities;

namespace ProductProject.Services.Interfaces;

public interface IProductService
{
    //Create
    void Add(ProductAddRequestDto dto);

    //Read
    List<Product> GetAll();
    List<Product> GetByName(string name);
    List<Product> GetByStock(int min, int max);
    List<Product> GetByPrice(int min, int max);

    //Update
    void Update(ProductUpdateRequestDto dto);

    //Delete
    void Delete(int id);
}
