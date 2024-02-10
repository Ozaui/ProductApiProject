using ProductProject.Models.Dtos.RequestDto;
using ProductProject.Models.Entities;

namespace ProductProject.Services.Interfaces;

public interface ICategoryService
{
    //Create
    void Add(CategoryAddRequestDto dto);

    //Read
    List<Category> GetAll();
    Category GetById(int id);

    //Update
    void Update(CategoryUpdateRequestDto dto);

    //Delete
    void Delete(int id);
}
