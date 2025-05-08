using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.VisualBasic;
using Npgsql;
using Domain.DTO;
namespace Infrastructure.Interface;

public interface IProductService
{
    List<Products> GetAllProducts();
    void CreateProducts(Products product);
    void UpdateProducts(Products product);
    void DeleteProducts(Products product);
}
