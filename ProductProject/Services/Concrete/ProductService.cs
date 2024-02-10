using Microsoft.EntityFrameworkCore;
using ProductProject.Models.Dtos.RequestDto;
using ProductProject.Models.Entities;
using ProductProject.Repository;
using ProductProject.Services.Interfaces;
using System.Diagnostics.Eventing.Reader;

namespace ProductProject.Services.Concrete;

public class ProductService : IProductService
{
    private readonly BaseDbContext _dbContext;

    public ProductService(BaseDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //Create
    public void Add(ProductAddRequestDto dto)
    {
        Product product = dto;
        _dbContext.Add(product);
        _dbContext.SaveChanges();
    }

    //Read
    public List<Product> GetAll()
    {
        List<Product> products = _dbContext.Products.ToList();
        return products;
    }

    public List<Product> GetByName(string name)
    {
        List<Product> products = _dbContext.Products.Where(p => p.Name == name).ToList();//Find() olmuyor.Neden?
        if (products.Count == 0)
        {
            throw new Exception($"{name}'ye ait ürün bulunamadı.");
        }
        return products;
    }

    public List<Product> GetByPrice(int min, int max)
    {
        List<Product> products = _dbContext.Products.Where(x => x.Price > min && x.Price < max).ToList();
        return products;
    }

    public List<Product> GetByStock(int min, int max)
    {
        List<Product> products = _dbContext.Products.Where(x => x.Stock > min && x.Stock < max).ToList();
        return products;
    }

    //Update
    public void Update(ProductUpdateRequestDto dto)
    {
        Product? product = _dbContext.Products.Find(dto.Id);
        if (product == null)
        {
            throw new Exception($"{dto.Id}'ye ait kitap bulunamadı.");
        }
        product = dto;
        _dbContext.Update(product);//_dbContext.Product.Update(product) neden çalışmıyor
        _dbContext.SaveChanges();
    }
    


    //Delete
    public void Delete(int id)
    {
        Product? product = _dbContext.Products.Find(id);
        if (product == null)
        {
            throw new Exception($"{id}'ye ait kitap bulunamadı.");
        }
        _dbContext.Remove(product);
        _dbContext.SaveChanges();
    }
}
