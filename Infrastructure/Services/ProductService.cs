using Dapper;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class ProductService
{
    private readonly DataContext context = new DataContext();

    public List<Products> GetAllProducts()
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"select * from products";
            var result = connection.Query<Products>(sql).ToList();
            return result;
        }
    }
    public string CreateProducts(Products products)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"insert into products(id,name,price,categoryId,marketId,quantity,createdAt)
                        values (@id,@name,@price,@categoryId,@marketId,@quantity,@createdAt)";
            var result = connection.Execute(sql,products);
            return result > 0 ? "Success" : "Failed";  
        }
    }
    public string UpdateProducts(Products products)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"update products set name = @name , price = @price, categoryId = @categoryId, marketId = @marketId, quantity = @quantity
                        where id = @id";
            var result = connection.Execute(sql,products);
            return result > 0 ? "Success" : "Failed";
        }
    }
    public string DeleteProducts(Products products)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"delete from products where id = @id";
            var result = connection.Execute(sql,products);
            return result > 0 ? "Success" : "Failed";
        }
    }
    //task2
    public List<Products> GetPoructByCategory(Products products)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"select c.name, count(p.id) from category c
                        join products p on p.categoryId = c.id
                        group by c.name;";
            var result = connection.Query<Products>(sql).ToList();
            return result;
        }
    }
    //task3
    public List<Products> GetProductByMarket(Products products)
    {
        using (var connection = context.GetDbConnection())
        {
            connection.Open();
            var sql = @"select p.name, c.name, m.name from products p
                        join category c on p.categoryId = c.id
                        join markets m on p.marketId = m.id;";
            var result = connection.Query<Products>(sql).ToList();
            return result;
        }
    }
    //task4
    
}
