using Microsoft.AspNetCore.Mvc;
using ProductProject.Models.Dtos.RequestDto;
using ProductProject.Models.Entities;
using ProductProject.Repository;
using ProductProject.Services.Interfaces;

namespace ProductProject.Services.Concrete;

public class CategoryService : ICategoryService
{
    private readonly BaseDbContext _dbContext;

    public CategoryService(BaseDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //Create
    public void Add(CategoryAddRequestDto dto)
    {
        Category category = dto;
        _dbContext.Add(category);
        _dbContext.SaveChanges();
    }

    //Read
    public List<Category> GetAll()
    {
        List<Category> categories = _dbContext.Categories.ToList();
        return categories;
    }

    public Category GetById(int id)
    {
        Category? category = _dbContext.Categories.Find(id);
        if (category == null)
        {
            throw new Exception($"{id}'ye ait category bulunamadı");
        }
        return category;
    }

    //Update
    public void Update(CategoryUpdateRequestDto dto)
    {
        Category? category = _dbContext.Categories.Find(dto.Id);
        if (category == null)
        {
            throw new Exception($"{dto.Id}'ye ait category bulunamadı");
        }
        category = dto;
        _dbContext.Update(category);
        //_dbContext.Categories.Update(updatedCategory); neden çalışmıyor
        _dbContext.SaveChanges();
    }


    //Delete
    public void Delete(int id)
    {
        Category? category = _dbContext.Categories.Find(id);
        if (category == null)
        {
            throw new Exception($"{id}'ye ait category bulunamadı");
        }
        _dbContext.Remove(category);
        _dbContext.SaveChanges();
    }


}
