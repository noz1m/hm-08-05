
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.VisualBasic;
using Npgsql;
using Domain.DTO;namespace Infrastructure.Interface;

public interface ICategoryService
{
    List<Category> GetAllCategory();
    void CreateCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(Category category);
}
